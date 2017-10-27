/*
 * Created by Ranorex
 * User: aahsan
 * Date: 12/2/2015
 * Time: 10:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace RxMobileDemoInCode
{
    /// <summary>
    /// Description of RxMiniKeePassSample.
    /// </summary>
    [TestModule("855C52C1-3531-44EF-A999-619923CCB67D", ModuleType.UserCode, 1)]
    public class RxMiniKeePassSample : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RxMiniKeePassSample()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        /// 
        
        
        #region Variables
        string _varDeviceName = "rxiPadminiUS001";
        [TestVariable("14CC7175-FB92-4C89-BB3C-B469D5056F02")]
        public string varDeviceName
        {
        	get { return _varDeviceName; }
        	set { _varDeviceName = value; }
        }
		
        string _varGroupName = "Ranorex";
        [TestVariable("A3CAF950-9494-467D-9630-2DAE4302D237")]
        public string varGroupName
        {
        	get { return _varGroupName; }
        	set { _varGroupName = value; }
        }
        
        string _varTitle = "WordPressDemo";
        [TestVariable("323A834D-A14F-4150-9004-1796BF428596")]
        public string varTitle
        {
        	get { return _varTitle; }
        	set { _varTitle = value; }
        }
        
		string _varDatabaseName = "Keepass.kdb";
		[TestVariable("6FFCE507-2E02-407A-BE69-ABBF1EF81B41")]
		public string varDatabaseName
		{
			get { return _varDatabaseName; }
			set { _varDatabaseName = value; }
		}
 		        
        string _varIconIndex = "8";
        [TestVariable("906EFB27-0AA5-4A67-B172-40FDCB42CCD2")]
        public string varIconIndex
        {
        	get { return _varIconIndex; }
        	set { _varIconIndex = value; }
        }
                
        #endregion

        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
           	varDeviceName = "rxiPadminiUS001";
           	varDatabaseName = "RanorexMiniKeePass";
           	
           	var repo = RxMiniKeePassRepo.Instance;    
           	
			//Launch app
			
           	Report.Log(ReportLevel.Info, "Application", "Run mobile app 'ranorex.MiniKeePass' on device from variable $varDeviceName.", new RecordItemIndex(0));
            Host.Local.RunMobileApp(varDeviceName, "ranorex.MiniKeePass", true);
            Delay.Milliseconds(3500);         
            
       
            //Create Database
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RanorexMiniKeePass.AddNew' at Center", repo.RanorexMiniKeePass.AddNewInfo, new RecordItemIndex(0));
            repo.RanorexMiniKeePass.AddNew.Touch();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$varDatabaseName' on item 'RanorexMiniKeePass.Table.TextDatabaseName'.", repo.RanorexMiniKeePass.Table.TextDatabaseNameInfo, new RecordItemIndex(1));
            repo.RanorexMiniKeePass.Table.TextDatabaseName.Element.SetAttributeValue("Text", varDatabaseName);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '●●' on item 'RanorexMiniKeePass.Table.TextPassword'.", repo.RanorexMiniKeePass.Table.TextPasswordInfo, new RecordItemIndex(2));
            repo.RanorexMiniKeePass.Table.TextPassword.Element.SetAttributeValue("Text", "rx");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '●●' on item 'RanorexMiniKeePass.Table.TextConfirmPassword'.", repo.RanorexMiniKeePass.Table.TextConfirmPasswordInfo, new RecordItemIndex(3));
            repo.RanorexMiniKeePass.Table.TextConfirmPassword.Element.SetAttributeValue("Text", "rx");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{ENTER}' press on 'RanorexMiniKeePass.SomeForm'.", repo.RanorexMiniKeePass.SomeFormInfo, new RecordItemIndex(4));
            repo.RanorexMiniKeePass.SomeForm.PressKeys("{ENTER}");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'btDone_RootLevel' at Center", repo.btDone_RootLevelInfo, new RecordItemIndex(5));
                repo.btDone_RootLevel.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            //Log in
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RanorexMiniKeePass.RxKdb' at Center", repo.RanorexMiniKeePass.RxKdbInfo, new RecordItemIndex(0));
            repo.RanorexMiniKeePass.RxKdb.Touch();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '●●' on item 'RanorexMiniKeePass.ControllerWrapperTable.SomeText'.", repo.RanorexMiniKeePass.ControllerWrapperTable.SomeTextInfo, new RecordItemIndex(1));
            repo.RanorexMiniKeePass.ControllerWrapperTable.SomeText.Element.SetAttributeValue("Text", "rx");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(2));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{ENTER}' press on 'RanorexMiniKeePass.SomeForm'.", repo.RanorexMiniKeePass.SomeFormInfo, new RecordItemIndex(3));
            repo.RanorexMiniKeePass.SomeForm.PressKeys("{ENTER}");
            Delay.Milliseconds(200); 
            
            //Delete Database
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RanorexMiniKeePass.TitlebarButtons.Files' at Center", repo.RanorexMiniKeePass.TitlebarButtons.FilesInfo, new RecordItemIndex(0));
            repo.RanorexMiniKeePass.TitlebarButtons.Files.Touch();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RanorexMiniKeePass.TitlebarButtons.Edit' at Center", repo.RanorexMiniKeePass.TitlebarButtons.EditInfo, new RecordItemIndex(1));
            repo.RanorexMiniKeePass.TitlebarButtons.Edit.Touch();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RanorexMiniKeePass.Table.Delete' at Center", repo.RanorexMiniKeePass.Table.DeleteInfo, new RecordItemIndex(2));
            repo.RanorexMiniKeePass.Table.Delete.Touch();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'RanorexMiniKeePass.Table.Delete1' at Center", repo.RanorexMiniKeePass.Table.Delete1Info, new RecordItemIndex(3));
            repo.RanorexMiniKeePass.Table.Delete1.Touch();
            Delay.Milliseconds(200);
            
            //Close App
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'RanorexMiniKeePass'.", repo.RanorexMiniKeePass.SelfInfo, new RecordItemIndex(0));
            Host.Local.CloseApplication(repo.RanorexMiniKeePass.Self, new Duration(0));
            Delay.Milliseconds(0);         
            
                        
        }
		    
    }
}
