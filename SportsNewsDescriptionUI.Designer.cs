namespace UpdateJinny
{
    partial class SportsNewsDescriptionUI
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
            this.richTextBoxDesp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxDesp
            // 
            this.richTextBoxDesp.Location = new System.Drawing.Point(7, 22);
            this.richTextBoxDesp.Name = "richTextBoxDesp";
            this.richTextBoxDesp.Size = new System.Drawing.Size(287, 132);
            this.richTextBoxDesp.TabIndex = 0;
            this.richTextBoxDesp.Text = "";
            // 
            // SportsNewsDescriptionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 162);
            this.Controls.Add(this.richTextBoxDesp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SportsNewsDescriptionUI";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxDesp;
    }
}