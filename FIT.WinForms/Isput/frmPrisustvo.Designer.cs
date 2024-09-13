namespace FIT.WinForms.Isput
{
    partial class frmPrisustvo
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
            lblProstorija = new Label();
            lblKapacitet = new Label();
            cmbNastava = new ComboBox();
            btnDodaj = new Button();
            dgvPrisustvo = new DataGridView();
            Oznaka = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            txtBroj = new TextBox();
            label5 = new Label();
            label3 = new Label();
            btnGenerisi = new Button();
            cmbStudent = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.AutoSize = true;
            lblProstorija.Location = new Point(12, 9);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(50, 20);
            lblProstorija.TabIndex = 0;
            lblProstorija.Text = "label1";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(738, 9);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(50, 20);
            lblKapacitet.TabIndex = 0;
            lblKapacitet.Text = "label1";
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(12, 64);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(272, 28);
            cmbNastava.TabIndex = 1;
            cmbNastava.SelectedIndexChanged += cmbNastava_SelectedIndexChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(694, 63);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPrisustvo
            // 
            dgvPrisustvo.AllowUserToAddRows = false;
            dgvPrisustvo.AllowUserToDeleteRows = false;
            dgvPrisustvo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustvo.Columns.AddRange(new DataGridViewColumn[] { Oznaka, Student });
            dgvPrisustvo.Location = new Point(12, 110);
            dgvPrisustvo.Name = "dgvPrisustvo";
            dgvPrisustvo.ReadOnly = true;
            dgvPrisustvo.RowHeadersWidth = 51;
            dgvPrisustvo.RowTemplate.Height = 29;
            dgvPrisustvo.Size = new Size(776, 188);
            dgvPrisustvo.TabIndex = 3;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Predmet, dan , vrijeme";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Location = new Point(12, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 196);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 92);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(764, 98);
            txtInfo.TabIndex = 0;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(62, 20);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(125, 27);
            txtBroj.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 0;
            label5.Text = "Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 0;
            label3.Text = "Broj:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(193, 19);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(290, 64);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(272, 28);
            cmbStudent.TabIndex = 1;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 41);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Nastava";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrisustvo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(groupBox1);
            Controls.Add(dgvPrisustvo);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(lblKapacitet);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lblProstorija);
            Name = "frmPrisustvo";
            Text = "frmPrisustvo";
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProstorija;
        private Label lblKapacitet;
        private ComboBox cmbNastava;
        private Button btnDodaj;
        private DataGridView dgvPrisustvo;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private TextBox txtBroj;
        private Label label5;
        private Label label3;
        private Button btnGenerisi;
        private ComboBox cmbStudent;
        private Label label4;
        private Label label1;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Student;
        private ErrorProvider err;
    }
}