﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MyTest2 recording.
    /// </summary>
    [TestModule("afa38568-b7a3-40c7-bc08-65dc3f72aa98", ModuleType.Recording, 1)]
    public partial class MyTest2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static MyTest2 instance = new MyTest2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MyTest2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MyTest2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentBound.Col9NodeName' at 213;19.", repo.ApplicationUnderTest.ContentBound.Col9NodeNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ContentBound.Col9NodeName.Click("213;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentBound.LớpHọcCủaToi' at 133;21.", repo.ApplicationUnderTest.ContentBound.LớpHọcCủaToiInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ContentBound.LớpHọcCủaToi.Click("133;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềmGoogleChrome.QuayLại' at 23;15.", repo.HọcLiệuSachMềmGoogleChrome.QuayLạiInfo, new RecordItemIndex(2));
            repo.HọcLiệuSachMềmGoogleChrome.QuayLại.Click("23;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentBound.Lớp3' at 29;15.", repo.ApplicationUnderTest.ContentBound.Lớp3Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ContentBound.Lớp3.Click("29;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentBound.BaiTậpCuốiTuầnTiếngViệt3Tập1' at 220;27.", repo.ApplicationUnderTest.ContentBound.BaiTậpCuốiTuầnTiếngViệt3Tập1Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ContentBound.BaiTậpCuốiTuầnTiếngViệt3Tập1.Click("220;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềmGoogleChrome.QuayLại' at 26;19.", repo.HọcLiệuSachMềmGoogleChrome.QuayLạiInfo, new RecordItemIndex(5));
            repo.HọcLiệuSachMềmGoogleChrome.QuayLại.Click("26;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.ContentBound.BaiTậpCuốiTuầnTiếngAnh3Tập1' at 198;4.", repo.HọcLiệuSachMềm.ContentBound.BaiTậpCuốiTuầnTiếngAnh3Tập1Info, new RecordItemIndex(6));
            repo.HọcLiệuSachMềm.ContentBound.BaiTậpCuốiTuầnTiếngAnh3Tập1.Click("198;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.ContentBound.GiaoBaiTập' at 46;25.", repo.HọcLiệuSachMềm.ContentBound.GiaoBaiTậpInfo, new RecordItemIndex(7));
            repo.HọcLiệuSachMềm.ContentBound.GiaoBaiTập.Click("46;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Text' at 156;18.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.TextInfo, new RecordItemIndex(8));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text.Click("156;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'HọcLiệuSachMềm.CreateAssignmentModal1.Text' at 131;30.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.TextInfo, new RecordItemIndex(9));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text.MoveTo("131;30");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'HọcLiệuSachMềm.CreateAssignmentModal1.Text' at 139;22.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.TextInfo, new RecordItemIndex(10));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text.MoveTo("139;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'HọcLiệuSachMềm.CreateAssignmentModal1.CreateAssignmentModal' at 532;352.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.CreateAssignmentModalInfo, new RecordItemIndex(11));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.CreateAssignmentModal.MoveTo("532;352");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Grammar' with focus on 'HọcLiệuSachMềm.CreateAssignmentModal1.Text'.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.TextInfo, new RecordItemIndex(12));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text.PressKeys("Grammar");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HttpsHoclieuSachmemVnQuestionSet.Text1' at 255;4.", repo.ApplicationUnderTest.HttpsHoclieuSachmemVnQuestionSet.Text1Info, new RecordItemIndex(13));
            repo.ApplicationUnderTest.HttpsHoclieuSachmemVnQuestionSet.Text1.Click("255;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Kindergarten' at 91;11.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.KindergartenInfo, new RecordItemIndex(14));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Kindergarten.Click("91;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Text1' at 113;26.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text1Info, new RecordItemIndex(15));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text1.Click("113;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(16));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.NoItemsFound' at 116;25.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.NoItemsFoundInfo, new RecordItemIndex(17));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.NoItemsFound.Click("116;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.ModalBody' at 216;436.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.ModalBodyInfo, new RecordItemIndex(18));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.ModalBody.Click("216;436");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(19));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Number' at 211;22.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.NumberInfo, new RecordItemIndex(21));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number.Click("211;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10' with focus on 'HọcLiệuSachMềm.CreateAssignmentModal1.Number'.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.NumberInfo, new RecordItemIndex(22));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number.PressKeys("10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Number1' at 148;10.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1Info, new RecordItemIndex(23));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1.Click("148;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1000' with focus on 'HọcLiệuSachMềm.CreateAssignmentModal1.Number1'.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1Info, new RecordItemIndex(24));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1.PressKeys("1000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(25));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(26));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(28));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(29));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HttpsHoclieuSachmemVnQuestionSet.FormCheck' at 155;10.", repo.ApplicationUnderTest.HttpsHoclieuSachmemVnQuestionSet.FormCheckInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.HttpsHoclieuSachmemVnQuestionSet.FormCheck.Click("155;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.LabelTagTrộnCauHỏi' at 53;14.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.LabelTagTrộnCauHỏiInfo, new RecordItemIndex(31));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.LabelTagTrộnCauHỏi.Click("53;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(32));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Submit' at 41;6.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.SubmitInfo, new RecordItemIndex(33));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Submit.Click("41;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu down}{Tab down}{LMenu up}'.", new RecordItemIndex(34));
            Keyboard.Press("{LMenu down}{Tab down}{LMenu up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềmGoogleChrome.BaiTậpThựcHanhKiểmThửMonINT31172' at 34;23.", repo.HọcLiệuSachMềmGoogleChrome.BaiTậpThựcHanhKiểmThửMonINT31172Info, new RecordItemIndex(35));
            repo.HọcLiệuSachMềmGoogleChrome.BaiTậpThựcHanhKiểmThửMonINT31172.Click("34;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềmGoogleChrome.Pane1' at 1623;10.", repo.HọcLiệuSachMềmGoogleChrome.Pane1Info, new RecordItemIndex(36));
            repo.HọcLiệuSachMềmGoogleChrome.Pane1.Click("1623;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.BtnGroupDropDoItem' at 23;33.", repo.HọcLiệuSachMềm.BtnGroupDropDoItemInfo, new RecordItemIndex(37));
            repo.HọcLiệuSachMềm.BtnGroupDropDoItem.Click("23;33");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentBound.PHONICS' at 663;20.", repo.ApplicationUnderTest.ContentBound.PHONICSInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.ContentBound.PHONICS.Click("663;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.GiaoBaiTập' at 57;6.", repo.ApplicationUnderTest.GiaoBaiTậpInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.GiaoBaiTập.Click("57;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(40));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(41));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(42));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HọcLiệuSachMềm.CreateAssignmentModal1.Text' at 146;26.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.TextInfo, new RecordItemIndex(43));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text.DoubleClick("146;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'grammar' with focus on 'HọcLiệuSachMềm.CreateAssignmentModal1.Text'.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.TextInfo, new RecordItemIndex(44));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Text.PressKeys("grammar");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.NgValueContainer' at 25;3.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.NgValueContainerInfo, new RecordItemIndex(45));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.NgValueContainer.Click("25;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.NgOptionNgOptionMarkedNgStarInser' at 61;9.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.NgOptionNgOptionMarkedNgStarInserInfo, new RecordItemIndex(46));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.NgOptionNgOptionMarkedNgStarInser.Click("61;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(47));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Number' at 228;41.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.NumberInfo, new RecordItemIndex(48));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number.Click("228;41");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad0}{NumPad0}{NumPad0}' with focus on 'HọcLiệuSachMềm.CreateAssignmentModal1.Number'.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.NumberInfo, new RecordItemIndex(49));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number.PressKeys("{NumPad1}{NumPad0}{NumPad0}{NumPad0}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(50));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Number1' at 254;31.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1Info, new RecordItemIndex(51));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1.Click("254;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}' with focus on 'HọcLiệuSachMềm.CreateAssignmentModal1.Number1'.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1Info, new RecordItemIndex(52));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Number1.PressKeys("{NumPad1}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HọcLiệuSachMềm.CreateAssignmentModal1.LabelTagTrộnCauHỏi' at 81;1.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.LabelTagTrộnCauHỏiInfo, new RecordItemIndex(53));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.LabelTagTrộnCauHỏi.DoubleClick("81;1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(54));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.CreateAssignmentModal1.Submit' at 23;23.", repo.HọcLiệuSachMềm.CreateAssignmentModal1.SubmitInfo, new RecordItemIndex(55));
            repo.HọcLiệuSachMềm.CreateAssignmentModal1.Submit.Click("23;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HọcLiệuSachMềm.ContentBound.FaFaLgFaHome' at 21;14.", repo.HọcLiệuSachMềm.ContentBound.FaFaLgFaHomeInfo, new RecordItemIndex(56));
            repo.HọcLiệuSachMềm.ContentBound.FaFaLgFaHome.Click("21;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentBound.LớpHọcCủaToi' at 136;10.", repo.ApplicationUnderTest.ContentBound.LớpHọcCủaToiInfo, new RecordItemIndex(57));
            repo.ApplicationUnderTest.ContentBound.LớpHọcCủaToi.Click("136;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentBound.Kindergarten' at 81;17.", repo.ApplicationUnderTest.ContentBound.KindergartenInfo, new RecordItemIndex(58));
            repo.ApplicationUnderTest.ContentBound.Kindergarten.Click("81;17");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
