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
using GemBox.Spreadsheet;
using System.IO;

namespace PROGRAM_SVINJE
{
    public partial class TRENUTNI_PRIPUSTI : UserControl
    {
        public static TRENUTNI_PRIPUSTI instance;
        public DataGridView dgv;
        public TRENUTNI_PRIPUSTI()
        {
            InitializeComponent();
            instance = this;
            dgv = dataGridView1;

        }

        private void dodaj_Click(object sender, EventArgs e)
        {

            String datum = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            String datum2 = dateTimePicker1.Value.AddDays(115).ToString("dd/MM/yyyy");
            String proizvodjac = proiz.Text;

            if (tb_krm.Text.Length == 0 || tb_ner.Text.Length == 0 || proizvodjac.Length == 0)
            {
                MessageBox.Show("Nisu popunjena sva polja! ");
            }
            else
            {
                try
                {
                    int brKRM = Convert.ToInt32(tb_krm.Text);
                    int brNER = Convert.ToInt32(tb_ner.Text);
                    string add = $"insert into PRIPUST (ID,DATUM1,DATUM2,BrKRM,BrNER,PROIZVODJAC) VALUES (NULL,'{datum}','{datum2}',{brKRM},{brNER},'{proizvodjac}');";

                    SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db");
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(add, con);

                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception eks)
                {
                    MessageBox.Show("GRESKA PRILIKOM DODAVANJA");
                }


                try
                {
                    dataGridView1.Rows.Clear();

                    dataGridView1.ColumnCount = 6;
                    dataGridView1.Columns[0].Name = "ID";
                    dataGridView1.Columns[1].Name = "DATUM1";
                    dataGridView1.Columns[2].Name = "DATUM2";
                    dataGridView1.Columns[3].Name = "BROJ_KRM";
                    dataGridView1.Columns[4].Name = "BROJ_NER";
                    dataGridView1.Columns[5].Name = "PROIZVOĐAČ";
                    using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand("select * from PRIPUST", con);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() });

                        }

                    }

                }
                catch (Exception ek)
                {
                    MessageBox.Show("GRESKA PRILIKOM UCITAVANJA TABELE1");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = tbID.Text;

            if (id.Length == 0)
            {
                MessageBox.Show("Morate popuniti polje za ID! ");
            }
            else
            {

                try
                {
                    double broj = Convert.ToDouble(id);

                    SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db");
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand("delete from PRIPUST where ID ='" + id + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                catch (Exception ek)
                {
                    MessageBox.Show("GRESKA PRILIKOM BRISANJA");
                }

                try
                {
                    dataGridView1.Rows.Clear();

                    dataGridView1.ColumnCount = 6;
                    dataGridView1.Columns[0].Name = "ID";
                    dataGridView1.Columns[1].Name = "DATUM1";
                    dataGridView1.Columns[2].Name = "DATUM2";
                    dataGridView1.Columns[3].Name = "BROJ_KRM";
                    dataGridView1.Columns[4].Name = "BROJ_NER";
                    dataGridView1.Columns[5].Name = "PROIZVOĐAČ";
                    using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand("select * from PRIPUST", con);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() });

                        }

                    }

                }
                catch (Exception eks)
                {
                    MessageBox.Show("GRESKA PRILIKOM UCITAVANJA");
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            // Load Excel workbook from file's path.
            ExcelFile workbook = ExcelFile.Load("sablon2.ods");


            if (dataGridView1.Rows[0].Cells[1].Value == null)
            {
                MessageBox.Show("Ne možete kreirati fajl od prazne tabele. ");
            }
            else
            {
                String datum = dataGridView1.Rows[0].Cells[1].Value.ToString();
                String[] delovi = datum.Split('.');

                int days = DateTime.DaysInMonth(Convert.ToInt32(delovi[2]), Convert.ToInt32(delovi[1]));

                foreach (ExcelWorksheet worksheet in workbook.Worksheets)
                {

                    worksheet.Cells["I2"].Value = "1.-" + days.ToString() + "." + delovi[1] + "." + delovi[2] + ".";

                    using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand("select * from PRIPUST;", con);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        int brojac = 7;
                        while (reader.Read())
                        {
                            worksheet.Cells["B" + brojac.ToString()].Value = reader[1].ToString();
                            worksheet.Cells["C" + brojac.ToString()].Value = Convert.ToDouble(reader[3].ToString());
                            worksheet.Cells["E" + brojac.ToString()].Value = Convert.ToDouble(reader[4].ToString());
                            worksheet.Cells["K" + brojac.ToString()].Value = reader[5].ToString();

                            brojac++;
                        }

                    }

                    if (!Directory.Exists("ZA_SLANJE_PRIPUSTI"))
                    {
                        Directory.CreateDirectory("ZA_SLANJE_PRIPUSTI");
                    }

                }
                workbook.Save("ZA_SLANJE_PRIPUSTI/Registar-pripusta-" + delovi[1] + "-" + delovi[2] + ".ods");
                MessageBox.Show("Kreiran Excel fajl Registar-pripusta-" + delovi[1] + "-" + delovi[2] + ".ods");
            }
        }

        
    }
}
