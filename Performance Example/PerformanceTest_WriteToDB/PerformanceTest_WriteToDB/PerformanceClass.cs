/*
 * Created by Ranorex
 * User: jbranham
 * Date: 3/15/2016
 * Time: 11:07 AM
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

using System.Data.OleDb;//must have this using statement (yours will be different System.Data.Sql etc.)

namespace PerformanceTest_WriteToDB
{
    /// <summary>
    /// Description of PerformanceClass.
    /// </summary>
    [TestModule("2EEB38F4-816E-421B-A268-20A6A3570573", ModuleType.UserCode, 1)]
    public class PerformanceClass : ITestModule
    {
    	public System.DateTime startTime;
    	public System.DateTime stopTime;
    	public System.TimeSpan totalTime;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PerformanceClass()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
        
        public void startTimer(){
        	startTime = System.DateTime.Now;
        	
        	Report.Info("start time = " + startTime.ToString());
        }
        
        public void stopTimer(){
        	stopTime = System.DateTime.Now;
        	totalTime = stopTime.Subtract(startTime);
        	
        	Report.Info("stop time = " + stopTime.ToString());        	
        	Report.Info("total elapsed time = " + totalTime.ToString());
        	
        }
        
        public void writeResultsToDB(){
        	//Please make sure to check the "using" statements above to see the reference to System.Data.OleDb
        	
        	//===================================================================================================================
        	// THIS SECTION IS ONLY NECESSARY BECAUSE I WANTED TO USE A RELATIVE PATH FOR DB LOCATION BECAUSE THE DB IS INTERNAL TO MY PROJECT
        	// YOU WILL NOT NEED THIS STATEMENT AND CAN SIMPLY REFERENCE THE DB'S ABSOLUTE LOCATION IN THE CONNECTION STRING
        	
        	string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
        	string path = (System.IO.Path.GetDirectoryName(executable));
        	AppDomain.CurrentDomain.SetData("DataDirectory",path);        	
        	//====================================================================================================================
        	
        	Report.Info("Writing results to DB...");
        		
        	OleDbConnection con =
         		new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MyDB.accdb;"); //connection string *will be different for you*
        	
        	try{
	        	OleDbCommand cmd = new OleDbCommand("INSERT INTO PerformanceMetrics (ElapsedTimes) VALUES ('"+totalTime.ToString()+"')", con); //insert statement *will be different for you*        	
	        	con.Open(); //open connection to DB
	        	cmd.ExecuteNonQuery(); //execute cmd statement
	        	Report.Success("Database has been updated successfully");
        	}
        	catch(Exception ex){
        		Report.Failure(ex.Message);
        	}
        	
        	con.Close(); //close connection
        }
    }
}
