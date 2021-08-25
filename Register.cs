using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegisterForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-U9IEN5LE;Initial Catalog=VacForm;Integrated Security=True");
            object p = con.Open();
            SqlCommand cmd = new SqlCommand("insert into VaccinationForm(Surname) values('"+txtSurname.Text+"')", con);
            int i = cmd.ExecuteNonQuery();
            if (i!=0)
            {
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("error!!");
            }

        }
    }
}
