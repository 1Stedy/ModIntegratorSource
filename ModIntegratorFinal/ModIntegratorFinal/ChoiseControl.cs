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
    public partial class ChoiseControl : UserControl
    {
        public event ChoiseChange OnChange;
        public delegate void ChoiseChange();
        public ChoiseControl()
        {
            InitializeComponent();
        }

        public void SetMode(bool x)
        {
            OnChange();
            Parameters.Integrate = x;
            Parameters.Step++;
        }

        private void IntegrateButton_Click(object sender, EventArgs e)
        {
            SetMode(true);
        }

        private void DisintegrateButton_Click(object sender, EventArgs e)
        {
            SetMode(false);
        }
    }
}
