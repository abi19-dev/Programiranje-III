namespace DLWMS.WinForms.IB210000
{
    partial class frmPretragaIB210000
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbSpol = new ComboBox();
            label2 = new Label();
            dtpOd = new DateTimePicker();
            label3 = new Label();
            dtpDo = new DateTimePicker();
            err = new ErrorProvider(components);
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Spol:";
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(58, 8);
            cmbSpol.Margin = new Padding(3, 4, 3, 4);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(147, 28);
            cmbSpol.TabIndex = 1;
            cmbSpol.SelectionChangeCommitted += cmbSpol_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 12);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 2;
            label2.Text = "Rođen u periodu od:";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(355, 8);
            dtpOd.Margin = new Padding(3, 4, 3, 4);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(228, 27);
            dtpOd.TabIndex = 3;
            dtpOd.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 12);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 4;
            label3.Text = "do:";
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(635, 8);
            dtpDo.Margin = new Padding(3, 4, 3, 4);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(228, 27);
            dtpDo.TabIndex = 5;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Uvjerenja });
            dgvStudenti.Location = new Point(14, 47);
            dgvStudenti.Margin = new Padding(3, 4, 3, 4);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(850, 371);
            dgvStudenti.TabIndex = 6;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.Width = 130;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.Width = 125;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.Width = 125;
            // 
            // Uvjerenja
            // 
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            Uvjerenja.Width = 120;
            // 
            // frmPretragaIB210000
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 437);
            Controls.Add(dgvStudenti);
            Controls.Add(dtpDo);
            Controls.Add(label3);
            Controls.Add(dtpOd);
            Controls.Add(label2);
            Controls.Add(cmbSpol);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPretragaIB210000";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmPretragaIB210000_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbSpol;
        private Label label2;
        private DateTimePicker dtpOd;
        private Label label3;
        private DateTimePicker dtpDo;
        private ErrorProvider err;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}