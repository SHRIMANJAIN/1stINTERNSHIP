using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PayRoll
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();// Call the InitializeComponent method
            // Call custom methods to perform additional initialization
            GetEmployee();//related to getting employee information
            GetAttendence();//related to getting attendance information
            GetBonus();//related to getting bonus information
            ShowSalary();//related to displaying salary information
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\deeks\OneDrive\Documents\EmpPay.mdf;Integrated Security=True;Connect Timeout=30 ");

        private void Clear()
        {
            EmpNameTb.Text = "";// Clear the text of EmpNameTb TextBox
            PresTb.Text = "";// Clear the text of PresTb TextBox
            AbsTb.Text = "";// Clear the text of AbsTb TextBox
            ExcusedTb.Text = "";// Clear the text of ExcusedTb TextBox

            //Key = 0;


        }
        private void ShowSalary()
        {
            Con.Open()// Open the database connection
            // SQL query to select all columns from the SalaryTbl table
            string Query = "Select * from SalaryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);// Create a SqlDataAdapter to execute the SQL query
            // Create a SqlCommandBuilder to automatically generate SQL commands for updating data
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();// Create a new DataSet to store the result
            sda.Fill(ds);// Fill the DataSet with the result of the SQL query
            // Set the DataSource of the SalaryDGV DataGridView to the DataTable in the DataSet
            SalaryDGV.DataSource = ds.Tables[0];
            Con.Close();// Close the database connection

        }
        private void GetEmployee()
        {
            Con.Open();// Open the database connection
            // Create a SqlCommand to execute the SQL query
            SqlCommand cmd = new SqlCommand("Select *  from EmployeeTbl", Con);
            // Create a SqlDataReader to read the result of the SQL query
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();// Create a DataTable to store the result
            dt.Columns.Add("EmpId", typeof(int));// Add a column to the DataTable
            dt.Load(Rdr);// Load the SqlDataReader into the DataTable
            // Set ValueMember and DataSource for the ComboBox
            EmpIdCb.ValueMember = "EmpID";
            EmpIdCb.DataSource = dt;
            Con.Close();  // Close the database connection
        }
        private void GetBonus()
        {
            Con.Open();// Open the database connection
            // Create a SqlCommand to execute the SQL query
            SqlCommand cmd = new SqlCommand("Select *  from BonusTbl", Con);
            // Create a SqlDataReader to read the result of the SQL query
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();// Create a DataTable to store the result
            dt.Columns.Add("BName", typeof(String));// Add a column to the DataTable
            dt.Load(Rdr);// Load the SqlDataReader into the DataTable
            // Set ValueMember and DataSource for the ComboBox
            BonusIdCb.ValueMember = "BName";
            BonusIdCb.DataSource = dt;
            Con.Close();// Close the database connection
        }
        private void GetAttendence()
        {
            Con.Open();// Open the database connection
            // Create a SqlCommand to execute the SQL query with a WHERE clause based on the selected employee's ID
            SqlCommand cmd = new SqlCommand("Select *  from AttendenceTbl where EmpId=" + EmpIdCb.SelectedValue.ToString() + "", Con);
            // Create a SqlDataReader to read the result of the SQL query
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();// Create a DataTable to store the result
            dt.Columns.Add("AttaNum", typeof(int))// Add a column to the DataTable
            dt.Load(Rdr);// Load the SqlDataReader into the DataTable
            AttNumCb.ValueMember = "AttaNum";// Set ValueMember and DataSource for the ComboBox
            AttNumCb.DataSource = dt;
            Con.Close();// Close the database connection
        }
        private void GetEmployeeName()
        {
            Con.Open();// Open the database connection
            // Create a SQL query string with a WHERE clause based on the selected employee's ID
            string Query = "Select * from EmployeeTbl where EmpId=" + EmpIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);// Create a SqlCommand to execute the SQL query
            DataTable dt = new DataTable();// Create a DataTable to store the result
            SqlDataAdapter sda = new SqlDataAdapter(cmd);// Create a SqlDataAdapter to execute the SqlCommand
            sda.Fill(dt);// Fill the DataTable with the result of the SQL query
            // Iterate through the rows in the DataTable
            foreach (DataRow dr in dt.Rows)
            {
                // Set the text of EmpNameTb TextBox with the value from the "EmpName" column
                EmpNameTb.Text = dr["EmpName"].ToString();
                // Set the text of BaseSalaryTb TextBox with the value from the "EmpBasSal" column
                BaseSalaryTb.Text = dr["EmpBasSal"].ToString();
            }
            Con.Close();// Close the database connection

        }
        private void GetAttendenceData()
        {
            Con.Open();// Open the database connection
            // Create a SQL query string with a WHERE clause based on the selected attendance number
            string Query = "Select * from AttendenceTbl where AttaNum=" + AttNumCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);// Create a SqlCommand to execute the SQL query
            DataTable dt = new DataTable();// Create a DataTable to store the result
            SqlDataAdapter sda = new SqlDataAdapter(cmd);// Create a SqlDataAdapter to execute the SqlCommand
            sda.Fill(dt);// Fill the DataTable with the result of the SQL query
            // Iterate through the rows in the DataTable
            foreach (DataRow dr in dt.Rows)
            {
                PresTb.Text = dr["DayPres"].ToString();// Set the text of PresTb TextBox with the value from the "DayPres" column
                AbsTb.Text = dr["DayAbs"].ToString();// Set the text of AbsTb TextBox with the value from the "DayAbs" column
                ExcusedTb.Text = dr["DayExcused"].ToString();// Set the text of ExcusedTb TextBox with the value from the "DayExcused" column
            }
            Con.Close();// Close the database connection

        }
        private void GetBonusAmt()
        {
            Con.Open();// Open the database connection
            // Create a SQL query string with a WHERE clause based on the selected bonus name
            string Query = "Select * from BonusTbl where BName='" + BonusIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);// Create a SqlCommand to execute the SQL query
            DataTable dt = new DataTable();// Create a DataTable to store the result
            SqlDataAdapter sda = new SqlDataAdapter(cmd);// Create a SqlDataAdapter to execute the SqlCommand
            sda.Fill(dt); Fill the DataTable with the result of the SQL query

            // Iterate through the rows in the DataTable
            foreach (DataRow dr in dt.Rows)
            {
                BonusTb.Text = dr["BAmt"].ToString();// Set the text of BonusTb TextBox with the value from the "BAmt" column
                BonusTb.Text = dr["BAmt"].ToString();
            }
            Con.Close();// Close the database connection

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();// Create an instance of the Home class
            Obj.Show();// Show the Home form
            this.Hide();// Hide the current form
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();// Create an instance of the Employee class
            Obj.Show();// Show the Employee form
            this.Hide();// Hide the current form
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Attendences Obj = new Attendences();// Create an instance of the Attendance class
            Obj.Show();// Show the Attendance form
            this.Hide();// Hide the current form
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();// Create an instance of the Bonus class
            Obj.Show();// Show the Bonus form
            this.Hide();// Hide the current form
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (EmpNameTb.Text == " " || PresTb.Text == " " || AbsTb.Text == " " || ExcusedTb.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    // Construct a string for the salary period (month-year)
                    string Period = SalDate.Value.Month + "-" + SalDate.Value.Year;
                    Con.Open();// Open the database connection
                    // Create a SqlCommand to insert data into the SalaryTbl table
                    SqlCommand cmd = new SqlCommand("insert into SalaryTbl(EmpId,EmpName,EmpBasSal,EmpBonus,EmpAdvance,EmpTax,EmpBalance,SalPeriod)values(@EI,@EN,@EBS,@EBon,@EAd,@ETax,@EBalance,@SPer)", Con);
                    // Set parameters for the SqlCommand
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EBS", BaseSalaryTb.Text);
                    cmd.Parameters.AddWithValue("@Ebon", BonusTb.Text);
                    cmd.Parameters.AddWithValue("@EAd", AdvanceTb.Text);
                    cmd.Parameters.AddWithValue("@ETax", TotTax);
                    cmd.Parameters.AddWithValue("@EBalance", GrdTot);
                    cmd.Parameters.AddWithValue("@SPer", Period);

                    cmd.ExecuteNonQuery();// Execute the SqlCommand to insert data into the database
                    MessageBox.Show("Salary Saved");// Display a success message
                    Con.Close()// Close the database connection
                    ShowSalary();// Update the displayed salary information
                    Clear();// Clear input fields


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);// Display an error message if an exception occurs
                }
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();// Call the GetEmployeeName method to retrieve and display employee information
            GetAttendence(); // Call the GetAttendance method to retrieve and display attendance information
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BonusIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBonusAmt();// Call the GetBonusAmt method to retrieve and display bonus amount information

        }



        private void EmpIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttNumCb_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            GetAttendenceData();// Call the GetAttendanceData method to retrieve and display attendance data
        }




        int DailyBase = 0, Total = 0, Pres = 0, Abs = 0, Exc = 0;
        double GrdTot = 0, TotTax = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            // Check if required fields are empty
            if (BaseSalaryTb.Text == "" || BonusTb.Text == "" || AdvanceTb.Text == "")
            {
                MessageBox.Show("Select The Employee");
            }
            else
            {
                // Convert TextBox values to appropriate data types
                Pres = Convert.ToInt32(PresTb.Text);
                Abs = Convert.ToInt32(AbsTb.Text);
                Exc = Convert.ToInt32(ExcusedTb.Text);
                DailyBase = Convert.ToInt32(BaseSalaryTb.Text) / 28;
                Total = ((DailyBase) * Pres) + ((DailyBase / 2) * Exc);// Calculate total based on attendance
                // Calculate tax and net total
                double Tax = Total * 0.16;
                TotTax = Total - Tax;
                GrdTot = TotTax + Convert.ToInt32(BonusTb.Text);// Calculate the grand total including bonus
                BalanceTb.Text = "Rs" + GrdTot// Display the balance in the BalanceTb TextBox
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Drawing header information

            e.Graphics.DrawString("My CodeSpace Ltd", new Font("Averia", 12, FontStyle.Bold), Brushes.Red, new Point(160, 25));
            e.Graphics.DrawString("PayRoll Management System", new Font("Averia", 10, FontStyle.Bold), Brushes.Blue, new Point(125, 45));




            // Extracting data from the selected row in the DataGridView
            string SalNum = SalaryDGV.SelectedRows[0].Cells[0].Value.ToString();
            string EmpId = SalaryDGV.SelectedRows[0].Cells[1].Value.ToString();
            string EmpName = SalaryDGV.SelectedRows[0].Cells[2].Value.ToString();
            string BasSal = SalaryDGV.SelectedRows[0].Cells[3].Value.ToString();
            string Bonus = SalaryDGV.SelectedRows[0].Cells[4].Value.ToString();
            string Advance = SalaryDGV.SelectedRows[0].Cells[5].Value.ToString();
            string Tax = SalaryDGV.SelectedRows[0].Cells[6].Value.ToString();
            string Balance = SalaryDGV.SelectedRows[0].Cells[7].Value.ToString();
            string Period = SalaryDGV.SelectedRows[0].Cells[8].Value.ToString();


            // Drawing detailed information on the printed page
            e.Graphics.DrawString("Salary Number:" + SalNum, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Employee Id:" + EmpId, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("Employee Name:" + EmpName, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(250, 150));
            e.Graphics.DrawString("Base Salary:" + BasSal, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 180));
            e.Graphics.DrawString("Bonus:" + Bonus, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 210));
            e.Graphics.DrawString("Advance On Salary: Rs " + Advance, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 240));
            e.Graphics.DrawString("Tax: Rs " + Tax, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 270));
            e.Graphics.DrawString("Total: Rs " + Balance, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
            e.Graphics.DrawString("Period: " + Period, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 330));

            // Drawing footer information
            e.Graphics.DrawString("Powered By MyCodeSpace", new Font("Bellota", 12, FontStyle.Bold), Brushes.Crimson, new Point(150, 420));
            e.Graphics.DrawString("***************Version 1.0******************", new Font("Bellota", 12, FontStyle.Bold), Brushes.Crimson, new Point(100, 435));


        }

        private void SalaryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set the paper size for printing
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 500, 800);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)// Show the print preview dialog
            {
                // If the user clicks "OK" in the print preview dialog, proceed to print the document
                printDocument1.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
