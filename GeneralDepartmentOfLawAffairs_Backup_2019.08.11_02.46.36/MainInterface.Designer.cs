namespace GeneralDepartmentOfLawAffairs
{
    partial class MainInterface : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainInterface()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_lawAffairs = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.mnuAddSubject = this.Factory.CreateRibbonMenu();
            this.btnAddCeaseInvestigation = this.Factory.CreateRibbonButton();
            this.btnAddInvestigation = this.Factory.CreateRibbonButton();
            this.btnAddInspection = this.Factory.CreateRibbonButton();
            this.btnCase = this.Factory.CreateRibbonButton();
            this.separator4 = this.Factory.CreateRibbonSeparator();
            this.mnuInvestigation = this.Factory.CreateRibbonMenu();
            this.mnuNotification = this.Factory.CreateRibbonMenu();
            this.btnNormalNotification = this.Factory.CreateRibbonButton();
            this.btnConfNotification = this.Factory.CreateRibbonButton();
            this.btnSpecialNotification = this.Factory.CreateRibbonButton();
            this.btnInvestInquiry = this.Factory.CreateRibbonButton();
            this.mnuInvestigationNote = this.Factory.CreateRibbonMenu();
            this.btnCeaseNote = this.Factory.CreateRibbonButton();
            this.btnRegularNote = this.Factory.CreateRibbonButton();
            this.btnTableNote = this.Factory.CreateRibbonButton();
            this.btnInvestigationRefererringLetter = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.mnuInspection = this.Factory.CreateRibbonMenu();
            this.btnInspecInquiry = this.Factory.CreateRibbonButton();
            this.btnInspectionNote = this.Factory.CreateRibbonButton();
            this.btnInspctionRefererringLetter = this.Factory.CreateRibbonButton();
            this.separator8 = this.Factory.CreateRibbonSeparator();
            this.mnuCase = this.Factory.CreateRibbonMenu();
            this.btnIssuanceRescript = this.Factory.CreateRibbonButton();
            this.btnRescriptSent = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.mnuMescLetters = this.Factory.CreateRibbonMenu();
            this.btnGeneralLetter = this.Factory.CreateRibbonButton();
            this.btnLetterReplay = this.Factory.CreateRibbonButton();
            this.btnNominationLetters = this.Factory.CreateRibbonButton();
            this.btnMission = this.Factory.CreateRibbonButton();
            this.separator3 = this.Factory.CreateRibbonSeparator();
            this.mnuRush = this.Factory.CreateRibbonMenu();
            this.separator5 = this.Factory.CreateRibbonSeparator();
            this.btn_report = this.Factory.CreateRibbonButton();
            this.separator7 = this.Factory.CreateRibbonSeparator();
            this.btn_settings = this.Factory.CreateRibbonButton();
            this.separator6 = this.Factory.CreateRibbonSeparator();
            this.menu_help = this.Factory.CreateRibbonMenu();
            this.btnHelp = this.Factory.CreateRibbonButton();
            this.btnAbout = this.Factory.CreateRibbonButton();
            this.btnLetter = this.Factory.CreateRibbonButton();
            this.tab_lawAffairs.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_lawAffairs
            // 
            this.tab_lawAffairs.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab_lawAffairs.Groups.Add(this.group1);
            this.tab_lawAffairs.Label = "الشئون القانونية";
            this.tab_lawAffairs.Name = "tab_lawAffairs";
            // 
            // group1
            // 
            this.group1.Items.Add(this.mnuAddSubject);
            this.group1.Items.Add(this.separator4);
            this.group1.Items.Add(this.mnuInvestigation);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.mnuInspection);
            this.group1.Items.Add(this.separator8);
            this.group1.Items.Add(this.mnuCase);
            this.group1.Items.Add(this.separator2);
            this.group1.Items.Add(this.mnuMescLetters);
            this.group1.Items.Add(this.separator3);
            this.group1.Items.Add(this.mnuRush);
            this.group1.Items.Add(this.separator5);
            this.group1.Items.Add(this.btn_report);
            this.group1.Items.Add(this.separator7);
            this.group1.Items.Add(this.btn_settings);
            this.group1.Items.Add(this.separator6);
            this.group1.Items.Add(this.menu_help);
            this.group1.Label = "إدارة التحقيقات";
            this.group1.Name = "group1";
            // 
            // mnuAddSubject
            // 
            this.mnuAddSubject.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.mnuAddSubject.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.Document_Add_icon;
            this.mnuAddSubject.Items.Add(this.btnAddCeaseInvestigation);
            this.mnuAddSubject.Items.Add(this.btnAddInvestigation);
            this.mnuAddSubject.Items.Add(this.btnAddInspection);
            this.mnuAddSubject.Items.Add(this.btnCase);
            this.mnuAddSubject.Items.Add(this.btnLetter);
            this.mnuAddSubject.Label = "موضوع جديد";
            this.mnuAddSubject.Name = "mnuAddSubject";
            this.mnuAddSubject.ShowImage = true;
            // 
            // btnAddCeaseInvestigation
            // 
            this.btnAddCeaseInvestigation.Label = "تحقيق انقطاع";
            this.btnAddCeaseInvestigation.Name = "btnAddCeaseInvestigation";
            this.btnAddCeaseInvestigation.ShowImage = true;
            this.btnAddCeaseInvestigation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddCeaseInvestigation_Click);
            // 
            // btnAddInvestigation
            // 
            this.btnAddInvestigation.Label = "تحقيق";
            this.btnAddInvestigation.Name = "btnAddInvestigation";
            this.btnAddInvestigation.ShowImage = true;
            this.btnAddInvestigation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddInvestigation_Click);
            // 
            // btnAddInspection
            // 
            this.btnAddInspection.Label = "فحص";
            this.btnAddInspection.Name = "btnAddInspection";
            this.btnAddInspection.ShowImage = true;
            this.btnAddInspection.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddInspection_Click);
            // 
            // btnCase
            // 
            this.btnCase.Label = "قضية";
            this.btnCase.Name = "btnCase";
            this.btnCase.ShowImage = true;
            this.btnCase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCase_Click);
            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            // 
            // mnuInvestigation
            // 
            this.mnuInvestigation.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.mnuInvestigation.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.justice_balance_icon;
            this.mnuInvestigation.Items.Add(this.mnuNotification);
            this.mnuInvestigation.Items.Add(this.btnInvestInquiry);
            this.mnuInvestigation.Items.Add(this.mnuInvestigationNote);
            this.mnuInvestigation.Items.Add(this.btnInvestigationRefererringLetter);
            this.mnuInvestigation.Label = "تحقيق";
            this.mnuInvestigation.Name = "mnuInvestigation";
            this.mnuInvestigation.ShowImage = true;
            // 
            // mnuNotification
            // 
            this.mnuNotification.Items.Add(this.btnNormalNotification);
            this.mnuNotification.Items.Add(this.btnConfNotification);
            this.mnuNotification.Items.Add(this.btnSpecialNotification);
            this.mnuNotification.Label = "إخطار";
            this.mnuNotification.Name = "mnuNotification";
            this.mnuNotification.ShowImage = true;
            // 
            // btnNormalNotification
            // 
            this.btnNormalNotification.Label = "إخطار عادي";
            this.btnNormalNotification.Name = "btnNormalNotification";
            this.btnNormalNotification.ShowImage = true;
            this.btnNormalNotification.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnNormalNotification_Click);
            // 
            // btnConfNotification
            // 
            this.btnConfNotification.Label = "إخطار مشدد";
            this.btnConfNotification.Name = "btnConfNotification";
            this.btnConfNotification.ShowImage = true;
            this.btnConfNotification.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConfNotification_Click);
            // 
            // btnSpecialNotification
            // 
            this.btnSpecialNotification.Label = "إخطار خاص";
            this.btnSpecialNotification.Name = "btnSpecialNotification";
            this.btnSpecialNotification.ShowImage = true;
            this.btnSpecialNotification.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSpecialNotification_Click);
            // 
            // btnInvestInquiry
            // 
            this.btnInvestInquiry.Label = "إستيفاء";
            this.btnInvestInquiry.Name = "btnInvestInquiry";
            this.btnInvestInquiry.ShowImage = true;
            this.btnInvestInquiry.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInvestInquiry_Click);
            // 
            // mnuInvestigationNote
            // 
            this.mnuInvestigationNote.Items.Add(this.btnCeaseNote);
            this.mnuInvestigationNote.Items.Add(this.btnRegularNote);
            this.mnuInvestigationNote.Items.Add(this.btnTableNote);
            this.mnuInvestigationNote.Label = "مذكرة";
            this.mnuInvestigationNote.Name = "mnuInvestigationNote";
            this.mnuInvestigationNote.ShowImage = true;
            // 
            // btnCeaseNote
            // 
            this.btnCeaseNote.Label = "مذكرة انقطاع";
            this.btnCeaseNote.Name = "btnCeaseNote";
            this.btnCeaseNote.ShowImage = true;
            this.btnCeaseNote.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCeaseNote_Click);
            // 
            // btnRegularNote
            // 
            this.btnRegularNote.Label = "مذكرة عادية";
            this.btnRegularNote.Name = "btnRegularNote";
            this.btnRegularNote.ShowImage = true;
            this.btnRegularNote.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRegularNote_Click);
            // 
            // btnTableNote
            // 
            this.btnTableNote.Label = "مذكرة عرض على الوزيرة (جدول)";
            this.btnTableNote.Name = "btnTableNote";
            this.btnTableNote.ShowImage = true;
            this.btnTableNote.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTableNote_Click);
            // 
            // btnInvestigationRefererringLetter
            // 
            this.btnInvestigationRefererringLetter.Label = "إحالة التحقيق للنيابة الإدارية";
            this.btnInvestigationRefererringLetter.Name = "btnInvestigationRefererringLetter";
            this.btnInvestigationRefererringLetter.ShowImage = true;
            this.btnInvestigationRefererringLetter.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInvestigationReferringLetter_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // mnuInspection
            // 
            this.mnuInspection.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.mnuInspection.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.justice_balance_icon;
            this.mnuInspection.Items.Add(this.btnInspecInquiry);
            this.mnuInspection.Items.Add(this.btnInspectionNote);
            this.mnuInspection.Items.Add(this.btnInspctionRefererringLetter);
            this.mnuInspection.Label = "فحص";
            this.mnuInspection.Name = "mnuInspection";
            this.mnuInspection.ShowImage = true;
            // 
            // btnInspecInquiry
            // 
            this.btnInspecInquiry.Label = "إستيفاء";
            this.btnInspecInquiry.Name = "btnInspecInquiry";
            this.btnInspecInquiry.ShowImage = true;
            this.btnInspecInquiry.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInspecInquiry_Click);
            // 
            // btnInspectionNote
            // 
            this.btnInspectionNote.Label = "مذكرة";
            this.btnInspectionNote.Name = "btnInspectionNote";
            this.btnInspectionNote.ShowImage = true;
            this.btnInspectionNote.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInspectionNote_Click);
            // 
            // btnInspctionRefererringLetter
            // 
            this.btnInspctionRefererringLetter.Label = "إحالة الفحص للنيابة الإدارية";
            this.btnInspctionRefererringLetter.Name = "btnInspctionRefererringLetter";
            this.btnInspctionRefererringLetter.ShowImage = true;
            this.btnInspctionRefererringLetter.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInspectionReferringLetter_Click);
            // 
            // separator8
            // 
            this.separator8.Name = "separator8";
            // 
            // mnuCase
            // 
            this.mnuCase.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.mnuCase.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.justice_balance_icon;
            this.mnuCase.Items.Add(this.btnIssuanceRescript);
            this.mnuCase.Items.Add(this.btnRescriptSent);
            this.mnuCase.Label = "قضية";
            this.mnuCase.Name = "mnuCase";
            this.mnuCase.ShowImage = true;
            // 
            // btnIssuanceRescript
            // 
            this.btnIssuanceRescript.Label = "خطاب طلب إستصدار قرار نيابة";
            this.btnIssuanceRescript.Name = "btnIssuanceRescript";
            this.btnIssuanceRescript.ShowImage = true;
            this.btnIssuanceRescript.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnIssuanceRescript_Click);
            // 
            // btnRescriptSent
            // 
            this.btnRescriptSent.Label = "خطاب ارسال قرار للنيابة";
            this.btnRescriptSent.Name = "btnRescriptSent";
            this.btnRescriptSent.ShowImage = true;
            this.btnRescriptSent.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRescriptSent_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // mnuMescLetters
            // 
            this.mnuMescLetters.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.mnuMescLetters.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.DiffLetters;
            this.mnuMescLetters.Items.Add(this.btnGeneralLetter);
            this.mnuMescLetters.Items.Add(this.btnLetterReplay);
            this.mnuMescLetters.Items.Add(this.btnNominationLetters);
            this.mnuMescLetters.Items.Add(this.btnMission);
            this.mnuMescLetters.Label = "مكاتبات مختلفة";
            this.mnuMescLetters.Name = "mnuMescLetters";
            this.mnuMescLetters.ShowImage = true;
            // 
            // btnGeneralLetter
            // 
            this.btnGeneralLetter.Label = "خطاب عام";
            this.btnGeneralLetter.Name = "btnGeneralLetter";
            this.btnGeneralLetter.ShowImage = true;
            this.btnGeneralLetter.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnGeneralLetter_Click);
            // 
            // btnLetterReplay
            // 
            this.btnLetterReplay.Label = "خطاب للرد على مكاتبة";
            this.btnLetterReplay.Name = "btnLetterReplay";
            this.btnLetterReplay.ShowImage = true;
            // 
            // btnNominationLetters
            // 
            this.btnNominationLetters.Label = "خطاب ترشيح لجنة";
            this.btnNominationLetters.Name = "btnNominationLetters";
            this.btnNominationLetters.ShowImage = true;
            this.btnNominationLetters.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnNominationLetter_Click);
            // 
            // btnMission
            // 
            this.btnMission.Label = "بكليف بمأمورية";
            this.btnMission.Name = "btnMission";
            this.btnMission.ShowImage = true;
            this.btnMission.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMission_Click);
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            // 
            // mnuRush
            // 
            this.mnuRush.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.mnuRush.Dynamic = true;
            this.mnuRush.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.AlarmLetters;
            this.mnuRush.Label = "إستعجالات";
            this.mnuRush.Name = "mnuRush";
            this.mnuRush.ShowImage = true;
            // 
            // separator5
            // 
            this.separator5.Name = "separator5";
            // 
            // btn_report
            // 
            this.btn_report.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_report.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.data_management_icon;
            this.btn_report.Label = "بيان";
            this.btn_report.Name = "btn_report";
            this.btn_report.ShowImage = true;
            this.btn_report.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_report_Click);
            // 
            // separator7
            // 
            this.separator7.Name = "separator7";
            // 
            // btn_settings
            // 
            this.btn_settings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_settings.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.preferences_icon;
            this.btn_settings.Label = "الإعدادات";
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.ScreenTip = "إدارة التحقيقات";
            this.btn_settings.ShowImage = true;
            this.btn_settings.SuperTip = "التحكم في إعدادات البرنامج";
            this.btn_settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_settings_Click);
            // 
            // separator6
            // 
            this.separator6.Name = "separator6";
            // 
            // menu_help
            // 
            this.menu_help.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu_help.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.Help2;
            this.menu_help.Items.Add(this.btnHelp);
            this.menu_help.Items.Add(this.btnAbout);
            this.menu_help.Label = "المساعدة";
            this.menu_help.Name = "menu_help";
            this.menu_help.ShowImage = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Label = "التعليمات";
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.ShowImage = true;
            this.btnHelp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Label = "حول البرنامج";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShowImage = true;
            this.btnAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAbout_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.Label = "مكاتبة";
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.ShowImage = true;
            this.btnLetter.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLetter_Click);
            // 
            // MainInterface
            // 
            this.Name = "MainInterface";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab_lawAffairs);
            this.Close += new System.EventHandler(this.MainInterface_Close);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainInterface_Load);
            this.tab_lawAffairs.ResumeLayout(false);
            this.tab_lawAffairs.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab_lawAffairs;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuInvestigation;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuInspection;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuMescLetters;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator3;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_report;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator6;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu_help;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuNotification;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnNormalNotification;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConfNotification;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSpecialNotification;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuInvestigationNote;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCeaseNote;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRegularNote;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTableNote;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInvestInquiry;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInvestigationRefererringLetter;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInspectionNote;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInspecInquiry;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHelp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAbout;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnNominationLetters;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGeneralLetter;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMission;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInspctionRefererringLetter;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator4;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuAddSubject;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddCeaseInvestigation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddInvestigation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddInspection;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuRush;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCase;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator8;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mnuCase;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnIssuanceRescript;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRescriptSent;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLetterReplay;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLetter;
    }

    partial class ThisRibbonCollection
    {
        internal MainInterface MainInterface
        {
            get { return this.GetRibbon<MainInterface>(); }
        }
    }
}
