using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\KANDY SPORT CLUB\Employee\Employee\Database1.mdf;Integrated Security=True");
        SqlCommand com;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonINSERT_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                String detailquery = "insert into KemployeDetails values('" + textBoxforID.Text + "','" + textBoxforName.Text + "','" + textBoxforAge.Text + "','" + textBoxforContactnumber.Text + "','" + textBoxforAddress.Text + "','" + textBoxforWight.Text + "','" + textBoxforHight.Text + "','" + textBoxforPosition.Text + "')";
                com = new SqlCommand(detailquery, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully..");

                textBoxforID.Clear();
                textBoxforName.Clear();
                textBoxforAge.Clear();
                textBoxforContactnumber.Clear();
                textBoxforAddress.Clear();
                textBoxforWight.Clear();
                textBoxforHight.Clear();
                textBoxforPosition.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            


        }

        private void buttonSELECT_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from KemployeDetails where id= '" + textBoxforID.Text + "'";
                com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    textBoxforName.Text = dr[1].ToString();
                    textBoxforAge.Text = dr[2].ToString();
                    textBoxforContactnumber.Text= dr[3].ToString();
                    textBoxforAddress.Text = dr[4].ToString();
                    textBoxforWight.Text= dr[5].ToString();
                    textBoxforHight.Text= dr[6].ToString();
                    textBoxforPosition.Text = dr[7].ToString();
                }
                con.Close();
                MessageBox.Show(" correct or Not ?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                textBoxforID.Clear();
                textBoxforName.Clear();
                textBoxforAge.Clear();
                textBoxforContactnumber.Clear();
                textBoxforAddress.Clear();
                textBoxforWight.Clear();
                textBoxforHight.Clear();
                textBoxforPosition.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update KemployeDetails set Name ='" + textBoxforName.Text + "',Age='" + textBoxforAge.Text + "',Contactnumber='" + textBoxforContactnumber.Text + "',Address='" + textBoxforAddress.Text + "',Wight='" + textBoxforWight.Text + "',Hight ='" + textBoxforHight.Text + "',Position ='" + textBoxforPosition.Text + "'where Id ='" + textBoxforID.Text + "'";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated..");
                textBoxforID.Clear();
                textBoxforName.Clear();
                textBoxforAge.Clear();
                textBoxforContactnumber.Clear();
                textBoxforAddress.Clear();
                textBoxforWight.Clear();
                textBoxforHight.Clear();
                textBoxforPosition.Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "delete from KemployeDetails where id ='"+textBoxforID.Text+"'";
                com = new SqlCommand(query,con);
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted..");
                textBoxforID.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCLICKVIWE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from KemployeDetails";
                com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCENCEL_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show(" Thank you..");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
