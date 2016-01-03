using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModIntegratorFinal
{
    public partial class FinalControl : UserControl
    {
        public FinalControl()
        {
            InitializeComponent();
            Results();
            Parameters.FinalStep += Results;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var handler = new Handler();
            handler.MainProcess();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionLength = 0;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            button1.Focus();
        }
        private void Results()
        {
            string continent = "from HoD 3.03";
            if (Parameters.ContinentPath != String.Empty)
                continent = "user continent (" + Parameters.ContinentPath + ")";
            if (Parameters.Integrate)
                richTextBox1.Text = "Process of INTEGRATION" + "\nPath: " + Parameters.Path + "\nContinents: " + continent + "\nVersion: " + Parameters.Version + "\nLocalisation: " + Parameters.Localisation;
            else richTextBox1.Text = "Process of DESINTEGRATION" + "\nPath: " + Parameters.Path;
        }
    }
}
