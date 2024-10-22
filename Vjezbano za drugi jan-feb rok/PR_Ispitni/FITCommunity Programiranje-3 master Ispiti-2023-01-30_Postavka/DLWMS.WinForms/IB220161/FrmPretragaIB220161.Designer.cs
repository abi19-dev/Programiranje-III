namespace DLWMS.WinForms.IB220161
{
    partial class FrmPretragaIB220161
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
            dgvStudenti = new DataGridView();
            cbSpol = new ComboBox();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            odLabel = new Label();
            doLabel = new Label();
            err = new ErrorProvider(components);
            BrojIndexa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndexa, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Uvjerenja });
            dgvStudenti.Location = new Point(12, 86);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(976, 352);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // cbSpol
            // 
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(12, 52);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(123, 28);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(219, 53);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(242, 27);
            dtpOd.TabIndex = 2;
            dtpOd.Value = new DateTime(1989, 2, 22, 0, 0, 0, 0);
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(546, 53);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(242, 27);
            dtpDo.TabIndex = 3;
            dtpDo.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // odLabel
            // 
            odLabel.AutoSize = true;
            odLabel.Location = new Point(152, 60);
            odLabel.Name = "odLabel";
            odLabel.Size = new Size(32, 20);
            odLabel.TabIndex = 4;
            odLabel.Text = "Od:";
            odLabel.Click += label1_Click;
            // 
            // doLabel
            // 
            doLabel.AutoSize = true;
            doLabel.Location = new Point(488, 58);
            doLabel.Name = "doLabel";
            doLabel.Size = new Size(32, 20);
            doLabel.TabIndex = 5;
            doLabel.Text = "Do:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // BrojIndexa
            // 
            BrojIndexa.DataPropertyName = "Index";
            BrojIndexa.HeaderText = "Broj indexa";
            BrojIndexa.MinimumWidth = 6;
            BrojIndexa.Name = "BrojIndexa";
            BrojIndexa.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            ImePrezime.Width = 129;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // FrmPretragaIB220161
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(doLabel);
            Controls.Add(odLabel);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(cbSpol);
            Controls.Add(dgvStudenti);
            Name = "FrmPretragaIB220161";
            Text = "FrmPretragaIB220161";
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private ComboBox cbSpol;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private Label odLabel;
        private Label doLabel;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn BrojIndexa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}