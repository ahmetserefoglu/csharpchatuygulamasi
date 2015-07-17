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
    public partial class Form3 : Form
    {

        MySqlDataAdapter da_hasta;
        MySqlDataAdapter da_hasta_ekle;
        DataTable dt_dr = new DataTable(); // tek tablo

        public Form3(MySqlConnectionStringBuilder _bag)
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection(_bag.ToString());
            MySqlCommand cmd_hasta_sel = new MySqlCommand("select h.tc,h.adsoyad,d.doktorad from hasta h inner join doktor d on d.iddoktor=h.iddr;", conn);
            da_hasta = new MySqlDataAdapter();
            da_hasta.SelectCommand = cmd_hasta_sel;


            MySqlCommand cmd_dr_sel = new MySqlCommand("select iddoktor, doktorad from doktor;", conn);
            MySqlDataAdapter da_dr = new MySqlDataAdapter();
            da_dr.SelectCommand = cmd_dr_sel;
            da_dr.Fill(dt_dr); // doktorlarin listesi

 
            da_hasta_ekle = new MySqlDataAdapter(); // hasta eklemek icin
            MySqlCommand cmdhasta_sel = new MySqlCommand("select tc, adsoyad, iddr from hasta;", conn);
            MySqlCommand cmdhasta_ins = new MySqlCommand("insert into hasta(tc, adsoyad, iddr) values(@tc, @adsoyad, @iddr);", conn);
            cmdhasta_ins.Parameters.Add("@tc", MySqlDbType.VarChar, 11, "tc");
            cmdhasta_ins.Parameters.Add("@adsoyad", MySqlDbType.VarChar, 45, "adsoyad");
            cmdhasta_ins.Parameters.Add("@iddr", MySqlDbType.Int32, 11, "iddr");
            
            da_hasta_ekle.SelectCommand = cmdhasta_sel;
            da_hasta_ekle.InsertCommand = cmdhasta_ins;

           

            verigetir();
            
            // doktorlarin listesini comboya
            for (int i = 0; i < dt_dr.Rows.Count; i++)
                cdoktor.Items.Add(dt_dr.Rows[i].ItemArray[1].ToString()); 


        }

        private void verigetir()
        {

            // hastalari sisteme yukle
           // da_hasta

            ltc.Items.Clear();
            ladsoyad.Items.Clear();
            ldoktor.Items.Clear();

            DataTable dt = new DataTable();
            da_hasta.Fill(dt); // hastanin isimleri ve doktor karsiliklari burada

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltc.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                ladsoyad.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                ldoktor.Items.Add(dt.Rows[i].ItemArray[2].ToString());
            }
        
        }

        private void bekle_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            da_hasta_ekle.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["tc"] = ttc.Text;
            dr["adsoyad"] = tadsoyad.Text;
            dr["iddr"] = Convert.ToInt32(dt_dr.Rows[cdoktor.SelectedIndex].ItemArray[0].ToString());

            dt.Rows.Add(dr);
            da_hasta_ekle.Update(dt);
            
            verigetir();
        }

      
    }
}
