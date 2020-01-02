
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;
using Aveva.Pdms.Spec;

namespace Aveva.Pdms.Examples
{
    /// <summary>
    /// ExampleAddin
    /// </summary>
    public class ExamplesAddin : Aveva.ApplicationFramework.IAddin
    {
        private static ServiceManager sServiceManager;
        private static CommandManager sCommandManager;
        private static CommandBarManager sCommandBarManager;

        public ExamplesAddin()
        {
        }

        void Aveva.ApplicationFramework.IAddin.Start(ServiceManager serviceManager)
        {
            sServiceManager = serviceManager;
            sCommandManager = (CommandManager)sServiceManager.GetService(typeof(CommandManager));
            sCommandBarManager = (CommandBarManager)sServiceManager.GetService(typeof(CommandBarManager));

            //Add ExampleCommand to Command Manager
            sCommandManager.Commands.Add(new SpecCommand());

            //Create example toolbar menu
            CommandBar myToolBar = sCommandBarManager.CommandBars.AddCommandBar("SpecCommandBar");
            sCommandBarManager.RootTools.AddButtonTool("SpecCommand", "temp", null, "SpecCommand");
            myToolBar.Tools.AddTool("SpecCommand");
        }

        void Aveva.ApplicationFramework.IAddin.Stop()
        {

        }

        String Aveva.ApplicationFramework.IAddin.Name
        {
            get
            {
                return "ExamplesAddin";
            }
        }
        String Aveva.ApplicationFramework.IAddin.Description
        {
            get
            {
                return "ExamplesAddin";
            }
        }
    }
}
