using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModIntegratorFinal
{
    public partial class PathControl : UserControl
    {
        public PathControl()
        {
            InitializeComponent();
        }
        private void FolderDialog()
        {
            DialogResult dialogresult = folderBrowserDialog1.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                PathTextBox.Text = folderBrowserDialog1.SelectedPath;
                if (Parameters.Integrate)
                {
                    if (File.Exists(folderBrowserDialog1.SelectedPath + @"\map\continent.txt"))
                    {
                        Parameters.Path = folderBrowserDialog1.SelectedPath;
                        Parameters.ContinentPath = folderBrowserDialog1.SelectedPath + @"\map\continent.txt";
                    }

                    else
                    {
                        Parameters.Path = folderBrowserDialog1.SelectedPath;
                        Parameters.ContinentPath = String.Empty;
                    }
                }
                else
                {
                    Parameters.Path = folderBrowserDialog1.SelectedPath;
                }
                Parameters.Step++;
            }
            
        }
        private void PathButton_Click(object sender, EventArgs e)
        {
            FolderDialog();
        }
    }
}
