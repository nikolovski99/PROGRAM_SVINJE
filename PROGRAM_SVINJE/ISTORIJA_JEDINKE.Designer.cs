
namespace PROGRAM_SVINJE
{
    partial class ISTORIJA__JEDINKE
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
            this.button1 = new System.Windows.Forms.Button();
            this.br_jedinke = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATUM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATUM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BROJ_KRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BROJ_NER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUSKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZENSKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRTVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROIZVOĐAČ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PROGRAM_SVINJE.Properties.Resources.Screenshot_33;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(176, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRIKAŽI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // br_jedinke
            // 
            this.br_jedinke.Location = new System.Drawing.Point(13, 37);
            this.br_jedinke.Margin = new System.Windows.Forms.Padding(4);
            this.br_jedinke.Name = "br_jedinke";
            this.br_jedinke.Size = new System.Drawing.Size(139, 22);
            this.br_jedinke.TabIndex = 5;
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
            this.MUSKO,
            this.ZENSKO,
            this.MRTVO,
            this.PROIZVOĐAČ});
            this.dataGridView1.Location = new System.Drawing.Point(13, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(912, 497);
            this.dataGridView1.TabIndex = 4;
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
            this.DATUM1.HeaderText = "DATUM PRIPUSTA";
            this.DATUM1.MinimumWidth = 6;
            this.DATUM1.Name = "DATUM1";
            this.DATUM1.Width = 80;
            // 
            // DATUM2
            // 
            this.DATUM2.HeaderText = "DATUM PRAŠENJA";
            this.DATUM2.MinimumWidth = 6;
            this.DATUM2.Name = "DATUM2";
            this.DATUM2.Width = 80;
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
            // MUSKO
            // 
            this.MUSKO.HeaderText = "RODJENO MUŠKO";
            this.MUSKO.MinimumWidth = 6;
            this.MUSKO.Name = "MUSKO";
            this.MUSKO.Width = 60;
            // 
            // ZENSKO
            // 
            this.ZENSKO.HeaderText = "RODJENO ŽENSKO";
            this.ZENSKO.MinimumWidth = 6;
            this.ZENSKO.Name = "ZENSKO";
            this.ZENSKO.Width = 60;
            // 
            // MRTVO
            // 
            this.MRTVO.HeaderText = "MRTVO";
            this.MRTVO.MinimumWidth = 6;
            this.MRTVO.Name = "MRTVO";
            this.MRTVO.Width = 60;
            // 
            // PROIZVOĐAČ
            // 
            this.PROIZVOĐAČ.HeaderText = "PROIZVOĐAČ";
            this.PROIZVOĐAČ.MinimumWidth = 6;
            this.PROIZVOĐAČ.Name = "PROIZVOĐAČ";
            this.PROIZVOĐAČ.Width = 120;
            // 
            // ISTORIJA__JEDINKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.br_jedinke);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ISTORIJA__JEDINKE";
            this.Size = new System.Drawing.Size(940, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox br_jedinke;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATUM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATUM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BROJ_KRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BROJ_NER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZENSKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRTVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROIZVOĐAČ;
    }
}
