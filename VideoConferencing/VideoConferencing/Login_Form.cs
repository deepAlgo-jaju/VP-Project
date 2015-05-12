using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoConferencing
{
     
    public partial class Login_Form : Form
    {
        //public string loggedUser;

        public Login_Form()
        {
            InitializeComponent();
        }
        
        //
        // used to close the Login form
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // used to check the username and pass
        // also used to login to the system
        //
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comboBox_Login_UserName.Text=="user1"&& textBox_Login_Pass.Text=="1234")
            {
                MessageBox.Show("Signed In As : user 1");
                string userName = "user1";
                Main_Form Main_Form = new Main_Form(userName);
                this.Hide();
                Main_Form.ShowDialog();
                this.Close();

            }
            else if (comboBox_Login_UserName.Text=="user2"&& textBox_Login_Pass.Text=="1234")
            {
                MessageBox.Show("Signed In As : user 2");
                string userName = "user2";
                Main_Form Main_Form = new Main_Form(userName);
                this.Hide();
                Main_Form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong details entered...!\n Check your username or/and password again");
            }

        }
    }
}
