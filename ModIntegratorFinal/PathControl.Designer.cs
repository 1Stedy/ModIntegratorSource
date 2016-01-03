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
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(14, 15);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(261, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // PathButton
            // 
            this.PathButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PathButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PathButton.Location = new System.Drawing.Point(68, 63);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(138, 32);
            this.PathButton.TabIndex = 2;
            this.PathButton.Text = "Select path";
            this.PathButton.UseVisualStyleBackColor = false;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PathControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.PathTextBox);
            this.Name = "PathControl";
            this.Size = new System.Drawing.Size(278, 144);
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
