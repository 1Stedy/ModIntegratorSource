namespace ModIntegratorFinal
{
    partial class ChoiseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiseControl));
            this.IntegrateButton = new System.Windows.Forms.Button();
            this.DisintegrateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntegrateButton
            // 
            resources.ApplyResources(this.IntegrateButton, "IntegrateButton");
            this.IntegrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IntegrateButton.Name = "IntegrateButton";
            this.IntegrateButton.UseVisualStyleBackColor = false;
            this.IntegrateButton.Click += new System.EventHandler(this.IntegrateButton_Click);
            // 
            // DisintegrateButton
            // 
            resources.ApplyResources(this.DisintegrateButton, "DisintegrateButton");
            this.DisintegrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DisintegrateButton.Name = "DisintegrateButton";
            this.DisintegrateButton.UseVisualStyleBackColor = false;
            this.DisintegrateButton.Click += new System.EventHandler(this.DisintegrateButton_Click);
            // 
            // ChoiseControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisintegrateButton);
            this.Controls.Add(this.IntegrateButton);
            this.Name = "ChoiseControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IntegrateButton;
        private System.Windows.Forms.Button DisintegrateButton;
    }
}
