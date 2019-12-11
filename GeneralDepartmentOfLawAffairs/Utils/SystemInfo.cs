using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using DevExpress.Utils;
using DevExpress.XtraSpellChecker.Strategies;

namespace GeneralDepartmentOfLawAffairs.Utils {
    public class SystemInfo {
        static int stateCounter = 0;
        static int lockTimerCounter = 0;

        public readonly string CsName;
        public readonly string CsManufacturer;
        public readonly string CsModel;

        public readonly string OsName;
        public readonly string OsVersion;
        public readonly string OsArchitecture;
        public readonly DateTime OsInstallDate;

        public readonly string ProcessorName;
        public readonly string ProcDescription;
        public readonly uint ProcMaxClockSpeed;
        public readonly uint ProcCurrentClockSpeed;
        public readonly uint ProcNumberOfCores;
        public readonly string ProcManufacturer;
        public readonly string ProcSocketDesignation;
        public readonly string ProcStatus;

        public readonly int TotalMemory;
        public readonly int FreeMemory;


        public SystemInfo() {
            buffer = new PerfomanceInfo_CPU[3];
            using (WaitDialogForm dlg = new WaitDialogForm("Please Wait", "Connecting WMI Service ...")) {
                wmiService = WMIService.GetInstance(null);

                if (wmiService.Connected) {
                    string[] processors = GetProcessorNames(wmiService);
                    ProcessorName = processors[0];
                    OsName = (string) GetInfo(wmiService, "Win32_OperatingSystem", "Caption");
                    TotalMemory = GetTotalMemorySizeMB(wmiService);
                    FreeMemory = GetFreeMemorySizeMB(wmiService);
                    OsVersion = (string) GetInfo(wmiService, "Win32_OperatingSystem", "Version");
                    CsName = (string) GetInfo(wmiService, "Win32_OperatingSystem", "CSName");
                    OsArchitecture = (string) GetInfo(wmiService, "Win32_OperatingSystem", "OSArchitecture");

                    GetProperties(wmiService);

                    CsManufacturer = (string) GetInfo(wmiService, "Win32_ComputerSystem", "Manufacturer");
                    CsModel = (string) GetInfo(wmiService, "Win32_ComputerSystem", "Model");
                    //OsInstallDate = (DateTime) GetInfo(wmiService, "Win32_OperatingSystem", "InstallDate");
                    //Debug.WriteLine(GetInfo(wmiService, "Win32_OperatingSystem", "InstallDate"));
                    ProcDescription = (string) GetInfo(wmiService, "Win32_Processor", "Description");
                    ProcMaxClockSpeed = (uint) GetInfo(wmiService, "Win32_Processor", "MaxClockSpeed");
                    ProcCurrentClockSpeed = (uint) GetInfo(wmiService, "Win32_Processor", "CurrentClockSpeed");
                    ProcNumberOfCores = (uint) GetInfo(wmiService, "Win32_Processor", "NumberOfCores");
                    ProcManufacturer = (string) GetInfo(wmiService, "Win32_Processor", "Manufacturer");
                    ProcSocketDesignation = (string) GetInfo(wmiService, "Win32_Processor", "SocketDesignation");
                    ProcStatus = (string) GetInfo(wmiService, "Win32_Processor", "Status");


                    //DashboardGauge.Scales["hddTotal"].MaxValue = GetTotalHDDSizeGB(wmiService);
                    this.pollingTimer = new System.Threading.Timer(OnTimerCallback, null, 1000, 300);
                    OnTimerCallback(null);
                }
            }
        }

        static int GetTotalMemorySizeMB(WMIService wmiService) {
            ManagementObject[] collection =
                wmiService.GetObjects("Select TotalVisibleMemorySize From Win32_OperatingSystem", true);
            return (collection.Length == 1)
                ? (int) ((ulong) collection[0].Properties["TotalVisibleMemorySize"].Value / 1024)
                : 4096;
        }

        static int GetFreeMemorySizeMB(WMIService wmiService) {
            ManagementObject[] collection =
                wmiService.GetObjects("Select FreePhysicalMemory From Win32_OperatingSystem", false);
            return (collection.Length == 1)
                ? (int) ((ulong) collection[0].Properties["FreePhysicalMemory"].Value / 1024)
                : 4096;
        }

        static int GetTotalHDDSizeGB(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select Size From Win32_LogicalDisk ", true);
            ulong size = 0;
            for (int i = 0; i < collection.Length; i++) {
                PropertyData pData = collection[i].Properties["Size"];
                size += ((pData != null && pData.Value != null) ? (ulong) pData.Value : 0u);
            }

            return (int) (size >> 30);
        }

        static int GetFreeHDDSizeGB(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select FreeSpace From Win32_LogicalDisk ", false);
            ulong size = 0;
            for (int i = 0; i < collection.Length; i++) {
                PropertyData pData = collection[i].Properties["FreeSpace"];
                size += ((pData != null && pData.Value != null) ? (ulong) pData.Value : 0u);
            }

            return (int) (size >> 30);
        }

        static string[] GetProcessorNames(WMIService wmiService) {
            ManagementObject[] collection = wmiService.GetObjects("Select Name From Win32_Processor", true);
            string[] result = new string[collection.Length];
            for (int i = 0; i < collection.Length; i++) {
                result[i] = (string) collection[i].Properties["Name"].Value;
            }

            return result;
        }

        static void GetProperties(WMIService wmiService) {
            ManagementObject[] collection =
                wmiService.GetObjects("Select * From Win32_PerfFormattedData_PerfOS_Processor", true);
            for (int i = 0; i < collection.Length; i++) {
                Debug.WriteLine(Environment.NewLine);
                foreach (var cl in collection[i].Properties) {
                    Debug.WriteLine(cl.Name + " = " + cl.Value + " >>>>> " + cl.Type);
                }
            }
        }

        static object GetInfo(WMIService wmiService, string tableName, string propertyName) {
            ManagementObject[] collection = wmiService.GetObjects($"Select {propertyName} From {tableName}", true);
            return (collection.Length == 1) ? (object) collection[0].Properties[propertyName].Value : string.Empty;
        }

        static PerfomanceInfo_CPU[] GetPerfomanceInfo_CPU(WMIService wmiService) {
            PerfomanceInfo_CPU[] result = new PerfomanceInfo_CPU[0];
            try {
                ManagementObject[] collection = wmiService.GetObjects(
                    "SELECT Name,PercentProcessorTime,PercentPrivilegedTime,PercentUserTime " +
                    "FROM Win32_PerfFormattedData_PerfOS_Processor " +
                    "WHERE Name=\'_Total\'",
                    false
                );
                result = new PerfomanceInfo_CPU[collection.Length];
                for (int i = 0; i < collection.Length; i++) {
                    result[i] = new PerfomanceInfo_CPU(
                        (string) collection[i].Properties["Name"].Value,
                        (float) (ulong) collection[i].Properties["PercentProcessorTime"].Value,
                        (float) (ulong) collection[i].Properties["PercentPrivilegedTime"].Value,
                        (float) (ulong) collection[i].Properties["PercentUserTime"].Value
                    );
                }
            }
            catch {
            }

            return result;
        }

        static PerfomanceInfo_OS[] GetPerfomanceInfo_OS(WMIService wmiService) {
            PerfomanceInfo_OS[] result = new PerfomanceInfo_OS[0];
            try {
                ManagementObject[] collection = wmiService.GetObjects(
                    "SELECT Name,Processes,Threads " +
                    "FROM Win32_PerfFormattedData_PerfOS_System",
                    false
                );
                result = new PerfomanceInfo_OS[collection.Length];
                for (int i = 0; i < collection.Length; i++) {
                    result[i] = new PerfomanceInfo_OS(
                        (string) collection[i].Properties["Name"].Value,
                        (int) (uint) collection[i].Properties["Processes"].Value,
                        (int) (uint) collection[i].Properties["Threads"].Value
                    );
                }
            }
            catch {
            }

            return result;
        }

        PerfomanceInfo_CPU[] buffer;
        WMIService wmiService;
        Timer pollingTimer;

        void OnTimerCallback(object state) {
            if (Interlocked.CompareExchange(ref lockTimerCounter, 1, 0) == 0) {
                UpdateData();
                stateCounter++;
                Interlocked.Add(ref lockTimerCounter, -1);
            }
        }

        void InvokeUpdate(Action action) {
            //if (IsHandleCreated && DashboardGauge != null)
            // BeginInvoke(action);
        }

        void UpdateData() {
            if (wmiService != null) {
                UpdatePerfomanceData_CPU();
                if (stateCounter % 5 == 0) UpdatePerfomanceData_OS();
                if (stateCounter % 10 == 0) UpdatePerfomanceData_Memory();
                if (stateCounter % 20 == 0) UpdatePerfomanceData_HDD();
            }
        }

        void UpdatePerfomanceData_CPU() {
            PerfomanceInfo_CPU[] infos = GetPerfomanceInfo_CPU(wmiService);
            if (infos.Length == 1) {
                PerfomanceInfo_CPU info = GetBufferedPerfomanceInfo(infos[0]);
                InvokeUpdate(() => {
                    //DashboardGauge.Scales["cpuTotal"].Value = info.Total;
                    //DashboardGauge.Scales["cpuUser"].Value = info.Kernel + info.User;
                    //DashboardGauge.Scales["cpuKernel"].Value = info.Kernel;
                });
            }
        }

        void UpdatePerfomanceData_OS() {
            PerfomanceInfo_OS[] infos = GetPerfomanceInfo_OS(wmiService);
            if (infos.Length == 1) {
                InvokeUpdate(() => {
                    //DashboardGauge.Scales["osThreads"].Value = infos[0].Threads;
                    //DashboardGauge.Scales["osProcesses"].Value = infos[0].Processes;
                });
            }
        }

        void UpdatePerfomanceData_Memory() {
            //InvokeUpdate(() => { DashboardGauge.Scales["memoryTotal"].Value = GetFreeMemorySizeMB(wmiService); });
        }

        void UpdatePerfomanceData_HDD() {
            //InvokeUpdate(() => { DashboardGauge.Scales["hddTotal"].Value = GetFreeHDDSizeGB(wmiService); });
        }

        /*
        void OnUpdateSpeedChanged(object sender, EventArgs e) {
            int speed = 50 + (updateSpeed.Properties.Maximum - updateSpeed.Value) * 50;
            if (pollingTimer != null) pollingTimer.Change(0, speed);
        } */

        PerfomanceInfo_CPU GetBufferedPerfomanceInfo(PerfomanceInfo_CPU currentValue) {
            for (int i = 1; i < buffer.Length; i++) buffer[i - 1] = buffer[i];
            buffer[buffer.Length - 1] = currentValue;

            float total = 0;
            float kernel = 0;
            float user = 0;
            int n = 0;
            for (int i = 0; i < buffer.Length; i++) {
                if (buffer[i] != null) {
                    total += buffer[i].Total;
                    kernel += buffer[i].Kernel;
                    user += buffer[i].User;
                    n++;
                }
            }

            return new PerfomanceInfo_CPU(currentValue.Name, total / (float) n, kernel / (float) n, user / (float) n);
        }

        /*
        protected CircularGauge DashboardGauge {
            get { return gaugeControl1.Gauges[0] as CircularGauge; }
        }

        public override bool ShowExportMenu {
            get { return true; }
        }

        public override GaugeControl ExportControl {
            get { return gaugeControl1; }
        }
         */
        class PerfomanceInfo_CPU {
            string nameCore;
            float totalCore;
            float kernelCore;
            float userCore;

            public string Name {
                get { return nameCore; }
            }

            public float Total {
                get { return totalCore; }
            }

            public float Kernel {
                get { return kernelCore; }
            }

            public float User {
                get { return userCore; }
            }

            public PerfomanceInfo_CPU(string name, float total, float kernel, float user) {
                nameCore = name;
                totalCore = total;
                kernelCore = kernel;
                userCore = user;
            }
        }

        class PerfomanceInfo_OS {
            string nameCore;
            int processesCore;
            int threadsCore;

            public string Name {
                get { return nameCore; }
            }

            public int Processes {
                get { return processesCore; }
            }

            public int Threads {
                get { return threadsCore; }
            }

            public PerfomanceInfo_OS(string name, int processes, int threads) {
                nameCore = name;
                processesCore = processes;
                threadsCore = threads;
            }
        }

        class MemoryPerfomanceInfo {
            string nameCore;
            int totalCore;
            int freeCore;

            public string Name {
                get { return nameCore; }
            }

            public int Total {
                get { return totalCore; }
            }

            public int Free {
                get { return freeCore; }
            }

            public MemoryPerfomanceInfo(string name, int total, int free) {
                nameCore = name;
                totalCore = total;
                freeCore = free;
            }
        }


        // 
        public sealed class WMIService : IDisposable {
            public static WMIService GetInstance(string path) {
                return new WMIService(string.IsNullOrEmpty(path) ? "//./root/cimv2" : path);
            }

            bool connectedCore = false;
            ManagementScope scopeCore;
            Dictionary<string, ManagementObjectCollection> queryCacheCore;

            Dictionary<string, ManagementObjectCollection> QueryCache {
                get { return queryCacheCore; }
            }

            public bool Connected {
                get { return connectedCore; }
            }

            public ManagementScope Scope {
                get { return scopeCore; }
            }

            WMIService(string path) {
                queryCacheCore = new Dictionary<string, ManagementObjectCollection>();
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = ImpersonationLevel.Impersonate;
                options.Authentication = AuthenticationLevel.Packet;
                this.scopeCore = new ManagementScope(path, options);
                try {
                    Scope.Connect();
                    connectedCore = Scope.IsConnected;
                }
                catch {
                    connectedCore = false;
                }
            }

            ManagementObjectCollection GetManagementObjectCollection(string queryString) {
                ManagementObjectCollection result = null;
                ObjectQuery query = new ObjectQuery(queryString);
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(Scope, query)) {
                    result = searcher.Get();
                }

                return result;
            }

            public void Dispose() {
                connectedCore = false;
                if (queryCacheCore != null) {
                    foreach (KeyValuePair<string, ManagementObjectCollection> pair in queryCacheCore) {
                        if (pair.Value != null) pair.Value.Dispose();
                    }

                    queryCacheCore.Clear();
                    queryCacheCore = null;
                }

                scopeCore = null;
            }

            public ManagementObjectCollection GetObjectCollection(string queryString, bool allowQueryCaching) {
                ManagementObjectCollection result = null;
                if (allowQueryCaching) QueryCache.TryGetValue(queryString, out result);
                if (result == null) {
                    result = GetManagementObjectCollection(queryString);
                    if (allowQueryCaching) {
                        if (QueryCache.ContainsKey(queryString)) QueryCache[queryString] = result;
                        else QueryCache.Add(queryString, result);
                    }
                }

                return result;
            }

            public ManagementObject[] GetObjects(string queryString, bool allowQueryCaching) {
                ManagementObject[] result = new ManagementObject[0];
                ManagementObjectCollection collection = GetObjectCollection(queryString, allowQueryCaching);
                int count = collection.Count;
                if (collection != null && count > 0) {
                    result = new ManagementObject[count];
                    collection.CopyTo(result, 0);
                }

                return result;
            }
        }
    }
}