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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.FullVer);
            this.groupBox1.Controls.Add(this.LiteVer);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // FullVer
            // 
            resources.ApplyResources(this.FullVer, "FullVer");
            this.FullVer.Name = "FullVer";
            this.FullVer.TabStop = true;
            this.FullVer.UseVisualStyleBackColor = true;
            this.FullVer.CheckedChanged += new System.EventHandler(this.FullVer_CheckedChanged);
            // 
            // LiteVer
            // 
            resources.ApplyResources(this.LiteVer, "LiteVer");
            this.LiteVer.Name = "LiteVer";
            this.LiteVer.TabStop = true;
            this.LiteVer.UseVisualStyleBackColor = true;
            this.LiteVer.CheckedChanged += new System.EventHandler(this.LiteVer_CheckedChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.RussianLoc);
            this.groupBox2.Controls.Add(this.EnglishLoc);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // RussianLoc
            // 
            resources.ApplyResources(this.RussianLoc, "RussianLoc");
            this.RussianLoc.Name = "RussianLoc";
            this.RussianLoc.TabStop = true;
            this.RussianLoc.UseVisualStyleBackColor = true;
            this.RussianLoc.CheckedChanged += new System.EventHandler(this.RussianLoc_CheckedChanged);
            // 
            // EnglishLoc
            // 
            resources.ApplyResources(this.EnglishLoc, "EnglishLoc");
            this.EnglishLoc.Name = "EnglishLoc";
            this.EnglishLoc.TabStop = true;
            this.EnglishLoc.UseVisualStyleBackColor = true;
            this.EnglishLoc.CheckedChanged += new System.EventHandler(this.EnglishLoc_CheckedChanged);
            // 
            // SettingsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsControl";
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
