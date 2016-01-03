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
    public partial class SettingsControl : UserControl
    {
        bool FirstTimeChoose = true;
        public SettingsControl()
        {
            InitializeComponent();
        }
        private void IsAllChecked()
        {
            if (FirstTimeChoose)
                if ((EnglishLoc.Checked || RussianLoc.Checked) && (LiteVer.Checked || FullVer.Checked))
                {
                    FirstTimeChoose = false;
                    Parameters.Step++;
                }   
        }
        private void EnglishLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (EnglishLoc.Checked)
                Parameters.Localisation = "English";
            else
                Parameters.Localisation = "Russian";
            IsAllChecked();
        }

        private void RussianLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (RussianLoc.Checked)
                Parameters.Localisation = "Russian";
            else
                Parameters.Localisation = "English";
            IsAllChecked();
        }

        private void LiteVer_CheckedChanged(object sender, EventArgs e)
        {
            if (LiteVer.Checked)
                Parameters.Version = "Lite";
            else
                Parameters.Version = "Full";
            IsAllChecked();
        }

        private void FullVer_CheckedChanged(object sender, EventArgs e)
        {
            if (FullVer.Checked)
                Parameters.Version = "Full";
            else
                Parameters.Version = "Lite";
            IsAllChecked();
        }
    }
}
