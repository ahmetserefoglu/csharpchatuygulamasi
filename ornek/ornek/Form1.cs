using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder bag;
        private void bhkayit_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(bag);
            frm.ShowDialog();

        }

        private void bdoktor_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(bag);
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bag = new MySqlConnectionStringBuilder();
            bag.Server = "localhost";
            bag.UserID = "root";
            bag.Password = "1234";
            bag.Database = "hastane";
            

        }
    }
}
