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
    public partial class MESEC_STANJE : UserControl
    {
        public static MESEC_STANJE instance;
        public ComboBox cm1;
        public MESEC_STANJE()
        {
            InitializeComponent();
            instance = this;
            cm1 = comboBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ime_tabele = comboBox1.Text;
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
                    SQLiteCommand cmd = new SQLiteCommand("select * from '" + ime_tabele + "';", con);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(new string[] { reader[0].ToString(), reader[3].ToString(), reader[4].ToString(), reader[1].ToString(), reader[2].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() });

                    }

                }

            }
            catch (Exception ek)
            {
                MessageBox.Show("MORATE IZABRATI TABELU ZA PRIKAZ! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ime_tabele = comboBox1.Text;
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            // Load Excel workbook from file's path.
            ExcelFile workbook = ExcelFile.Load("sablon1.ods");

            if (dataGridView1.Rows[0].Cells[2].Value == null)
            {
                MessageBox.Show("Niste izabrali tabelu za prikaz. ");

            }
            else
            {
                String datum = dataGridView1.Rows[0].Cells[2].Value.ToString();
                String[] delovi = datum.Split('.');


                int days = DateTime.DaysInMonth(Convert.ToInt32(delovi[2]), Convert.ToInt32(delovi[1]));

                foreach (ExcelWorksheet worksheet in workbook.Worksheets)
                {

                    worksheet.Cells["V2"].Value = "1.-" + days.ToString() + "." + delovi[1] + "." + delovi[2] + ".";

                    using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand("select * from '" + ime_tabele + "';", con);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        int brojac = 7;
                        while (reader.Read())
                        {
                            worksheet.Cells["B" + brojac.ToString()].Value = Convert.ToDouble(reader[1].ToString());
                            worksheet.Cells["E" + brojac.ToString()].Value = reader[3].ToString();
                            worksheet.Cells["F" + brojac.ToString()].Value = Convert.ToDouble(reader[2].ToString());
                            worksheet.Cells["I" + brojac.ToString()].Value = reader[4].ToString();
                            worksheet.Cells["K" + brojac.ToString()].Value = Convert.ToDouble(reader[5].ToString());
                            worksheet.Cells["L" + brojac.ToString()].Value = Convert.ToDouble(reader[6].ToString());
                            worksheet.Cells["N" + brojac.ToString()].Value = Convert.ToDouble(reader[7].ToString());
                            worksheet.Cells["AA" + brojac.ToString()].Value = reader[8].ToString();

                            brojac++;
                        }

                    }

                    if (!Directory.Exists("ZA_SLANJE_PRAŠENJA"))
                    {
                        Directory.CreateDirectory("ZA_SLANJE_PRAŠENJA");
                    }

                }
                workbook.Save("ZA_SLANJE_PRAŠENJA/Registar-prašenja-" + ime_tabele + ".ods");
                MessageBox.Show("Kreiran Excel fajl Registar-prašenja-" + ime_tabele + ".ods");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String ime = comboBox1.Text;
            String brKRM = "";
            String datum = "";

            if (id.Length == 0)
            {
                MessageBox.Show("Morate popuniti polje za ID! ");
            }
            else
            {
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db"))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand("select * from'" + ime + "'where ID=" + id + ";", con);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            brKRM = reader[1].ToString();
                            datum = reader[4].ToString();
                        }

                    }

                }
                catch (Exception ek)
                {
                    MessageBox.Show("MORATE IZABRATI TABELU ZA PRIKAZ! ");
                }

                try
                {


                    double broj = Convert.ToDouble(id);

                    SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db");
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand("delete from '" + ime + "' where ID ='" + id + "'", con);
                    cmd.ExecuteNonQuery();

                    SQLiteCommand cmd2 = new SQLiteCommand("DELETE FROM SVE WHERE BrKRM='" + brKRM + "' AND datumPRASENJE='" + datum + "';", con);
                    cmd2.ExecuteNonQuery();


                    con.Close();
                }

                catch (Exception ek)
                {
                    MessageBox.Show("GRESKA PRILIKOM BRISANJA");
                }

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
                        SQLiteCommand cmd = new SQLiteCommand("select * from '" + ime + "';", con);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(new string[] { reader[0].ToString(), reader[3].ToString(), reader[4].ToString(), reader[1].ToString(), reader[2].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() });

                        }

                    }

                }
                catch (Exception ek)
                {
                    MessageBox.Show("MORATE IZABRATI TABELU ZA PRIKAZ! ");
                }

            }
        }

        
    }
}
