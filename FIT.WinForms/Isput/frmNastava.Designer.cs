namespace FIT.WinForms.Isput
{
    partial class frmNastava
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
            lblNazivOznaka = new Label();
            dgvNastava = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            cmbPredmet = new ComboBox();
            btnDodaj = new Button();
            cmbDan = new ComboBox();
            cmbVrijeme = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            SuspendLayout();
            // 
            // lblNazivOznaka
            // 
            lblNazivOznaka.AutoSize = true;
            lblNazivOznaka.Location = new Point(12, 9);
            lblNazivOznaka.Name = "lblNazivOznaka";
            lblNazivOznaka.Size = new Size(50, 20);
            lblNazivOznaka.TabIndex = 0;
            lblNazivOznaka.Text = "label1";
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastava.Location = new Point(12, 104);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowHeadersWidth = 51;
            dgvNastava.RowTemplate.Height = 29;
            dgvNastava.Size = new Size(776, 334);
            dgvNastava.TabIndex = 1;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 70);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(220, 28);
            cmbPredmet.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(694, 70);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Pon", "Uto", "Sri", "Cet", "Pet", "Sub" });
            cmbDan.Location = new Point(238, 70);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(220, 28);
            cmbDan.TabIndex = 2;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "8-10", "10-12", "12-14", "14-16" });
            cmbVrijeme.Location = new Point(464, 70);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(220, 28);
            cmbVrijeme.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Predmet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 47);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 0;
            label3.Text = "Dan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 47);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 0;
            label4.Text = "Vrijeme";
            // 
            // frmNastava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmet);
            Controls.Add(dgvNastava);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNazivOznaka);
            Name = "frmNastava";
            Text = "frmNastava";
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivOznaka;
        private DataGridView dgvNastava;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
        private ComboBox cmbPredmet;
        private Button btnDodaj;
        private ComboBox cmbDan;
        private ComboBox cmbVrijeme;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}