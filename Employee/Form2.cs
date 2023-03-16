using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonlLogin_Click(object sender, EventArgs e)
        {
            try
            {
               string username = "KandySportclub@Kandy.Srilanka";
                string pwd = "1234";
                
                if(username == textBoxUsername.Text && pwd == textBoxPassword.Text) {
                   
                    FormLogin fl = new FormLogin();
                    this.Hide();
                    fl.Show();


                }
                else
                {
                    MessageBox.Show("Try Again..");
                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCENCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
