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

namespace MyTest513
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseAUT recording.
    /// </summary>
    [TestModule("be60d38d-93c7-4787-a04f-410ea26c204d", ModuleType.Recording, 1)]
    public partial class CloseAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest513Repository repository.
        /// </summary>
        public static MyTest513Repository repo = MyTest513Repository.Instance;

        static CloseAUT instance = new CloseAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseAUT()
        {
            CloseAutProcessIDVar = "-1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _CloseAutProcessIDVar;

        /// <summary>
        /// Gets or sets the value of variable CloseAutProcessIDVar.
        /// </summary>
        [TestVariable("23a267b6-1ea1-4624-820a-938bb0971e2e")]
        public string CloseAutProcessIDVar
        {
            get { return _CloseAutProcessIDVar; }
            set { _CloseAutProcessIDVar = value; }
        }

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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Closing application with Process ID bound to variable $CloseAutProcessIDVar.", new RecordItemIndex(0));
            Host.Current.CloseApplication(int.Parse(CloseAutProcessIDVar), 500);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
