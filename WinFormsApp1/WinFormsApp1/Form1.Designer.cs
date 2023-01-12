namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsort = new System.Windows.Forms.Button();
            this.textboxOsoby = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(677, 35);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(75, 37);
            this.btnsort.TabIndex = 0;
            this.btnsort.Text = "Sortuj";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // textboxOsoby
            // 
            this.textboxOsoby.Location = new System.Drawing.Point(12, 12);
            this.textboxOsoby.Name = "textboxOsoby";
            this.textboxOsoby.Size = new System.Drawing.Size(604, 426);
            this.textboxOsoby.TabIndex = 1;
            this.textboxOsoby.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxOsoby);
            this.Controls.Add(this.btnsort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnsort;
        private RichTextBox textboxOsoby;
    }
}