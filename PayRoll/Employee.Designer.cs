namespace PayRoll
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label16 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            panel4 = new Panel();
            label15 = new Label();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtm = new Button();
            EmployeeDGV = new DataGridView();
            EmpPhoneTb = new TextBox();
            label10 = new Label();
            EmpDOB = new DateTimePicker();
            label9 = new Label();
            EmpPosCb = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            EmpSalTb = new TextBox();
            EmpQualCb = new ComboBox();
            label12 = new Label();
            JDate = new DateTimePicker();
            label11 = new Label();
            EmpAddTb = new TextBox();
            label8 = new Label();
            EmpGenCb = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            EmpNameTb = new TextBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(422, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 33);
            label3.TabIndex = 2;
            label3.Text = "ATTEDENCE";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(792, 96);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 33);
            label5.TabIndex = 4;
            label5.Text = "ISSUE SALARY";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(84, 96);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 33);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(648, 96);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 33);
            label4.TabIndex = 3;
            label4.Text = "BONUS";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(241, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 33);
            label2.TabIndex = 1;
            label2.Text = "EMPLOYEE";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtm);
            panel1.Controls.Add(EmployeeDGV);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(EmpDOB);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(EmpPosCb);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(EmpSalTb);
            panel1.Controls.Add(EmpQualCb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(JDate);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(EmpGenCb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpNameTb);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1901, 1036);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(label16);
            panel2.Location = new Point(1014, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 147);
            panel2.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Firebrick;
            label16.Font = new Font("Berlin Sans FB Demi", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(51, 42);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(787, 62);
            label16.TabIndex = 2;
            label16.Text = "Employee Management System ";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(844, 18);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(78, 76);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(470, 18);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(78, 76);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(661, 18);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(78, 76);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(93, 18);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(78, 76);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 10;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(278, 18);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(78, 76);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Firebrick;
            panel4.ForeColor = Color.Firebrick;
            panel4.Location = new Point(241, 131);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 5);
            panel4.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(197, 222);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(90, 33);
            label15.TabIndex = 26;
            label15.Text = "Name";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(1150, 465);
            DeleteBtn.Margin = new Padding(2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(156, 34);
            DeleteBtn.TabIndex = 25;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Goldenrod;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(855, 465);
            EditBtn.Margin = new Padding(2);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(156, 34);
            EditBtn.TabIndex = 24;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtm
            // 
            SaveBtm.BackColor = Color.Green;
            SaveBtm.FlatStyle = FlatStyle.Flat;
            SaveBtm.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtm.ForeColor = Color.White;
            SaveBtm.Location = new Point(566, 465);
            SaveBtm.Margin = new Padding(2);
            SaveBtm.Name = "SaveBtm";
            SaveBtm.Size = new Size(156, 34);
            SaveBtm.TabIndex = 23;
            SaveBtm.Text = "SAVE";
            SaveBtm.UseVisualStyleBackColor = false;
            SaveBtm.Click += SaveBtm_Click;
            // 
            // EmployeeDGV
            // 
            EmployeeDGV.BackgroundColor = SystemColors.ButtonHighlight;
            EmployeeDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            EmployeeDGV.DefaultCellStyle = dataGridViewCellStyle1;
            EmployeeDGV.Location = new Point(11, 589);
            EmployeeDGV.Margin = new Padding(2);
            EmployeeDGV.Name = "EmployeeDGV";
            EmployeeDGV.RowHeadersWidth = 92;
            EmployeeDGV.RowTemplate.Height = 45;
            EmployeeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDGV.Size = new Size(1880, 404);
            EmployeeDGV.TabIndex = 22;
            EmployeeDGV.CellContentClick += EmployeeDGV_CellContentClick;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.BorderStyle = BorderStyle.FixedSingle;
            EmpPhoneTb.Location = new Point(521, 351);
            EmpPhoneTb.Margin = new Padding(2);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(201, 27);
            EmpPhoneTb.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(521, 316);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(135, 33);
            label10.TabIndex = 20;
            label10.Text = "Phone no";
            // 
            // EmpDOB
            // 
            EmpDOB.Location = new Point(521, 254);
            EmpDOB.Margin = new Padding(2);
            EmpDOB.Name = "EmpDOB";
            EmpDOB.Size = new Size(201, 27);
            EmpDOB.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(521, 219);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 33);
            label9.TabIndex = 18;
            label9.Text = "DOB";
            // 
            // EmpPosCb
            // 
            EmpPosCb.FormattingEnabled = true;
            EmpPosCb.Items.AddRange(new object[] { "MANAGER", "SENIOR", "JUNIOR" });
            EmpPosCb.Location = new Point(1491, 351);
            EmpPosCb.Margin = new Padding(2);
            EmpPosCb.Name = "EmpPosCb";
            EmpPosCb.Size = new Size(201, 28);
            EmpPosCb.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1491, 316);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(118, 33);
            label14.TabIndex = 16;
            label14.Text = "Position";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(1491, 222);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(162, 33);
            label13.TabIndex = 15;
            label13.Text = "Basic Salary";
            // 
            // EmpSalTb
            // 
            EmpSalTb.BorderStyle = BorderStyle.FixedSingle;
            EmpSalTb.Location = new Point(1491, 257);
            EmpSalTb.Margin = new Padding(2);
            EmpSalTb.Name = "EmpSalTb";
            EmpSalTb.Size = new Size(201, 27);
            EmpSalTb.TabIndex = 14;
            // 
            // EmpQualCb
            // 
            EmpQualCb.FormattingEnabled = true;
            EmpQualCb.Items.AddRange(new object[] { "B.E", "M.TECH", "BCA", "MCA" });
            EmpQualCb.Location = new Point(1150, 352);
            EmpQualCb.Margin = new Padding(2);
            EmpQualCb.Name = "EmpQualCb";
            EmpQualCb.Size = new Size(201, 28);
            EmpQualCb.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1150, 317);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(180, 33);
            label12.TabIndex = 12;
            label12.Text = "Qualification";
            // 
            // JDate
            // 
            JDate.Location = new Point(1150, 254);
            JDate.Margin = new Padding(2);
            JDate.Name = "JDate";
            JDate.Size = new Size(201, 27);
            JDate.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1150, 222);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(133, 33);
            label11.TabIndex = 10;
            label11.Text = "Join Date";
            // 
            // EmpAddTb
            // 
            EmpAddTb.BorderStyle = BorderStyle.FixedSingle;
            EmpAddTb.Location = new Point(832, 257);
            EmpAddTb.Margin = new Padding(2);
            EmpAddTb.Multiline = true;
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(201, 122);
            EmpAddTb.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(832, 222);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 33);
            label8.TabIndex = 4;
            label8.Text = "Address";
            // 
            // EmpGenCb
            // 
            EmpGenCb.FormattingEnabled = true;
            EmpGenCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            EmpGenCb.Location = new Point(197, 352);
            EmpGenCb.Margin = new Padding(2);
            EmpGenCb.Name = "EmpGenCb";
            EmpGenCb.Size = new Size(201, 28);
            EmpGenCb.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Berlin Sans FB Demi", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(197, 317);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(109, 33);
            label7.TabIndex = 2;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(268, 106);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 1;
            label6.Text = "NAME :";
            // 
            // EmpNameTb
            // 
            EmpNameTb.BorderStyle = BorderStyle.FixedSingle;
            EmpNameTb.Location = new Point(197, 257);
            EmpNameTb.Margin = new Padding(2);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(201, 27);
            EmpNameTb.TabIndex = 0;
            EmpNameTb.TextChanged += EmpNameTb_TextChanged;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label2;
        private Panel panel1;
        private Label label8;
        private ComboBox EmpGenCb;
        private Label label7;
        private Label label6;
        private TextBox EmpNameTb;
        private TextBox EmpAddTb;
        private Label label12;
        private DateTimePicker JDate;
        private Label label11;
        private TextBox EmpPhoneTb;
        private Label label10;
        private DateTimePicker EmpDOB;
        private Label label9;
        private ComboBox EmpPosCb;
        private Label label14;
        private Label label13;
        private TextBox EmpSalTb;
        private ComboBox EmpQualCb;
        private DataGridView EmployeeDGV;
        private Button SaveBtm;
        private Button DeleteBtn;
        private Button EditBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label15;
        private Panel panel2;
        private Label label16;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Panel panel4;
    }
}