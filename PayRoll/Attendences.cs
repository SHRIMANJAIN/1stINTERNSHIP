using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PayRoll
{
    public partial class Attendences : Form
    {
        public Attendences()// Constructor for the Attendences class
        {
            InitializeComponent(); // Auto-generated code for initializing components
            ShowAttendence();// Call the ShowAttendence method to display attendance information
            GetEmployee();// Call the GetEmployee method to retrieve employee information

        }
        // SqlConnection object for connecting to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\deeks\OneDrive\Documents\EmpPay.mdf;Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            EmpNameTb.Text = ""; // Clear the text content of the EmpNameTb TextBox
            PresenceTb.Text = "";// Clear the text content of the PresenceTb TextBox
            AbsTb.Text = ""; // Clear the text content of the AbsTb TextBox
            ExcusedTb.Text = "";// Clear the text content of the ExcusedTb TextBox
            Key = 0;// Set the 'Key' variable to 0



        }
        private void ShowAttendence()
        {
            Con.Open(); // Open the database connection
            // SQL query to select all columns from the "AttendenceTbl" table
            string Query = "Select * from AttendenceTbl";
            // SqlDataAdapter to execute the query and fill a DataSet
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            // SqlCommandBuilder to automatically generate SQL commands for updating the database
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();// Create a new DataSet to hold the data
            sda.Fill(ds);// Fill the DataSet with data from the database
            // Set the DataSource of the DataGridView to the first table in the DataSet
            AttendenceDGV.DataSource = ds.Tables[0];
            Con.Close();// Close the database connection

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();// Create an instance of the Home class
            Obj.Show();// Show the Home form
            this.Hide();// Hide the current form (the form where this event handler is attached)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();// Create an instance of the Employee class
            Obj.Show();// Show the Employee form
            this.Hide();// Hide the current form (the form where this event handler is attached)
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();// Create an instance of the Bonus class
            Obj.Show();// Show the Bonus form
            this.Hide();// Hide the current form (the form where this event handler is attached)
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Salary Obj = new Salary();// Create an instance of the Salary class
            Obj.Show();// Show the Salary form
            this.Hide();// Hide the current form (the form where this event handler is attached)
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void GetEmployee()
        {
            Con.Open();// Open the database connection
            // SQL command to select all columns from the "EmployeeTbl" table
            SqlCommand cmd = new SqlCommand("Select *  from EmployeeTbl", Con);
            SqlDataReader Rdr; // SqlDataReader to read the data from the database
            Rdr = cmd.ExecuteReader();// Execute the SQL command and retrieve the data
            DataTable dt = new DataTable(); // Create a new DataTable to hold the data
            dt.Columns.Add("EmpId", typeof(int));// Add a column "EmpId" of type int to the DataTable
            dt.Load(Rdr);// Load the data from the SqlDataReader into the DataTable
            EmpIdCb.ValueMember = "EmpID";// Set the ValueMember and DataSource for the EmpIdCb ComboBox
            EmpIdCb.DataSource = dt;
            Con.Close();// Close the database connection
        }
        private void GetEmployeeName()
        {
            Con.Open();// Open the database connection
            // SQL query to select all columns from the "EmployeeTbl" table where EmpId matches the selected value
            string Query = "Select * from EmployeeTbl where EmpId=" + EmpIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);// SqlCommand to execute the query
            DataTable dt = new DataTable(); // DataTable to hold the result
            // SqlDataAdapter to fill the DataTable with the query result
            SqlDataAdapter sda = new SqlDataAdapter(cmd); 
            sda.Fill(dt);// Fill the DataTable with data from the database
            foreach (DataRow dr in dt.Rows)// Iterate through the rows of the DataTable
            {
                // Set the text of the EmpNameTb TextBox to the value of the "EmpName" column in the current DataRow
                EmpNameTb.Text = dr["EmpName"].ToString();
            }
            Con.Close();// Close the database connection

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields is empty
            if (EmpNameTb.Text == " " || PresenceTb.Text == " " || ExcusedTb.Text == "" || AbsTb.Text == " ")
            {
                MessageBox.Show("Missing Information");// Show a message box indicating missing information
            }
            else
            {
                try
                {
                    // Create a string representing the period based on the selected date
                    string Period = this.AttDate.Value.Month + " - " + this.AttDate.Value.Year;
                    Con.Open();// Open the database connection
                    // SqlCommand to insert data into the "AttendenceTbl" table
                    SqlCommand cmd = new SqlCommand("insert into AttendenceTbl(EmpId,EmpName,DayPres,DayAbs,DayExcused,Period)values(@EI,@EN,@DP,@DA,@DE,@Per)", Con);
                    // Set parameters for the SQL command
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.ExecuteNonQuery();// Execute the SQL command to insert data
                    MessageBox.Show("Attendance Details Saved");// Show a message box indicating successful save
                    Con.Close();// Close the database connection
                    ShowAttendence();// Call the ShowAttendence method to refresh the display
                    Clear();/ Call the Clear method to reset input fields

                }
                catch (Exception Ex)
                {
                    // Show a message box with the exception message in case of an error
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
        // Call the GetEmployeeName method when the selection in the ComboBox changes
         GetEmployeeName();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields is empty
            if (EmpNameTb.Text == "" || PresenceTb.Text == "" || ExcusedTb.Text == "" || AbsTb.Text == "")
            {
                MessageBox.Show("Missing Information");// Show a message box indicating missing information
            }
            else
            {
                try
                {
                    // Create a string representing the period based on the selected date
                    string Period = this.AttDate.Value.Month + " - " + this.AttDate.Value.Year;
                    Con.Open();// Open the database connection
                    // SqlCommand to update data in the "AttendenceTbl" table
                    SqlCommand cmd = new SqlCommand("Update AttendenceTbl Set DayPres=@DP,DayAbs=@DA,DayExcused=@DE,Period=@Per where AttaNum=@EmpKey", Con);
                    // Set parameters for the SQL command
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery();// Execute the SQL command to update data
                    MessageBox.Show("Attendance Details Updated");// Show a message box indicating successful update
                    Con.Close();// Close the database connection
                    ShowAttendence();// Call the ShowAttendence method to refresh the display
                    Clear();// Call the Clear method to reset input fields

                }
                catch (Exception Ex)
                {
                    // Show a message box with the exception message in case of an error
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)// Check if the 'Key' variable is 0, indicating missing information
            {
                MessageBox.Show("Missing Information");// Show a message box indicating missing information
            }
            else
            {
                try
                {
                    Con.Open();// Open the database connection
                     // SqlCommand to delete data from the "AttendenceTbl" table
                    SqlCommand cmd = new SqlCommand("Delete from AttendenceTbl Where AttaNum =@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EmpKey", Key);// Set parameters for the SQL command
                    cmd.ExecuteNonQuery();// Execute the SQL command to delete data
                    MessageBox.Show("Employee Details Deleted");// Show a message box indicating successful deletion
                    Con.Close();// Close the database connection
                    ShowAttendence();// Call the ShowAttendence method to refresh the display

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);// Show a message box with the exception message in case of an error
                }
            }
        }
        int Key = 0;
        private void AttendenceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate TextBoxes and ComboBox with selected row data
            EmpIdCb.Text = AttendenceDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpNameTb.Text = AttendenceDGV.SelectedRows[0].Cells[2].Value.ToString();
            PresenceTb.Text = AttendenceDGV.SelectedRows[0].Cells[3].Value.ToString();
            AbsTb.Text = AttendenceDGV.SelectedRows[0].Cells[4].Value.ToString();
            ExcusedTb.Text = AttendenceDGV.SelectedRows[0].Cells[5].Value.ToString();
            AttDate.Text = AttendenceDGV.SelectedRows[0].Cells[6].Value.ToString();
            // Update the 'Key' variable based on the selected row
            if (EmpIdCb.Text == " ")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttendenceDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void AttDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
