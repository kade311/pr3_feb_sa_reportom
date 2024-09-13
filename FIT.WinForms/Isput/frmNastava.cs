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
    public partial class frmNastava : Form
    {
        private Prostorije kliknutaProstoija;
        DLWMSDbContext db = new DLWMSDbContext();
        List<Nastava> podaciNastava = new List<Nastava>();
        public frmNastava()
        {
            InitializeComponent();
        }

        public frmNastava(Prostorije kliknutaProstoija)
        {
            InitializeComponent();
            this.kliknutaProstoija = kliknutaProstoija;
            UcitajCmb();
            UcitajNastavu();
        }

        private void UcitajCmb()
        {
            cmbPredmet.DataSource = db.Predmeti.ToList();
            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.ValueMember = "Id";
            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
        }

        private void UcitajNastavu()
        {
            podaciNastava = db.Nastava.Where(x => x.ProstorijaId == kliknutaProstoija.Id).ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Predmet");
            dt.Columns.Add("Dan");
            dt.Columns.Add("Vrijeme");

            for (int i = 0; i < podaciNastava.Count; i++)
            {
                var red = dt.NewRow();
                var podatakNastava = podaciNastava[i];
                var predmet = db.Predmeti.FirstOrDefault(x => x.Id == podatakNastava.PredmetId);

                red["Predmet"] = predmet.Naziv;
                red["Dan"] = podatakNastava.Dan;
                red["Vrijeme"] = podatakNastava.Vrijeme;

                dt.Rows.Add(red);
            }
            dgvNastava.DataSource = dt;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var predmet = db.Predmeti.FirstOrDefault(x => x.Id == cmbPredmet.SelectedIndex+1).Naziv;
            var nastava = new Nastava()
            {
                ProstorijaId = kliknutaProstoija.Id,
                PredmetId = (int)cmbPredmet.SelectedValue,
                Vrijeme = cmbVrijeme.SelectedItem.ToString(),
                Dan = cmbDan.SelectedItem.ToString(),
                Oznaka = $"{predmet} :: {cmbDan.SelectedItem} :: {cmbVrijeme.SelectedItem}"
            };
            db.Nastava.Add(nastava);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
            UcitajNastavu();
        }
    }
}
