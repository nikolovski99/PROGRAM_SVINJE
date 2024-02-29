using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAM_SVINJE
{
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }
        public String Encrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String key = textBox1.Text;
            int m = PROGRAM_SVINJE.Properties.Settings.Default.mesec;
            String sifra = Encrypt("GORANPEJOVIC", m);
            Console.WriteLine(sifra);


            if (String.Equals(key, sifra))
            {
                PROGRAM_SVINJE.Properties.Settings.Default.ulazak = true;
                PROGRAM_SVINJE.Properties.Settings.Default.Save();
                Form1 f1 = new Form1();
                f1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("POGREŠNA LICENCA");
            }
        }

        private void FormP_Load(object sender, EventArgs e)
        {
            int m = PROGRAM_SVINJE.Properties.Settings.Default.mesec;
            label2.Text = m.ToString();
        }

    }
}
