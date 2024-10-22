namespace DLWMS.WinForms.Forms
{
    partial class frmKonsultacijeIB220161
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
            this.dgvKonsultacije = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNoviZahtjev = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.tbZahtjevi = new System.Windows.Forms.TextBox();
            this.cbPredmeti = new System.Windows.Forms.ComboBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKonsultacije
            // 
            this.dgvKonsultacije.AllowUserToAddRows = false;
            this.dgvKonsultacije.AllowUserToDeleteRows = false;
            this.dgvKonsultacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonsultacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Predmet,
            this.Datum,
            this.Napomena,
            this.Brisi});
            this.dgvKonsultacije.Location = new System.Drawing.Point(12, 53);
            this.dgvKonsultacije.Name = "dgvKonsultacije";
            this.dgvKonsultacije.ReadOnly = true;
            this.dgvKonsultacije.RowHeadersWidth = 51;
            this.dgvKonsultacije.RowTemplate.Height = 24;
            this.dgvKonsultacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonsultacije.Size = new System.Drawing.Size(776, 219);
            this.dgvKonsultacije.TabIndex = 0;
            this.dgvKonsultacije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsultacije_CellClick);
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Student.DataPropertyName = "StudentImePrezime";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            this.Student.Width = 81;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "PredmetNaziv";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 125;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Vrijeme odrzavanja";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 125;
            // 
            // btnNoviZahtjev
            // 
            this.btnNoviZahtjev.Location = new System.Drawing.Point(660, 12);
            this.btnNoviZahtjev.Name = "btnNoviZahtjev";
            this.btnNoviZahtjev.Size = new System.Drawing.Size(128, 35);
            this.btnNoviZahtjev.TabIndex = 1;
            this.btnNoviZahtjev.Text = "Novi zahtjev";
            this.btnNoviZahtjev.UseVisualStyleBackColor = true;
            this.btnNoviZahtjev.Click += new System.EventHandler(this.btnNoviZahtjev_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(660, 278);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(128, 35);
            this.btnPrintaj.TabIndex = 1;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // tbZahtjevi
            // 
            this.tbZahtjevi.Location = new System.Drawing.Point(12, 358);
            this.tbZahtjevi.Name = "tbZahtjevi";
            this.tbZahtjevi.Size = new System.Drawing.Size(186, 22);
            this.tbZahtjevi.TabIndex = 2;
            // 
            // cbPredmeti
            // 
            this.cbPredmeti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredmeti.FormattingEnabled = true;
            this.cbPredmeti.Location = new System.Drawing.Point(12, 404);
            this.cbPredmeti.Name = "cbPredmeti";
            this.cbPredmeti.Size = new System.Drawing.Size(186, 24);
            this.cbPredmeti.TabIndex = 3;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(258, 357);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(530, 114);
            this.tbInfo.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(130, 434);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(104, 37);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmKonsultacijeIB220161
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.cbPredmeti);
            this.Controls.Add(this.tbZahtjevi);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnNoviZahtjev);
            this.Controls.Add(this.dgvKonsultacije);
            this.Name = "frmKonsultacijeIB220161";
            this.Text = "frmKonsultacijeIB220161";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKonsultacije;
        private System.Windows.Forms.Button btnNoviZahtjev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.TextBox tbZahtjevi;
        private System.Windows.Forms.ComboBox cbPredmeti;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnDodaj;
    }
}