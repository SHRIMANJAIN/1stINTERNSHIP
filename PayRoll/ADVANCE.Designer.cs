namespace PayRoll
{
    partial class ADVANCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADVANCE));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1459, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(12, 529);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(1634, 605);
            dataGridView1.TabIndex = 41;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1046, 366);
            button3.Name = "button3";
            button3.Size = new Size(228, 52);
            button3.TabIndex = 40;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(631, 366);
            button2.Name = "button2";
            button2.Size = new Size(228, 52);
            button2.TabIndex = 39;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(206, 375);
            button1.Name = "button1";
            button1.Size = new Size(228, 52);
            button1.TabIndex = 38;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(975, 202);
            label1.Name = "label1";
            label1.Size = new Size(201, 48);
            label1.TabIndex = 37;
            label1.Text = "AMOUNT :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(990, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 43);
            textBox2.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(206, 202);
            label6.Name = "label6";
            label6.Size = new Size(146, 48);
            label6.TabIndex = 35;
            label6.Text = "NAME :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 43);
            textBox1.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(703, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 15);
            panel3.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(684, 101);
            label5.Name = "label5";
            label5.Size = new Size(233, 57);
            label5.TabIndex = 33;
            label5.Text = "ADVANCE";
            // 
            // ADVANCE
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 1137);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(label5);
            Name = "ADVANCE";
            Text = "ADVANCE";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Panel panel3;
        private Label label5;
    }
}