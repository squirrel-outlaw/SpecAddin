
using System;
using System.Collections;
using System.Windows.Forms;
using Aveva.ApplicationFramework.Presentation;

namespace Aveva.Pdms.Spec
{
    /// <summary>
    /// Example list command
    /// </summary>
    public class SpecCommand : Aveva.ApplicationFramework.Presentation.Command
    {
        public SpecForm specForm;

        
        public SpecCommand()
        {
            Key = "SpecCommand"; 
        }

        public override void Execute()
        {
            specForm.Show();
        }
    }
}
