using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class Login : Form
    {
        public Login() //Constructor declaration
        {
            InitializeComponent();//Initializing the component
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_adminname.Text == "admin" && txt_password.Text == "admin")
            {
                Home a = new Home();// Create an instance of the Home class
                a.Show();// Show the Home form
                this.Hide();// Hide the current form (presumably the login form)

            }
            else if (txt_adminname.Text == "" || txt_password.Text == "")
            {
                // Code block executed if the previous condition is false
                // and either the admin name or password is empty
                MessageBox.Show("Please fill up all fields");
            }
            else
            {
                // Code block executed if all previous conditions are false
                MessageBox.Show("Incorrect Username/Password");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();// Exit the application
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_adminname.Text = "";// Clear the text in the txt_adminname textbox
            txt_password.Text = "";// Clear the text in the txt_password textbox
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
