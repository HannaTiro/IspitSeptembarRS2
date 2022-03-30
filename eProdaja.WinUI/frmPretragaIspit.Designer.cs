
namespace eProdaja.WinUI
{
    partial class frmPretragaIspit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinIznos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanPromet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvod";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(16, 30);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(193, 21);
            this.cmbProizvod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimalan iznos novca";
            // 
            // txtMinIznos
            // 
            this.txtMinIznos.Location = new System.Drawing.Point(19, 95);
            this.txtMinIznos.Name = "txtMinIznos";
            this.txtMinIznos.Size = new System.Drawing.Size(190, 20);
            this.txtMinIznos.TabIndex = 3;
            this.txtMinIznos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum do";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(276, 30);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 6;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(276, 95);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 7;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(401, 132);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kupac,
            this.UkupanPromet});
            this.dgvPodaci.Location = new System.Drawing.Point(19, 161);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.Size = new System.Drawing.Size(457, 182);
            this.dgvPodaci.TabIndex = 9;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(401, 349);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 10;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(19, 358);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(0, 13);
            this.lblIznos.TabIndex = 11;
            // 
            // Kupac
            // 
            this.Kupac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kupac.DataPropertyName = "Kupac";
            this.Kupac.HeaderText = "Ime i prezime kupca";
            this.Kupac.Name = "Kupac";
            this.Kupac.ReadOnly = true;
            // 
            // UkupanPromet
            // 
            this.UkupanPromet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UkupanPromet.DataPropertyName = "IznosSaPdv";
            this.UkupanPromet.HeaderText = "UkupanPromet";
            this.UkupanPromet.Name = "UkupanPromet";
            this.UkupanPromet.ReadOnly = true;
            // 
            // frmPretragaIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 405);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.dgvPodaci);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinIznos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProizvod);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIspit";
            this.Text = "frmPretragaIspit";
            this.Load += new System.EventHandler(this.frmPretragaIspit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinIznos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanPromet;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label lblIznos;
    }
}