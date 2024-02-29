
namespace PROGRAM_SVINJE
{
    partial class TRENUTNI_PRIPUSTI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_krm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATUM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATUM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BROJ_KRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BROJ_NER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROIZVOĐAČ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proiz = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbID.Location = new System.Drawing.Point(853, 128);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(55, 27);
            this.tbID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 528);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "PROIZVOĐAČ";
            // 
            // tb_ner
            // 
            this.tb_ner.Location = new System.Drawing.Point(439, 561);
            this.tb_ner.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ner.Name = "tb_ner";
            this.tb_ner.Size = new System.Drawing.Size(73, 22);
            this.tb_ner.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 528);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "TETOVIR NERASTA";
            // 
            // tb_krm
            // 
            this.tb_krm.Location = new System.Drawing.Point(299, 561);
            this.tb_krm.Margin = new System.Windows.Forms.Padding(4);
            this.tb_krm.Name = "tb_krm";
            this.tb_krm.Size = new System.Drawing.Size(73, 22);
            this.tb_krm.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 528);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "TETOVIR KRMAČE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 528);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "IZABERI DATUM";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 558);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 25);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DATUM1,
            this.DATUM2,
            this.BROJ_KRM,
            this.BROJ_NER,
            this.PROIZVOĐAČ});
            this.dataGridView1.Location = new System.Drawing.Point(19, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(792, 497);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PROGRAM_SVINJE.Properties.Resources.Screenshot_32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(834, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 63);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PROGRAM_SVINJE.Properties.Resources.Screenshot_10;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(844, 177);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 59);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dodaj
            // 
            this.dodaj.BackgroundImage = global::PROGRAM_SVINJE.Properties.Resources.Screenshot_221;
            this.dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodaj.FlatAppearance.BorderSize = 0;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodaj.Location = new System.Drawing.Point(737, 519);
            this.dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(74, 68);
            this.dodaj.TabIndex = 22;
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // DATUM1
            // 
            this.DATUM1.HeaderText = "DATUM OSEMENJAVANJA";
            this.DATUM1.MinimumWidth = 6;
            this.DATUM1.Name = "DATUM1";
            this.DATUM1.Width = 110;
            // 
            // DATUM2
            // 
            this.DATUM2.HeaderText = "OČEKIVANI DATUM";
            this.DATUM2.MinimumWidth = 6;
            this.DATUM2.Name = "DATUM2";
            this.DATUM2.Width = 110;
            // 
            // BROJ_KRM
            // 
            this.BROJ_KRM.HeaderText = "TETOVIR KRMAČE";
            this.BROJ_KRM.MinimumWidth = 6;
            this.BROJ_KRM.Name = "BROJ_KRM";
            this.BROJ_KRM.Width = 60;
            // 
            // BROJ_NER
            // 
            this.BROJ_NER.HeaderText = "TETOVIR NERASTA";
            this.BROJ_NER.MinimumWidth = 6;
            this.BROJ_NER.Name = "BROJ_NER";
            this.BROJ_NER.Width = 60;
            // 
            // PROIZVOĐAČ
            // 
            this.PROIZVOĐAČ.HeaderText = "PROIZVOĐAČ";
            this.PROIZVOĐAČ.MinimumWidth = 6;
            this.PROIZVOĐAČ.Name = "PROIZVOĐAČ";
            this.PROIZVOĐAČ.Width = 150;
            // 
            // proiz
            // 
            this.proiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.proiz.FormattingEnabled = true;
            this.proiz.Items.AddRange(new object[] {
            "GORAN PEJOVIĆ"});
            this.proiz.Location = new System.Drawing.Point(566, 559);
            this.proiz.Name = "proiz";
            this.proiz.Size = new System.Drawing.Size(139, 24);
            this.proiz.TabIndex = 26;
            // 
            // TRENUTNI_PRIPUSTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.proiz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_krm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TRENUTNI_PRIPUSTI";
            this.Size = new System.Drawing.Size(940, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_krm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATUM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATUM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BROJ_KRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BROJ_NER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROIZVOĐAČ;
        private System.Windows.Forms.ComboBox proiz;
    }
}
