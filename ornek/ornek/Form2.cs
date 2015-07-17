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
    public partial class Form2 : Form
    {
        MySqlDataAdapter da_hasta;
        MySqlDataAdapter da_hasta_upd;

        public Form2(MySqlConnectionStringBuilder _bag)
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection(_bag.ToString());

            MySqlCommand cmd_hasta_sel = new MySqlCommand("select h.idhasta,h.tc,h.adsoyad,d.doktorad,h.teshis from hasta h inner join doktor d on d.iddoktor=h.iddr;", conn);
            da_hasta = new MySqlDataAdapter();
            da_hasta.SelectCommand = cmd_hasta_sel;


            da_hasta_upd = new MySqlDataAdapter(); // hasta eklemek icin
            MySqlCommand cmdhasta_sel = new MySqlCommand("select idhasta,teshis from hasta;", conn);
            MySqlCommand cmdhasta_upd = new MySqlCommand("update hasta set teshis=@teshis where idhasta=@idhasta;", conn);
            cmdhasta_upd.Parameters.Add("@teshis", MySqlDbType.VarChar, 100, "teshis");
            cmdhasta_upd.Parameters.Add("@idhasta", MySqlDbType.Int32, 11, "idhasta");
            da_hasta_upd.SelectCommand = cmdhasta_sel;
            da_hasta_upd.UpdateCommand = cmdhasta_upd;


            verigetir();
          

        }

        private void verigetir()
        {

            DataTable dt = new DataTable();
            da_hasta.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false; // id
            dataGridView1.Columns[1].ReadOnly = true; // tc
            dataGridView1.Columns[2].ReadOnly = true; // ad
            dataGridView1.Columns[3].ReadOnly = true; // doktoradi
            dataGridView1.AllowUserToAddRows = false; // satir ekleme pasif
            dataGridView1.AllowUserToDeleteRows = false; // satir silme pasif
            // satir ekleme iptali
            // silme iptali


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            DataTable dt = new DataTable();
            da_hasta_upd.Fill(dt);
            DataRow dr = dt.Rows[e.RowIndex];
            dr["teshis"] = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            da_hasta_upd.Update(dt);
            verigetir();




        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
