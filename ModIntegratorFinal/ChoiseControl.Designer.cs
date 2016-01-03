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
            this.IntegrateButton = new System.Windows.Forms.Button();
            this.DisintegrateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntegrateButton
            // 
            this.IntegrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IntegrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IntegrateButton.Location = new System.Drawing.Point(36, 43);
            this.IntegrateButton.Name = "IntegrateButton";
            this.IntegrateButton.Size = new System.Drawing.Size(99, 32);
            this.IntegrateButton.TabIndex = 0;
            this.IntegrateButton.Text = "Integrate";
            this.IntegrateButton.UseVisualStyleBackColor = false;
            this.IntegrateButton.Click += new System.EventHandler(this.IntegrateButton_Click);
            // 
            // DisintegrateButton
            // 
            this.DisintegrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DisintegrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisintegrateButton.Location = new System.Drawing.Point(136, 43);
            this.DisintegrateButton.Name = "DisintegrateButton";
            this.DisintegrateButton.Size = new System.Drawing.Size(99, 32);
            this.DisintegrateButton.TabIndex = 1;
            this.DisintegrateButton.Text = "Disintegrate";
            this.DisintegrateButton.UseVisualStyleBackColor = false;
            this.DisintegrateButton.Click += new System.EventHandler(this.DisintegrateButton_Click);
            // 
            // ChoiseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisintegrateButton);
            this.Controls.Add(this.IntegrateButton);
            this.Name = "ChoiseControl";
            this.Size = new System.Drawing.Size(278, 144);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IntegrateButton;
        private System.Windows.Forms.Button DisintegrateButton;
    }
}
