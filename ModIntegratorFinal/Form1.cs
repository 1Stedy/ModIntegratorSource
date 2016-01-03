using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ModIntegratorFinal
{
    public partial class Form1 : Form
    {
        private Control[] _previousControls = new Control[4]; // 0 - Step0 .. 4 - Step4
        public Form1()
        {
            InitializeComponent();

            LoadText();

            var _ChoiseControl = new ChoiseControl();
            _ChoiseControl.OnChange += ClearAllControls;

            panel1.Controls.Add(_ChoiseControl);
            _previousControls[0] = panel1.Controls[0];

            Parameters.OnStepInc += NextControl;
            Parameters.OnStepDec += PreviousControl;

            BackButton.Visible = false;
            NextButton.Visible = false;

            TextChange();
        }
        private void ClearAllControls()
        {
            for (int i = 1; i < 4; i++)
                _previousControls[i] = null;
            NextButton.Visible = false;
            BackButton.Visible = false;

            Parameters.Path = String.Empty;
            Parameters.ContinentPath = String.Empty;
            Parameters.Localisation = String.Empty;
            Parameters.Version = String.Empty;
        }
        private void NextControl()
        {
            TextChange();
            panel1.SuspendLayout();
            panel1.Controls.Clear();
            switch (Parameters.Step)
            {
                case 1:
                    if (_previousControls[1] == null)
                        panel1.Controls.Add(new PathControl());
                    else panel1.Controls.Add(_previousControls[1]);
                    if (!BackButton.Visible)
                        BackButton.Visible = true;
                    break;
                case 2:
                    if (_previousControls[2] == null)
                        panel1.Controls.Add(new SettingsControl());
                    else panel1.Controls.Add(_previousControls[2]);
                    break;
                case 3:
                    if (_previousControls[3] == null)
                        panel1.Controls.Add(new FinalControl());
                    else panel1.Controls.Add(_previousControls[3]);
                    NextButton.Visible = false;
                    break;
                default: 
                    break; //Error
            }
            panel1.ResumeLayout(false);
            _previousControls[Parameters.Step] = panel1.Controls[0];
        }
        private void PreviousControl()
        {
            TextChange();
            panel1.SuspendLayout();
            panel1.Controls.Clear();
            if (_previousControls[Parameters.Step] != null)
                panel1.Controls.Add(_previousControls[Parameters.Step]);
            panel1.ResumeLayout(false);           
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Parameters.Step++;
            if ((Parameters.Step == 3 || _previousControls[Parameters.Step + 1] == null) && !(Parameters.Step == 1 && !Parameters.Integrate && _previousControls[3] != null))
                NextButton.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!NextButton.Visible)
                NextButton.Visible = true;
            Parameters.Step--;
            if (Parameters.Step == 0)
                BackButton.Visible = false;
        }
        private string[] message = new string[4];
        void LoadText()
        {
            message[0] = "Hello! Follow the instructions below.\n\nFirst choose the action.";
            message[1] = "Now choose the path to your mod root folder\nExample: C:\\Victoria2\\mod\\Mymod\n\nNOTE: If you don't have continent.txt in your mod original one (from HoD 3.03) will be used.";
            message[2] = "Choose mod's version and localisation\n\nAfter choosing you will be moved to the final step, but you can move back with navigation arrows to change your choice.";
            message[3] = "So, program is ready! Press start button to run process.\n\nNOTE: You can change your choise by going back with navigation arrows.";
        }
        void TextChange()
        {
            richTextBox1.Text = message[Parameters.Step];
        }

        //preventing actions with richtextbox
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionLength = 0;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
