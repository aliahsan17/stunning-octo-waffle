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

namespace DBConnectorExample
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GetDataFromDBB recording.
    /// </summary>
    [TestModule("4c5516ee-16f6-44e6-8adf-796162040fc5", ModuleType.Recording, 1)]
    public partial class GetDataFromDBB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DBConnectorExampleRepository repository.
        /// </summary>
        public static DBConnectorExampleRepository repo = DBConnectorExampleRepository.Instance;

        static GetDataFromDBB instance = new GetDataFromDBB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GetDataFromDBB()
        {
            varDBBR = "2";
            varDBAR = "1";
            varGBL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GetDataFromDBB Instance
        {
            get { return instance; }
        }

#region Variables

        string _varDBBR;

        /// <summary>
        /// Gets or sets the value of variable varDBBR.
        /// </summary>
        [TestVariable("b8e1a2c3-b113-472e-a911-f990f19a1a19")]
        public string varDBBR
        {
            get { return _varDBBR; }
            set { _varDBBR = value; }
        }

        string _varDBAR;

        /// <summary>
        /// Gets or sets the value of variable varDBAR.
        /// </summary>
        [TestVariable("63608d13-ef8c-47f0-aed8-a1b2c0566177")]
        public string varDBAR
        {
            get { return _varDBAR; }
            set { _varDBAR = value; }
        }

        string _varGBL;

        /// <summary>
        /// Gets or sets the value of variable varGBL.
        /// </summary>
        [TestVariable("0ca3fbec-0f6e-4d01-b382-35d849fc54fc")]
        public string varGBL
        {
            get { return _varGBL; }
            set { _varGBL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            compDataB2NDb();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
