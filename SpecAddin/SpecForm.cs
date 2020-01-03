using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aveva.Pdms.Spec
{
    public partial class SpecForm : Form
    {
        public SpecForm()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBService dBService = new DBService();
            List<String> stringList = dBService.Query();
            foreach (String str in stringList) {
                textBox1.AppendText(str + "\n");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        public void readLog(string log)
        {

            textBox1.AppendText( log + "\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpecForm_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
