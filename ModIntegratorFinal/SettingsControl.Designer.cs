namespace ModIntegratorFinal
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FullVer = new System.Windows.Forms.RadioButton();
            this.LiteVer = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RussianLoc = new System.Windows.Forms.RadioButton();
            this.EnglishLoc = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FullVer);
            this.groupBox1.Controls.Add(this.LiteVer);
            this.groupBox1.Location = new System.Drawing.Point(19, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version";
            // 
            // FullVer
            // 
            this.FullVer.AutoSize = true;
            this.FullVer.Location = new System.Drawing.Point(6, 56);
            this.FullVer.Name = "FullVer";
            this.FullVer.Size = new System.Drawing.Size(41, 17);
            this.FullVer.TabIndex = 1;
            this.FullVer.TabStop = true;
            this.FullVer.Text = "Full";
            this.FullVer.UseVisualStyleBackColor = true;
            this.FullVer.CheckedChanged += new System.EventHandler(this.FullVer_CheckedChanged);
            // 
            // LiteVer
            // 
            this.LiteVer.AutoSize = true;
            this.LiteVer.Location = new System.Drawing.Point(6, 33);
            this.LiteVer.Name = "LiteVer";
            this.LiteVer.Size = new System.Drawing.Size(42, 17);
            this.LiteVer.TabIndex = 0;
            this.LiteVer.TabStop = true;
            this.LiteVer.Text = "Lite";
            this.LiteVer.UseVisualStyleBackColor = true;
            this.LiteVer.CheckedChanged += new System.EventHandler(this.LiteVer_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RussianLoc);
            this.groupBox2.Controls.Add(this.EnglishLoc);
            this.groupBox2.Location = new System.Drawing.Point(141, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localisation";
            // 
            // RussianLoc
            // 
            this.RussianLoc.AutoSize = true;
            this.RussianLoc.Location = new System.Drawing.Point(6, 56);
            this.RussianLoc.Name = "RussianLoc";
            this.RussianLoc.Size = new System.Drawing.Size(63, 17);
            this.RussianLoc.TabIndex = 1;
            this.RussianLoc.TabStop = true;
            this.RussianLoc.Text = "Russian";
            this.RussianLoc.UseVisualStyleBackColor = true;
            this.RussianLoc.CheckedChanged += new System.EventHandler(this.RussianLoc_CheckedChanged);
            // 
            // EnglishLoc
            // 
            this.EnglishLoc.AutoSize = true;
            this.EnglishLoc.Location = new System.Drawing.Point(6, 33);
            this.EnglishLoc.Name = "EnglishLoc";
            this.EnglishLoc.Size = new System.Drawing.Size(59, 17);
            this.EnglishLoc.TabIndex = 0;
            this.EnglishLoc.TabStop = true;
            this.EnglishLoc.Text = "English";
            this.EnglishLoc.UseVisualStyleBackColor = true;
            this.EnglishLoc.CheckedChanged += new System.EventHandler(this.EnglishLoc_CheckedChanged);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(278, 144);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FullVer;
        private System.Windows.Forms.RadioButton LiteVer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RussianLoc;
        private System.Windows.Forms.RadioButton EnglishLoc;
    }
}
