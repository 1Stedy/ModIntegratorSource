using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace ModIntegratorFinal
{
    public partial class FinalControl : UserControl
    {
        public FinalControl()
        {
            InitializeComponent();
            Results();
            Parameters.FinalStep += Results;
            Parameters.OnProgressMessageChange += ProgressMessageFunc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            richTextBox1.Text = "";
            var handler = new Handler();
            handler.MainHandler();
            button1.Enabled = true;
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
            if (CultureInfo.CurrentUICulture.Name == "ru" || CultureInfo.CurrentUICulture.Name == "ru-RU")
            {
                string continent = "из HoD 3.03";
                if (Parameters.ContinentPath != String.Empty)
                    continent = "пользовательские континенты (" + Parameters.ContinentPath + ")";
                if (Parameters.Integrate)
                    richTextBox1.Text = "Процесс ИНТЕГРАЦИИ" + "\nPПуть: " + Parameters.Path + "\nКонтиненты: " + continent + "\nВерсия: " + Parameters.Version + "\nЛокализация: " + Parameters.Localisation;
                else richTextBox1.Text = "Процесс ДЕЗИНТЕГРАЦИИ" + "\nПуть: " + Parameters.Path;
            }
            else
            {
                string continent = "from HoD 3.03";
                if (Parameters.ContinentPath != String.Empty)
                    continent = "user continents (" + Parameters.ContinentPath + ")";
                if (Parameters.Integrate)
                    richTextBox1.Text = "Process of INTEGRATION" + "\nPath: " + Parameters.Path + "\nContinents: " + continent + "\nVersion: " + Parameters.Version + "\nLocalisation: " + Parameters.Localisation;
                else richTextBox1.Text = "Process of DESINTEGRATION" + "\nPath: " + Parameters.Path;
            }
        }

        private async void ProgressMessageFunc()
        {
            //richTextBox1.Text += Parameters.ProgressMessage + "\n";
            SetText(Parameters.ProgressMessage + "\n");
        }
        delegate void SetTextCallback(string text);

        //взято с http://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
        //пипец как помогло
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.Text += text;
            }
        }
    }
}
