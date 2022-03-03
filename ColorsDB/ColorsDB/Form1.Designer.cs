namespace ColorsDB
{
    partial class Form1
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
            this.Colors = new System.Windows.Forms.Label();
            this.listColors = new System.Windows.Forms.ListBox();
            this.ListColorNames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Colors
            // 
            this.Colors.AutoSize = true;
            this.Colors.Location = new System.Drawing.Point(197, 101);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(36, 13);
            this.Colors.TabIndex = 0;
            this.Colors.Text = "Colors";
            // 
            // listColors
            // 
            this.listColors.FormattingEnabled = true;
            this.listColors.Location = new System.Drawing.Point(200, 196);
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(120, 95);
            this.listColors.TabIndex = 1;
            this.listColors.SelectedIndexChanged += new System.EventHandler(this.listColors_SelectedIndexChanged);
            // 
            // ListColorNames
            // 
            this.ListColorNames.FormattingEnabled = true;
            this.ListColorNames.Location = new System.Drawing.Point(575, 196);
            this.ListColorNames.Name = "ListColorNames";
            this.ListColorNames.Size = new System.Drawing.Size(120, 95);
            this.ListColorNames.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListColorNames);
            this.Controls.Add(this.listColors);
            this.Controls.Add(this.Colors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Colors;
        private System.Windows.Forms.ListBox listColors;
        private System.Windows.Forms.ListBox ListColorNames;
        private System.Windows.Forms.Label label2;
    }
}

