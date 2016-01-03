namespace ModIntegratorFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox1.Location = new System.Drawing.Point(3, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(278, 85);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 144);
            this.panel1.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Control;
            this.BackButton.Image = global::ModIntegratorFinal.Properties.Resources.monotone_arrow_next_right2;
            this.BackButton.Location = new System.Drawing.Point(12, 224);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(33, 34);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 4;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::ModIntegratorFinal.Properties.Resources.monotone_arrow_next_right;
            this.NextButton.Location = new System.Drawing.Point(239, 224);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(33, 34);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextButton.TabIndex = 3;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Mod Integrator";
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.PictureBox BackButton;
    }
}

