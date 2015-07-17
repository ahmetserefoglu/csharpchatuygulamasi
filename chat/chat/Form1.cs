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

namespace chat
{
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder csb;
        public Form1()
        {
            InitializeComponent();
        }

        private void gonder_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length>0)
            {
                try
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dr["user"] = textBox2.Text;
                    dr["mesaj"] = textBox1.Text;
                    dt.Rows.Add(dr);
                    da.Update(dt);
                    textBox1.Text = "";
                    yenile();
                }
                catch { 
                }
            }


        }

        MySqlDataAdapter da;
        private void Form1_Load(object sender, EventArgs e)
        {
            csb = new MySqlConnectionStringBuilder();
            csb.Server = "10.41.60.133";
            csb.UserID = "ogrenci";
            csb.Password = "ogrenci";
            csb.Database = "chat";
            MySqlConnection conn = new MySqlConnection(csb.ToString());
            MySqlCommand cmd_sel = new MySqlCommand("select user,mesaj from chat;",conn);
            MySqlCommand cmd_ins = new MySqlCommand("insert into chat(user,mesaj) values(@user,@mesaj);", conn);
            cmd_ins.Parameters.Add("@user", MySqlDbType.Text, 50, "user");
            cmd_ins.Parameters.Add("@mesaj", MySqlDbType.Text, 50, "mesaj");

            da = new MySqlDataAdapter();
            da.SelectCommand = cmd_sel;
            da.InsertCommand = cmd_ins;
            yenile();
           
        }

        private void yenile()
        {
            try
            {
                timer1.Enabled = false; // durdur
                DataTable dt = new DataTable();
                da.Fill(dt);
                //listBox1.Items.Clear();
                int listcount = listBox1.Items.Count; // listboxtaki satir sayisi
                for (int i = listcount; i < dt.Rows.Count; i++)
                { // sadece yeni satirlari yazdir
                    listBox1.Items.Add(dt.Rows[i].ItemArray[0] + "::" + dt.Rows[i].ItemArray[1]);
                }

                if (listBox1.Items.Count > 0)
                    listBox1.SelectedIndex = listBox1.Items.Count - 1; 

                
                timer1.Enabled = true; // yeniden baslat
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yenile();
        }
    }
}
