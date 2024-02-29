using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PROGRAM_SVINJE
{
    public partial class ISTORIJA__JEDINKE : UserControl
    {
        public ISTORIJA__JEDINKE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id_jedinke = br_jedinke.Text;
            try
            {
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 9;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "DATUM1";
                dataGridView1.Columns[2].Name = "DATUM2";
                dataGridView1.Columns[3].Name = "BROJ_KRM";
                dataGridView1.Columns[4].Name = "BROJ_NER";
                dataGridView1.Columns[5].Name = "MUSKO";
                dataGridView1.Columns[6].Name = "ZENSKO";
                dataGridView1.Columns[7].Name = "MRTVO";
                dataGridView1.Columns[8].Name = "PROIZVOĐAČ";
                using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from SVE where BrKRM=" + id_jedinke + ";", con);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(new string[] { reader[0].ToString(), reader[3].ToString(), reader[4].ToString(), reader[1].ToString(), reader[2].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() });

                    }

                }

            }
            catch (Exception ek)
            {
                MessageBox.Show("Niste pravilno popunili polje za pretragu. Unesite tetovir broj krmače. ");
            }
        }

    }
}
