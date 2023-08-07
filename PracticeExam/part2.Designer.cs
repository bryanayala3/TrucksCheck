namespace PracticeExam
{
    partial class part2
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
            this.validateIpBttn = new System.Windows.Forms.Button();
            this.ipv4Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regexResult = new System.Windows.Forms.Label();
            this.passwordBttn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validateIpBttn
            // 
            this.validateIpBttn.BackColor = System.Drawing.Color.RosyBrown;
            this.validateIpBttn.Location = new System.Drawing.Point(66, 132);
            this.validateIpBttn.Name = "validateIpBttn";
            this.validateIpBttn.Size = new System.Drawing.Size(75, 23);
            this.validateIpBttn.TabIndex = 0;
            this.validateIpBttn.Text = "Validate";
            this.validateIpBttn.UseVisualStyleBackColor = false;
            this.validateIpBttn.Click += new System.EventHandler(this.validateIpBttn_Click);
            // 
            // ipv4Box
            // 
            this.ipv4Box.Location = new System.Drawing.Point(56, 93);
            this.ipv4Box.Name = "ipv4Box";
            this.ipv4Box.Size = new System.Drawing.Size(100, 23);
            this.ipv4Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP v4 number";
            // 
            // regexResult
            // 
            this.regexResult.AutoSize = true;
            this.regexResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regexResult.ForeColor = System.Drawing.Color.IndianRed;
            this.regexResult.Location = new System.Drawing.Point(52, 268);
            this.regexResult.Name = "regexResult";
            this.regexResult.Size = new System.Drawing.Size(0, 15);
            this.regexResult.TabIndex = 3;
            // 
            // passwordBttn
            // 
            this.passwordBttn.BackColor = System.Drawing.Color.DarkSalmon;
            this.passwordBttn.Location = new System.Drawing.Point(450, 132);
            this.passwordBttn.Name = "passwordBttn";
            this.passwordBttn.Size = new System.Drawing.Size(75, 23);
            this.passwordBttn.TabIndex = 4;
            this.passwordBttn.Text = "Validate";
            this.passwordBttn.UseVisualStyleBackColor = false;
            this.passwordBttn.Click += new System.EventHandler(this.passwordBttn_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(426, 93);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(117, 23);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your password:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.messageLabel.Location = new System.Drawing.Point(464, 231);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 15);
            this.messageLabel.TabIndex = 7;
            // 
            // part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordBttn);
            this.Controls.Add(this.regexResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipv4Box);
            this.Controls.Add(this.validateIpBttn);
            this.Name = "part2";
            this.Text = "part2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button validateIpBttn;
        private TextBox ipv4Box;
        private Label label1;
        private Label regexResult;
        private Button passwordBttn;
        private MaskedTextBox passwordBox;
        private Label label2;
        private Label messageLabel;
    }
}