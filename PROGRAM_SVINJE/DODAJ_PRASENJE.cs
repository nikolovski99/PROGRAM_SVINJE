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
    public partial class DODAJ_PRASENJE : UserControl
    {
        public static DODAJ_PRASENJE instance;
        public ComboBox cm1;
        public DODAJ_PRASENJE()
        {
            InitializeComponent();
            instance = this;
            cm1 = comboBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ime_tabele = comboBox1.Text;
            String datumPRIPUST = datum1.Value.ToString("dd/MM/yyyy");
            String datumPRASENJE = datum2.Value.ToString("dd/MM/yyyy");
            String proizvodjac = proiz.Text;

            if (ime_tabele.Length == 0 || tb_krm.Text.Length == 0 || tb_krm.Text.Length == 0 || proizvodjac.Length == 0)
            {
                MessageBox.Show("Nisu popunjena sva polja! ");
            }
            else
            {
                try
                {
                    int brKRM = Convert.ToInt32(tb_krm.Text);
                    int brNER = Convert.ToInt32(tb_ner.Text);
                    int brMusko = Convert.ToInt32(musko.Text);
                    int brZensko = Convert.ToInt32(zensko.Text);
                    int brMrtvo = Convert.ToInt32(mrtvo.Text);

                    string add = $"insert into '{ime_tabele}' (ID,BrKRM,BrNER,datumPRIPUST,datumPRASENJE,rodjenoMUSKO,rodjenoZENSKO,rodjenoMRTVO,PROIZVODJAC) VALUES (NULL,{brKRM},{brNER},'{datumPRIPUST}','{datumPRASENJE}',{brMusko},{brZensko},{brMrtvo},'{proizvodjac}');";
                    string addSVE = $"insert into SVE (ID,BrKRM,BrNER,datumPRIPUST,datumPRASENJE,rodjenoMUSKO,rodjenoZENSKO,rodjenoMRTVO,PROIZVODJAC) VALUES (NULL,{brKRM},{brNER},'{datumPRIPUST}','{datumPRASENJE}',{brMusko},{brZensko},{brMrtvo},'{proizvodjac}');";

                    SQLiteConnection con = new SQLiteConnection(@"URI=file:novo.db");
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(add, con);
                    cmd.ExecuteNonQuery();

                    SQLiteCommand cmd2 = new SQLiteCommand(addSVE, con);
                    cmd2.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Dodato prašenje u " + ime_tabele + ".");

                }
                catch (Exception eks)
                {
                    MessageBox.Show("NISTE PRAVILNO POPUNILI POLJA! ");
                }


            }
        }

        
    }
}
