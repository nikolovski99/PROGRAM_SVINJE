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
    public partial class DODAJ_TABELU : UserControl
    {
        public static DODAJ_TABELU instance;
        public ComboBox cm1;
        public DODAJ_TABELU()
        {
            InitializeComponent();
            instance = this;
            cm1 = comboBox1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String ime = ime_nova.Text.ToUpper();

            if (ime == "UKUCAJTE IME NOVE TABELE" || ime == "")
            {
                MessageBox.Show("Morate popuniti polje. ");
            }
            else
            {

                try
                {
                    SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db");
                    con.Open();

                    string komanda = $"CREATE TABLE '{ime}' ('ID' INTEGER,'BrKRM' INTEGER,'BrNER' INTEGER,'datumPRIPUST' TEXT,'datumPRASENJE' TEXT,'rodjenoMUSKO' INTEGER,'rodjenoZENSKO' INTEGER,'rodjenoMRTVO' INTEGER,'PROIZVODJAC' TEXT,PRIMARY KEY('ID' AUTOINCREMENT));";
                    SQLiteCommand cmd = new SQLiteCommand(komanda, con);
                    cmd.ExecuteNonQuery();

                    string add = $"insert into COMBO (IME) VALUES ('{ime}');";
                    SQLiteCommand cmd2 = new SQLiteCommand(add, con);
                    cmd2.ExecuteNonQuery();


                    con.Close();

                    MessageBox.Show("Dodata nova tabela " + ime + " !");

                    comboBox1.Items.Add(ime);

                }
                catch (Exception eks)
                {
                    MessageBox.Show("Tabela sa ovim imenom vec postoji. ");
                }
            }


            ime_nova.Text = "Ukucajte ime nove tabele";
            ime_nova.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ime = comboBox1.Text;
            String brKRM = "";
            String datum = "";

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                {
                    con.Open();
                    SQLiteCommand cmd5 = new SQLiteCommand("select * from '" + ime + "';", con);
                    SQLiteDataReader reader = cmd5.ExecuteReader();

                    while (reader.Read())
                    {
                        brKRM = reader[1].ToString();
                        datum = reader[4].ToString();

                        SQLiteCommand cmd4 = new SQLiteCommand("DELETE FROM SVE WHERE BrKRM='" + brKRM + "' AND datumPRASENJE='" + datum + "';", con);
                        cmd4.ExecuteNonQuery();
                    }

                    con.Close();
                }
                

            }
            catch (Exception ek)
            {
                MessageBox.Show("GRESKA PRILIKOM BRISANJA IZ GLOBALNE TABELE! ");
            }





            try
            {
                SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db");
                con.Open();

                string komanda = $"DROP TABLE '{ime}';";
                SQLiteCommand cmd = new SQLiteCommand(komanda, con);
                cmd.ExecuteNonQuery();

                string komanda2 = $"DELETE FROM COMBO WHERE IME = '{ime}';";
                SQLiteCommand cmd2 = new SQLiteCommand(komanda2, con);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Tabela " + ime + " obrisana!");

            }
            catch (Exception eks)
            {
                MessageBox.Show("Morate izabrati tabelu za brisanje. ");
            }

            comboBox1.Text = "Izaberite tabelu za brisanje";

            comboBox1.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from COMBO", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());

                }

            }
        }

        private void ime_nova_Enter(object sender, EventArgs e)
        {
            if (ime_nova.Text == "Ukucajte ime nove tabele")
            {
                ime_nova.Text = null;
                ime_nova.ForeColor = Color.Black;
            }
        }

        private void ime_nova_Leave(object sender, EventArgs e)
        {
            if (ime_nova.Text == "Ukucajte ime nove tabele")
            {
                ime_nova.Text = null;
                ime_nova.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Izaberite tabelu za brisanje")
            {
                comboBox1.Text = null;
                comboBox1.ForeColor = Color.Black;
            }
        }
    }
}
