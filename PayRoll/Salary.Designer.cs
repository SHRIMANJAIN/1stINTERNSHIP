namespace PayRoll
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label17 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            panel4 = new Panel();
            AttNumCb = new ComboBox();
            label5 = new Label();
            ExcusedTb = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            AbsTb = new TextBox();
            label16 = new Label();
            label14 = new Label();
            label9 = new Label();
            BonusTb = new TextBox();
            BonusIdCb = new ComboBox();
            SalDate = new DateTimePicker();
            BaseSalaryTb = new TextBox();
            BalanceTb = new TextBox();
            label15 = new Label();
            AdvanceTb = new TextBox();
            EmpIdCb = new ComboBox();
            SalaryDGV = new DataGridView();
            PresTb = new TextBox();
            label10 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            EmpNameTb = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(912, 380);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(122, 29);
            button3.TabIndex = 25;
            button3.Text = "COMPUTE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(653, 380);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 23;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(AttNumCb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ExcusedTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AbsTb);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(BonusTb);
            panel1.Controls.Add(BonusIdCb);
            panel1.Controls.Add(SalDate);
            panel1.Controls.Add(BaseSalaryTb);
            panel1.Controls.Add(BalanceTb);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(AdvanceTb);
            panel1.Controls.Add(EmpIdCb);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SalaryDGV);
            panel1.Controls.Add(PresTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpNameTb);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1667, 774);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(label17);
            panel2.Location = new Point(888, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 110);
            panel2.TabIndex = 61;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Firebrick;
            label17.Font = new Font("Berlin Sans FB Demi", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(45, 32);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(628, 50);
            label17.TabIndex = 2;
            label17.Text = "Employee Management System ";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(739, 14);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(68, 57);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 55;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(412, 14);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(68, 57);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 58;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(579, 14);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(68, 57);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 60;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(82, 14);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(68, 57);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 56;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(244, 14);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(68, 57);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 59;
            pictureBox10.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Firebrick;
            panel4.ForeColor = Color.Firebrick;
            panel4.Location = new Point(696, 98);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(164, 4);
            panel4.TabIndex = 57;
            // 
            // AttNumCb
            // 
            AttNumCb.FormattingEnabled = true;
            AttNumCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            AttNumCb.Location = new Point(1130, 237);
            AttNumCb.Margin = new Padding(2);
            AttNumCb.Name = "AttNumCb";
            AttNumCb.Size = new Size(205, 23);
            AttNumCb.TabIndex = 41;
            AttNumCb.SelectionChangeCommitted += AttNumCb_SelectionChangeCommitted_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(696, 72);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 4;
            label5.Text = "ISSUE SALARY";
            // 
            // ExcusedTb
            // 
            ExcusedTb.BorderStyle = BorderStyle.FixedSingle;
            ExcusedTb.Enabled = false;
            ExcusedTb.Location = new Point(1393, 303);
            ExcusedTb.Margin = new Padding(2);
            ExcusedTb.Name = "ExcusedTb";
            ExcusedTb.Size = new Size(205, 23);
            ExcusedTb.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(570, 72);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "BONUS";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(74, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(374, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 2;
            label3.Text = "ATTEDENCE";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(212, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 1;
            label2.Text = "EMPLOYEE";
            label2.Click += label2_Click;
            // 
            // AbsTb
            // 
            AbsTb.BorderStyle = BorderStyle.FixedSingle;
            AbsTb.Enabled = false;
            AbsTb.Location = new Point(1393, 237);
            AbsTb.Margin = new Padding(2);
            AbsTb.Name = "AbsTb";
            AbsTb.Size = new Size(205, 23);
            AbsTb.TabIndex = 39;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(1393, 277);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(90, 25);
            label16.TabIndex = 38;
            label16.Text = "Excused";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1393, 211);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(80, 25);
            label14.TabIndex = 37;
            label14.Text = "Absent";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1130, 211);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 36;
            label9.Text = "Attendence";
            // 
            // BonusTb
            // 
            BonusTb.BorderStyle = BorderStyle.FixedSingle;
            BonusTb.Enabled = false;
            BonusTb.Location = new Point(866, 303);
            BonusTb.Margin = new Padding(2);
            BonusTb.Name = "BonusTb";
            BonusTb.Size = new Size(205, 23);
            BonusTb.TabIndex = 34;
            // 
            // BonusIdCb
            // 
            BonusIdCb.FormattingEnabled = true;
            BonusIdCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            BonusIdCb.Location = new Point(866, 236);
            BonusIdCb.Margin = new Padding(2);
            BonusIdCb.Name = "BonusIdCb";
            BonusIdCb.Size = new Size(205, 23);
            BonusIdCb.TabIndex = 33;
            BonusIdCb.SelectionChangeCommitted += BonusIdCb_SelectionChangeCommitted;
            // 
            // SalDate
            // 
            SalDate.Location = new Point(604, 301);
            SalDate.Margin = new Padding(2);
            SalDate.Name = "SalDate";
            SalDate.Size = new Size(205, 23);
            SalDate.TabIndex = 32;
            SalDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // BaseSalaryTb
            // 
            BaseSalaryTb.BorderStyle = BorderStyle.FixedSingle;
            BaseSalaryTb.Enabled = false;
            BaseSalaryTb.Location = new Point(604, 237);
            BaseSalaryTb.Margin = new Padding(2);
            BaseSalaryTb.Name = "BaseSalaryTb";
            BaseSalaryTb.Size = new Size(205, 23);
            BaseSalaryTb.TabIndex = 30;
            // 
            // BalanceTb
            // 
            BalanceTb.BorderStyle = BorderStyle.FixedSingle;
            BalanceTb.Location = new Point(343, 303);
            BalanceTb.Margin = new Padding(2);
            BalanceTb.Name = "BalanceTb";
            BalanceTb.Size = new Size(205, 23);
            BalanceTb.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(343, 277);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(91, 25);
            label15.TabIndex = 28;
            label15.Text = "Balance";
            // 
            // AdvanceTb
            // 
            AdvanceTb.BorderStyle = BorderStyle.FixedSingle;
            AdvanceTb.Location = new Point(71, 304);
            AdvanceTb.Margin = new Padding(2);
            AdvanceTb.Name = "AdvanceTb";
            AdvanceTb.Size = new Size(205, 23);
            AdvanceTb.TabIndex = 27;
            // 
            // EmpIdCb
            // 
            EmpIdCb.FormattingEnabled = true;
            EmpIdCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            EmpIdCb.Location = new Point(71, 237);
            EmpIdCb.Margin = new Padding(2);
            EmpIdCb.Name = "EmpIdCb";
            EmpIdCb.Size = new Size(205, 23);
            EmpIdCb.TabIndex = 26;
            EmpIdCb.SelectedIndexChanged += EmpIdCb_SelectedIndexChanged;
            EmpIdCb.SelectionChangeCommitted += EmpIdCb_SelectionChangeCommitted;
            // 
            // SalaryDGV
            // 
            SalaryDGV.BackgroundColor = SystemColors.ButtonHighlight;
            SalaryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryDGV.GridColor = SystemColors.ButtonHighlight;
            SalaryDGV.Location = new Point(365, 430);
            SalaryDGV.Margin = new Padding(2);
            SalaryDGV.Name = "SalaryDGV";
            SalaryDGV.RowHeadersWidth = 92;
            SalaryDGV.RowTemplate.Height = 45;
            SalaryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalaryDGV.Size = new Size(982, 214);
            SalaryDGV.TabIndex = 22;
            SalaryDGV.CellContentClick += SalaryDGV_CellContentClick;
            // 
            // PresTb
            // 
            PresTb.BorderStyle = BorderStyle.FixedSingle;
            PresTb.Enabled = false;
            PresTb.Location = new Point(1130, 304);
            PresTb.Margin = new Padding(2);
            PresTb.Name = "PresTb";
            PresTb.Size = new Size(205, 23);
            PresTb.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1130, 278);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 25);
            label10.TabIndex = 20;
            label10.Text = "Presence";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(866, 211);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 15;
            label13.Text = "Bonus";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(604, 277);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(78, 25);
            label12.TabIndex = 12;
            label12.Text = "Period";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(604, 211);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 25);
            label11.TabIndex = 10;
            label11.Text = "Base Salary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(71, 211);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(140, 25);
            label8.TabIndex = 4;
            label8.Text = "Employee ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(71, 278);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 2;
            label7.Text = "Advance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(343, 211);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 1;
            label6.Text = "Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.BorderStyle = BorderStyle.FixedSingle;
            EmpNameTb.Enabled = false;
            EmpNameTb.Location = new Point(343, 237);
            EmpNameTb.Margin = new Padding(2);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(205, 23);
            EmpNameTb.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 634);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Salary";
            Text = "Salary";
            Load += Salary_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button3;
        private Button button1;
        private Panel panel1;
        private DataGridView SalaryDGV;
        private TextBox PresTb;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox EmpNameTb;
        private Label label2;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox EmpIdCb;
        private DateTimePicker SalDate;
        private TextBox textBox7;
        private TextBox BaseSalaryTb;
        private TextBox BalanceTb;
        private Label label15;
        private TextBox AdvanceTb;
        private TextBox BonusTb;
        private ComboBox BonusIdCb;
        private TextBox ExcusedTb;
        private TextBox AbsTb;
        private Label label16;
        private Label label9;
        private ComboBox AttNumCb;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panel2;
        private Label label17;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Panel panel4;
    }
}