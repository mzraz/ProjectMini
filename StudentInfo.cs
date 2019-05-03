using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMini
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void BACK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonInfo p = new PersonInfo();
            this.Hide();
            p.Show();
        }
    }
}
