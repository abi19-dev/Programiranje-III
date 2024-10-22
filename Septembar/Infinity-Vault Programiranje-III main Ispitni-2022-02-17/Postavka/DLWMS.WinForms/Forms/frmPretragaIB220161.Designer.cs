namespace DLWMS.WinForms.Forms
{
    partial class frmPretragaIB220161
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
            this.tbImePrezime = new System.Windows.Forms.TextBox();
            this.cbGodine = new System.Windows.Forms.ComboBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konsultacije = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // tbImePrezime
            // 
            this.tbImePrezime.Location = new System.Drawing.Point(12, 44);
            this.tbImePrezime.Name = "tbImePrezime";
            this.tbImePrezime.Size = new System.Drawing.Size(429, 22);
            this.tbImePrezime.TabIndex = 0;
            this.tbImePrezime.TextChanged += new System.EventHandler(this.tbImePrezime_TextChanged);
            // 
            // cbGodine
            // 
            this.cbGodine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGodine.FormattingEnabled = true;
            this.cbGodine.Location = new System.Drawing.Point(600, 42);
            this.cbGodine.Name = "cbGodine";
            this.cbGodine.Size = new System.Drawing.Size(188, 24);
            this.cbGodine.TabIndex = 1;
            this.cbGodine.SelectedIndexChanged += new System.EventHandler(this.cbGodine_SelectedIndexChanged);
            this.cbGodine.SelectionChangeCommitted += new System.EventHandler(this.cbGodine_SelectionChangeCommitted);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.GodinaStudija,
            this.Prosjek,
            this.Konsultacije});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 97);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(776, 207);
            this.dgvStudenti.TabIndex = 2;
            this.dgvStudenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.MinimumWidth = 6;
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            this.GodinaStudija.Width = 125;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            this.Prosjek.Width = 125;
            // 
            // Konsultacije
            // 
            this.Konsultacije.HeaderText = "Konsultacije";
            this.Konsultacije.MinimumWidth = 6;
            this.Konsultacije.Name = "Konsultacije";
            this.Konsultacije.ReadOnly = true;
            this.Konsultacije.Text = "Konsultacije";
            this.Konsultacije.UseColumnTextForButtonValue = true;
            this.Konsultacije.Width = 125;
            // 
            // frmPretragaIB220161
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.cbGodine);
            this.Controls.Add(this.tbImePrezime);
            this.Name = "frmPretragaIB220161";
            this.Text = "frmPretragaIB220161";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImePrezime;
        private System.Windows.Forms.ComboBox cbGodine;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Konsultacije;
    }
}