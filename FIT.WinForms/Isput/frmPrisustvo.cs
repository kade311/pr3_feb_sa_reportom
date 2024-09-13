using FIT.Data;
using FIT.Data.Ispit;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Isput
{
    public partial class frmPrisustvo : Form
    {
        private Prostorije kliknutaProstoija;
        DLWMSDbContext db = new DLWMSDbContext();
        List<Prisustvo> podaciPrisustvo = new List<Prisustvo>();
        public frmPrisustvo()
        {
            InitializeComponent();
        }

        public frmPrisustvo(Prostorije kliknutaProstoija)
        {
            InitializeComponent();
            this.kliknutaProstoija = kliknutaProstoija;
            UcitajCmb();
            UcitajPrisustva();
        }

        private void UcitajPrisustva()
        {
            var nastava = cmbNastava.SelectedValue is int ? (int)cmbNastava.SelectedValue : -1;
            var student = cmbStudent.SelectedValue is int ? (int)cmbStudent.SelectedValue : -1;

            podaciPrisustvo = db.Prisustvo.Where(x => x.NastavaId == nastava && x.StudentId == student).ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Oznaka");
            dt.Columns.Add("Student");
            for (int i = 0; i < podaciPrisustvo.Count(); i++)
            {
                var red = dt.NewRow();

                red["Oznaka"] = db.Nastava.FirstOrDefault(x => x.Id == podaciPrisustvo[i].NastavaId).Oznaka;
                red["Student"] = db.Studenti.FirstOrDefault(x => x.Id == podaciPrisustvo[i].StudentId).ToString();

                dt.Rows.Add(red);
            }
            dgvPrisustvo.DataSource = dt;
        }

        private void UcitajCmb()
        {
            cmbNastava.DataSource = db.Nastava.Where(x => x.ProstorijaId == kliknutaProstoija.Id).ToList();
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.ValueMember = "Id";
            //cmbNastava.SelectedIndex = 0;

            cmbStudent.DataSource = db.Studenti.ToList();
            cmbStudent.DisplayMember = "ImePrezimeIndeks";
            cmbStudent.ValueMember = "Id";
            //cmbStudent.SelectedIndex = 0;
        }

        private void cmbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPrisustva();
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UcitajPrisustva();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            var prisustvo = new Prisustvo()
            {
                NastavaId = (int)cmbNastava.SelectedValue,
                StudentId = (int)cmbStudent.SelectedValue
            };
            db.Prisustvo.Add(prisustvo);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
            UcitajPrisustva();
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                
                var broj = int.Parse(txtBroj.Text);
                Thread t = new Thread(() => generiraj(broj));
                t.Start();
            }
        }

        private void generiraj(int broj)
        {
            string tekst = "";

            
            var nastavaId = 0;
            var nastavaText = "";
            var studentId = 0;
            var studentText = "";

            cmbNastava.Invoke(new Action(() =>
            {
                nastavaId = (int)cmbNastava.SelectedValue;
                nastavaText = cmbNastava.SelectedItem.ToString();
            }));
            cmbStudent.Invoke(new Action(() =>
            {
                studentId = (int)cmbStudent.SelectedValue;
                nastavaText = cmbStudent.SelectedItem.ToString();
            }));

            for (int i = 0; i < broj; i++)
            {
                var prisustvo = new Prisustvo()
                {
                    NastavaId = nastavaId,
                    StudentId = studentId
                };

                db.Prisustvo.Add(prisustvo);
                db.SaveChanges();

                tekst += $"{DateTime.Now:dd.MM HH:mm:ss} -> {studentText} za {nastavaText}{Environment.NewLine}";
            }

            Action action = () =>
            {
                txtInfo.Text = tekst;
                UcitajPrisustva();
            };

            BeginInvoke(action);
        }


        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue);
        }
    }
}
