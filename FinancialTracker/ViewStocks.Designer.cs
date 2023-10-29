namespace FinancialTracker
{
    partial class ViewStocks
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
            panel1 = new Panel();
            label3 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            CloseBtn = new Label();
            symbolComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            timeColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            fetchDataButton = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label37);
            panel1.Controls.Add(label38);
            panel1.Controls.Add(label39);
            panel1.Controls.Add(label40);
            panel1.Controls.Add(label41);
            panel1.Controls.Add(label42);
            panel1.Controls.Add(label43);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 1078);
            panel1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(54, 731);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 38);
            label3.TabIndex = 9;
            label3.Text = "View Stocks";
            label3.Click += label3_Click;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label37.Location = new Point(54, 978);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new Size(103, 38);
            label37.TabIndex = 7;
            label37.Text = "Logout";
            label37.Click += label37_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(54, 655);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new Size(197, 38);
            label38.TabIndex = 6;
            label38.Text = "View Expenses";
            label38.Click += label38_Click;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(54, 565);
            label39.Margin = new Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new Size(175, 38);
            label39.TabIndex = 5;
            label39.Text = "View Income";
            label39.Click += label39_Click;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label40.Location = new Point(54, 478);
            label40.Margin = new Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new Size(130, 38);
            label40.TabIndex = 4;
            label40.Text = "Expenses";
            label40.Click += label40_Click;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label41.ForeColor = SystemColors.ActiveCaptionText;
            label41.Location = new Point(54, 380);
            label41.Margin = new Padding(4, 0, 4, 0);
            label41.Name = "label41";
            label41.Size = new Size(108, 38);
            label41.TabIndex = 3;
            label41.Text = "Income";
            label41.Click += label41_Click;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label42.Location = new Point(54, 272);
            label42.Margin = new Padding(4, 0, 4, 0);
            label42.Name = "label42";
            label42.Size = new Size(151, 38);
            label42.TabIndex = 2;
            label42.Text = "Dashboard";
            label42.Click += label42_Click;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label43.Location = new Point(54, 33);
            label43.Margin = new Padding(4, 0, 4, 0);
            label43.Name = "label43";
            label43.Size = new Size(185, 38);
            label43.TabIndex = 1;
            label43.Text = "Project Name";
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CloseBtn.Location = new Point(2024, 9);
            CloseBtn.Margin = new Padding(4, 0, 4, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(84, 38);
            CloseBtn.TabIndex = 15;
            CloseBtn.Text = "Close";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // symbolComboBox
            // 
            symbolComboBox.FormattingEnabled = true;
            symbolComboBox.Items.AddRange(new object[] { "AAPL", "GOOGL", "TSLA", "MSFT" });
            symbolComboBox.Location = new Point(307, 120);
            symbolComboBox.Name = "symbolComboBox";
            symbolComboBox.Size = new Size(264, 33);
            symbolComboBox.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { timeColumn, priceColumn });
            dataGridView1.Location = new Point(493, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1285, 485);
            dataGridView1.TabIndex = 29;
            // 
            // timeColumn
            // 
            timeColumn.HeaderText = "Time";
            timeColumn.MinimumWidth = 8;
            timeColumn.Name = "timeColumn";
            // 
            // priceColumn
            // 
            priceColumn.HeaderText = "Price";
            priceColumn.MinimumWidth = 8;
            priceColumn.Name = "priceColumn";
            // 
            // fetchDataButton
            // 
            fetchDataButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            fetchDataButton.Location = new Point(307, 175);
            fetchDataButton.Name = "fetchDataButton";
            fetchDataButton.Size = new Size(264, 34);
            fetchDataButton.TabIndex = 30;
            fetchDataButton.Text = "Fetch Data";
            fetchDataButton.UseVisualStyleBackColor = true;
            fetchDataButton.Click += fetchDataButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(891, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 45);
            textBox1.TabIndex = 31;
            textBox1.Text = "Top Stocks";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // ViewStocks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2121, 1078);
            Controls.Add(textBox1);
            Controls.Add(fetchDataButton);
            Controls.Add(dataGridView1);
            Controls.Add(symbolComboBox);
            Controls.Add(CloseBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStocks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStocks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label3;
        private Label CloseBtn;
        private ComboBox symbolComboBox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn timeColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private Button fetchDataButton;
        private TextBox textBox1;
    }
}