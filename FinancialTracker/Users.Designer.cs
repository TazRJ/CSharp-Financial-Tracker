namespace FinancialTracker
{
    partial class Users
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
            label2 = new Label();
            RegisterBtn = new Button();
            label1 = new Label();
            UnameTb = new TextBox();
            label11 = new Label();
            PhoneTb = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddressTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            DOB = new DateTimePicker();
            PwdTb = new MaskedTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(365, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 57;
            label2.Text = "Close";
            label2.Click += label2_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.ForeColor = Color.Green;
            RegisterBtn.Location = new Point(140, 651);
            RegisterBtn.Margin = new Padding(4, 5, 4, 5);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(171, 88);
            RegisterBtn.TabIndex = 63;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 61;
            label1.Text = "Username";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(43, 170);
            UnameTb.Margin = new Padding(4, 5, 4, 5);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(365, 31);
            UnameTb.TabIndex = 62;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(43, 302);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 32);
            label11.TabIndex = 59;
            label11.Text = "Phone";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(43, 348);
            PhoneTb.Margin = new Padding(4, 5, 4, 5);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(365, 31);
            PhoneTb.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(110, 63);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(228, 38);
            label8.TabIndex = 58;
            label8.Text = "User Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 399);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 64;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 496);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 66;
            label4.Text = "Address";
            // 
            // AddressTb
            // 
            AddressTb.Location = new Point(43, 542);
            AddressTb.Margin = new Padding(4, 5, 4, 5);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(365, 93);
            AddressTb.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(193, 744);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 32);
            label5.TabIndex = 68;
            label5.Text = "Back";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(43, 206);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 32);
            label6.TabIndex = 69;
            label6.Text = "DOB";
            // 
            // DOB
            // 
            DOB.Location = new Point(43, 254);
            DOB.Margin = new Padding(4, 5, 4, 5);
            DOB.Name = "DOB";
            DOB.Size = new Size(365, 31);
            DOB.TabIndex = 70;
            // 
            // PwdTb
            // 
            PwdTb.Location = new Point(43, 448);
            PwdTb.Name = "PwdTb";
            PwdTb.Size = new Size(365, 31);
            PwdTb.TabIndex = 71;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 800);
            Controls.Add(PwdTb);
            Controls.Add(DOB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AddressTb);
            Controls.Add(label3);
            Controls.Add(RegisterBtn);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(label11);
            Controls.Add(PhoneTb);
            Controls.Add(label8);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button RegisterBtn;
        private Label label1;
        private TextBox UnameTb;
        private Label label11;
        private TextBox PhoneTb;
        private Label label8;
        private Label label3;
        private Label label4;
        private TextBox AddressTb;
        private Label label5;
        private Label label6;
        private DateTimePicker DOB;
        private MaskedTextBox PwdTb;
    }
}