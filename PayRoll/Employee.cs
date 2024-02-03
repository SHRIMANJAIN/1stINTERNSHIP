using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PayRoll
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            ShowEmployee();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\deeks\OneDrive\Documents\EmpPay.mdf;Integrated Security=True;Connect Timeout=30 ");

        private void Clear()
        {
            // Clear the text of TextBoxes
            EmpNameTb.Text = "";
            EmpAddTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpSalTb.Text = "";
            // Set the selected index of ComboBoxes to 0
            EmpGenCb.SelectedIndex = 0;
            EmpPosCb.SelectedIndex = 0;
            EmpQualCb.SelectedIndex = 0;




        }
        private void ShowEmployee()
        {
            Con.Open();// Open a database connection
            string Query = "Select * from EmployeeTbl";// SQL query to select all records from the "EmployeeTbl" table
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);// Create a SqlDataAdapter to retrieve data from the database
            // Create a SqlCommandBuilder to automatically generate SQL commands for updating the database
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();// Create a new DataSet to hold the retrieved data
            sda.Fill(ds);// Fill the DataSet with data using the SqlDataAdapter
            EmployeeDGV.DataSource = ds.Tables[0]; // Set the DataSource of the DataGridView to the DataTable from the DataSet
            Con.Close();// Close the database connection

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtm_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (EmpNameTb.Text == " " || EmpPhoneTb.Text == " " || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == " " || EmpSalTb.Text == " " || EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();// Open the database connection
                    // Create a SqlCommand to insert data into the "EmployeeTbl" table
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl(EmpName,EmpGen,EmpDOB,EmpPhone,EmpAdd,EmpPos,JoinDate,EmpQual,EmpBasSal)values(@EN,@EG,@ED,@EP,@EA,@EPOS,@JD,@EQ,@EBS)", Con);
                    // Set parameters for the SqlCommand
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPOS", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.ExecuteNonQuery();// Execute the SqlCommand to insert data into the database
                    MessageBox.Show("Employee Details Saved");// Display a success message
                    Con.Close();// Close the database connection
                    ShowEmployee();// Refresh the display of employee data in the DataGridView
                    Clear();// Clear the input fields

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);// Display an error message if an exception occurs
                }
            }
        }



        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (EmpNameTb.Text == " " || EmpPhoneTb.Text == " " || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == " " || EmpSalTb.Text == " " || EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();// Open the database connection
                    // Create a SqlCommand to update data in the "EmployeeTbl" table
                    SqlCommand cmd = new SqlCommand("Update EmployeeTbl Set EmpName=@EN,EmpGen=@EG,EmpDOB=@ED,EmpPhone=@EP,EmpAdd=@EA,EmpPos=@EPOS,JoinDate=@JD,EmpQual=@EQ,EmpBasSal=@EBS where EmpId=@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);// Set parameters for the SqlCommand
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPOS", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.ExecuteNonQuery()// Set a parameter for the WHERE clause to identify the employee to be updated
                    cmd.Parameters.AddWithValue("@EmpKey", Key);// Execute the SqlCommand to update data in the database
                    MessageBox.Show("Employee Details Updated");// Display a success message
                    Con.Close();// Close the database connection
                    ShowEmployee();// Refresh the display of employee data in the DataGridView
                    Clear();// Clear the input fields

                }
                catch (Exception Ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)// Check if the 'Key' variable is 0
            {
                // If 'Key' is 0, show a message box indicating "Missing Information"
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();// Open a database connection
                    // Create a SQL command to delete a record from the 'EmployeeTbl' table where 'EmpId' equals the value of 'Key'
                    SqlCommand cmd = new SqlCommand("Delete from EmployeeTbl Where EmpId =@EmpKey", Con);
                    // Add a parameter '@EmpKey' with the value of the 'Key' variable to the SQL command
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery(); // Execute the SQL command to delete the record
                    MessageBox.Show("Employee Details Deleted"); // Show a message box indicating "Employee Details Deleted"
                    Con.Close(); // Close the database connection
                    // Call a method 'ShowEmployee()' (not shown in this snippet) to refresh the display of employee details
                    ShowEmployee();

                }
                catch (Exception Ex)
                {
                    // If an exception occurs during the try block, show an error message box with the exception message
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        int Key = 0;
        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set various TextBoxes and ComboBoxes with values from the selected row in the DataGridView 
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString(); //Employee name
            EmpGenCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString(); // Employee gender
            EmpDOB.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString(); // Employee date of birth
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();// Employee phone
            EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();// Employee address
            EmpPosCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[6].Value.ToString();// Employee position
            JDate.Text = EmployeeDGV.SelectedRows[0].Cells[7].Value.ToString();// Joining date
            EmpQualCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[8].Value.ToString();// Employee qualification
            EmpSalTb.Text = EmployeeDGV.SelectedRows[0].Cells[9].Value.ToString(); // Employee salary
            if (EmpNameTb.Text == " ") // Set the 'Key' variable based on the selected row
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();// Create an instance of the Bonus class
            Obj.Show(); // Show the Bonus form
            this.Hide();// Hide the current form (the form where this event handler is attached)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();// Create an instance of the Home class
            Obj.Show();// Show the Home form
            this.Hide();// Hide the current form (the form where this event handler is attached)
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Attendences Obj = new Attendences();// Create an instance of the Attendance class
            Obj.Show();// Show the Attendance form
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
