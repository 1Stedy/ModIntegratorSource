namespace ModIntegratorFinal
{
    partial class PathControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathControl));
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            resources.ApplyResources(this.PathTextBox, "PathTextBox");
            this.PathTextBox.Name = "PathTextBox";
            // 
            // PathButton
            // 
            resources.ApplyResources(this.PathButton, "PathButton");
            this.PathButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PathButton.Name = "PathButton";
            this.PathButton.UseVisualStyleBackColor = false;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // PathControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.PathTextBox);
            this.Name = "PathControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
