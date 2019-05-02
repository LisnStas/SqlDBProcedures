namespace WindowsFormsApp1
{
    partial class Form7
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
            if (disposing && (components != null)) {
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
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.showAllPresidents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(24, 20);
            this.listBoxDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(338, 290);
            this.listBoxDisplay.TabIndex = 0;
            // 
            // showAllPresidents
            // 
            this.showAllPresidents.Location = new System.Drawing.Point(24, 339);
            this.showAllPresidents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAllPresidents.Name = "showAllPresidents";
            this.showAllPresidents.Size = new System.Drawing.Size(338, 28);
            this.showAllPresidents.TabIndex = 1;
            this.showAllPresidents.Text = "Show All Presidents";
            this.showAllPresidents.UseVisualStyleBackColor = true;
            this.showAllPresidents.Click += new System.EventHandler(this.showAllPresidents_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 399);
            this.Controls.Add(this.showAllPresidents);
            this.Controls.Add(this.listBoxDisplay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button showAllPresidents;
    }
}