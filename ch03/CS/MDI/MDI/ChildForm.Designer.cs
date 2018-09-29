namespace MDI
{
    partial class ChildForm
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
            this.DocumentTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DocumentTextBox
            // 
            this.DocumentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentTextBox.Location = new System.Drawing.Point(0, 0);
            this.DocumentTextBox.Name = "DocumentTextBox";
            this.DocumentTextBox.Size = new System.Drawing.Size(800, 450);
            this.DocumentTextBox.TabIndex = 0;
            this.DocumentTextBox.Text = "";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DocumentTextBox);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox DocumentTextBox;
    }
}