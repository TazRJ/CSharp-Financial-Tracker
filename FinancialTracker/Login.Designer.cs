namespace FinancialTracker
{
    partial class Login
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
            label8 = new Label();
            label11 = new Label();
            PwdTb = new TextBox();
            label1 = new Label();
            UnameTb = new TextBox();
            LoginBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(115, 64);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(222, 38);
            label8.TabIndex = 50;
            label8.Text = "Financial Tracker";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(106, 402);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 32);
            label11.TabIndex = 51;
            label11.Text = "Password";
            // 
            // PwdTb
            // 
            PwdTb.Location = new Point(106, 448);
            PwdTb.Margin = new Padding(4, 5, 4, 5);
            PwdTb.Name = "PwdTb";
            PwdTb.Size = new Size(231, 31);
            PwdTb.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 270);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 53;
            label1.Text = "Username";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(106, 317);
            UnameTb.Margin = new Padding(4, 5, 4, 5);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(231, 31);
            UnameTb.TabIndex = 54;
            // 
            // LoginBtn
            // 
            LoginBtn.ForeColor = Color.Green;
            LoginBtn.Location = new Point(244, 677);
            LoginBtn.Margin = new Padding(4, 5, 4, 5);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(171, 88);
            LoginBtn.TabIndex = 55;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(365, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 56;
            label2.Text = "Close";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 698);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 38);
            label3.TabIndex = 57;
            label3.Text = "Register";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 800);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(label11);
            Controls.Add(PwdTb);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label11;
        private TextBox PwdTb;
        private Label label1;
        private TextBox UnameTb;
        private Button LoginBtn;
        private Label label2;
        private Label label3;
    }
}