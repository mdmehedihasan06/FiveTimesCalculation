namespace FiveTimesApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.fiveTimesResultTextBox = new System.Windows.Forms.TextBox();
            this.showFiveTimesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Five Times Result";
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(126, 28);
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(239, 20);
            this.aNumberTextBox.TabIndex = 2;
            // 
            // fiveTimesResultTextBox
            // 
            this.fiveTimesResultTextBox.Location = new System.Drawing.Point(126, 77);
            this.fiveTimesResultTextBox.Name = "fiveTimesResultTextBox";
            this.fiveTimesResultTextBox.Size = new System.Drawing.Size(239, 20);
            this.fiveTimesResultTextBox.TabIndex = 3;
            // 
            // showFiveTimesButton
            // 
            this.showFiveTimesButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.showFiveTimesButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.showFiveTimesButton.Location = new System.Drawing.Point(69, 136);
            this.showFiveTimesButton.Name = "showFiveTimesButton";
            this.showFiveTimesButton.Size = new System.Drawing.Size(272, 23);
            this.showFiveTimesButton.TabIndex = 4;
            this.showFiveTimesButton.Text = "Show Five Times";
            this.showFiveTimesButton.UseVisualStyleBackColor = false;
            this.showFiveTimesButton.Click += new System.EventHandler(this.showFiveTimesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.showFiveTimesButton);
            this.Controls.Add(this.fiveTimesResultTextBox);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.TextBox fiveTimesResultTextBox;
        private System.Windows.Forms.Button showFiveTimesButton;
    }
}

