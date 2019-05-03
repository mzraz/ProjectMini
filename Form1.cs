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

namespace ProjectMini
{
    public partial class PersonInfo : Form
    {
        public PersonInfo()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupsInfo a = new GroupsInfo();
            this.Hide();
            a.Show();
        }
        public string constr = "Data Source=DESKTOP-66EPK3P\\ZEESHANSQL;Initial Catalog=ProjectMini;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            if(con.State == ConnectionState.Open)
            {
                string query = "Insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender)Values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+textBox4.Text.ToString()+"','"+Convert.ToDateTime(dateTimePicker1.Value)+"','"+Convert.ToInt32(comboBox1)+"')" ;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.BeginExecuteNonQuery();
                MessageBox.Show("Date Inserted Successfully");
            }
            else
            {
                MessageBox.Show("some error Occured");

            }

        }
    }
}
