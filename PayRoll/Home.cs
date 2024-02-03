using System.Data;
using System.Data.SqlClient;

namespace PayRoll
{
    public partial class Home : Form
    {
        public Home()
        {
            // Call the InitializeComponent method
            InitializeComponent();
            // Call custom methods to perform additional initialization
            CountEmployee();//counts the number of employees
            CountManagers();//counts the number of manager
            SumBonus();//calculates bonus
            SumSalary();//calculates salary
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\deeks\OneDrive\Documents\EmpPay.mdf;Integrated Security=True;Connect Timeout=30 ");
        private void CountEmployee()
        {
            Con.Open();// Open the database connection
            // Create a SqlDataAdapter to execute the SQL query
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTbl", Con);
            DataTable dt = new DataTable(); // Create a DataTable to store the result
            sda.Fill(dt);// Fill the DataTable with the result of the query
            EmpLbl.Text = dt.Rows[0][0].ToString();// Display the count in the EmpLbl label
            Con.Close();// Close the database connection
        }
        private void CountManagers()
        {
            string Pos = "Manager";// Specify the position value to filter on
            Con.Open();// Open the database connection
            // Create a SqlDataAdapter to execute the SQL query with a filter on EmpPos
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTbl where EmpPos='" + Pos + "'", Con);
            DataTable dt = new DataTable();// Create a DataTable to store the result
            sda.Fill(dt);// Fill the DataTable with the result of the filtered query
            ManagerLb.Text = dt.Rows[0][0].ToString();// Display the count in the ManagerLb label
            Con.Close();// Close the database connection
        }
        private void SumSalary()
        {

            Con.Open();// Open the database connection
            // Create a SqlDataAdapter to execute the SQL query for summing EmpBalance
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBalance) from SalaryTbl", Con);
            DataTable dt = new DataTable();// Create a DataTable to store the result
            sda.Fill(dt);// Fill the DataTable with the result of the sum query
            SalaryLbl.Text = "Rs " + dt.Rows[0][0].ToString();// Display the sum in the SalaryLbl label with a currency format
            Con.Close();// Close the database connection
        }
        private void SumBonus()
        {

            Con.Open();// Open the database connection
            // Create a SqlDataAdapter to execute the SQL query for summing EmpBonus
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBonus) from SalaryTbl", Con);
            DataTable dt = new DataTable();// Create a DataTable to store the result
            sda.Fill(dt);// Fill the DataTable with the result of the sum query
            BonusLbl.Text = "Rs " + dt.Rows[0][0].ToString();// Fill the DataTable with the result of the sum query
            Con.Close();// Close the database connection
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();// Create an instance of the Employee class
            Obj.Show();// Show the Employee form
            this.Hide();// Hide the current form 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Attendences Obj = new Attendences()// Create an instance of the Attendences class
            Obj.Show();// Show the Attendences form
            this.Hide();// Hide the current form
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();// Create an instance of the Bonus class
            Obj.Show();// Show the Bonus form
            this.Hide();// Hide the current form
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Salary Obj = new Salary();// Create an instance of the Salary class
            Obj.Show();// Show the Salary form
            this.Hide();// Hide the current form
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {
        }

        private void BonusLbl_Click(object sender, EventArgs e)
        {

        }
    }
}