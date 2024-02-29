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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            provera();

            try
            {

                TRENUTNI_PRIPUSTI.instance.dgv.Rows.Clear();

                TRENUTNI_PRIPUSTI.instance.dgv.ColumnCount = 6;
                TRENUTNI_PRIPUSTI.instance.dgv.Columns[0].Name = "ID";
                TRENUTNI_PRIPUSTI.instance.dgv.Columns[1].Name = "DATUM1";
                TRENUTNI_PRIPUSTI.instance.dgv.Columns[2].Name = "DATUM2";
                TRENUTNI_PRIPUSTI.instance.dgv.Columns[3].Name = "BROJ_KRM";
                TRENUTNI_PRIPUSTI.instance.dgv.Columns[4].Name = "BROJ_NER";
                TRENUTNI_PRIPUSTI.instance.dgv.Columns[5].Name = "PROIZVOĐAČ";
                using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from PRIPUST;", con);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TRENUTNI_PRIPUSTI.instance.dgv.Rows.Add(new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() });

                    }

                }


            }
            catch (Exception ek)
            {
                MessageBox.Show("GRESKA PRILIKOM UCITAVANJA TABELE0");
            }
            trenutnI_PRIPUSTI1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            provera();

            DODAJ_PRASENJE.instance.cm1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DODAJ_PRASENJE.instance.cm1.Items.Add(reader[0].ToString());

                }

            }
            dodaJ_PRASENJE1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            provera();

            istorijA__JEDINKE1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            provera();

            MESEC_STANJE.instance.cm1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MESEC_STANJE.instance.cm1.Items.Add(reader[0].ToString());

                }

            }

            meseC_STANJE1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            provera();

            DODAJ_TABELU.instance.cm1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DODAJ_TABELU.instance.cm1.Items.Add(reader[0].ToString());

                }

            }

            dodaJ_TABELU1.BringToFront();
        }

        public void provera()
        {

            if (PROGRAM_SVINJE.Properties.Settings.Default.ulazak)
            {
                PROGRAM_SVINJE.Properties.Settings.Default.datumNOW = DateTime.Now;
                PROGRAM_SVINJE.Properties.Settings.Default.datumISTEKA = DateTime.Now.AddDays(30);
                PROGRAM_SVINJE.Properties.Settings.Default.brojac = 1;
                PROGRAM_SVINJE.Properties.Settings.Default.ulazak = false;
                PROGRAM_SVINJE.Properties.Settings.Default.mesec++;
                PROGRAM_SVINJE.Properties.Settings.Default.Save();

            }

            if (DateTime.Now.Date > PROGRAM_SVINJE.Properties.Settings.Default.datumISTEKA)
            {
                FormP fp = new FormP();
                fp.Show();
                this.Visible = false;
            }
            else if (PROGRAM_SVINJE.Properties.Settings.Default.brojac > 29)
            {
                FormP fp = new FormP();
                fp.Show();
                this.Visible = false;
            }
            else
            {
                int x = DateTime.Compare(PROGRAM_SVINJE.Properties.Settings.Default.datumNOW.Date, DateTime.Now.Date);
                if (x != 0)
                {
                    PROGRAM_SVINJE.Properties.Settings.Default.datumNOW = DateTime.Now;
                    PROGRAM_SVINJE.Properties.Settings.Default.brojac++;
                    PROGRAM_SVINJE.Properties.Settings.Default.Save();

                }
            }

            TimeSpan ts = PROGRAM_SVINJE.Properties.Settings.Default.datumISTEKA.Date.Subtract(DateTime.Now.Date);
            label2.Text = ts.TotalDays.ToString();
            label3.Text = PROGRAM_SVINJE.Properties.Settings.Default.datumISTEKA.Date.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            provera();
            home1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
