using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmPretragaIspit : Form
    {
        APIService _izlaziService = new APIService("Izlazi");
        APIService _pretragaIspitService = new APIService("PretragaIspit");
        APIService _vrsteProizvodaService = new APIService("VrsteProizvodum");



        public frmPretragaIspit()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private async void frmPretragaIspit_Load(object sender, EventArgs e)
        {
            await LoadProizvode();
            await LoadPodatke();
        }

        private async Task LoadProizvode()
        {
            var podaci = await _vrsteProizvodaService.GetAll<List<Model.VrsteProizvodum>>(null);
            cmbProizvod.DataSource = podaci;
            cmbProizvod.DisplayMember = "Naziv";
            cmbProizvod.ValueMember = "VrstaId";
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            await LoadPodatke();
        }

        private async Task LoadPodatke()
        {
            var request = new Model.Requests.IzlaziSearchRequest
            {
                DatumDo = dtpDo.Value,
                DatumOd = dtpOd.Value,
                MinIznosPrometa = int.Parse(txtMinIznos.Text),
                VrstaPorizvodaId = int.Parse(cmbProizvod.SelectedValue.ToString())
            };
            var podaci = await _izlaziService.GetAll<List<Model.Izlazi>>(request);
            dgvPodaci.DataSource = podaci;
            lblIznos.Text = $"Ukupni promet: {podaci.Sum(x => x.IznosSaPdv).ToString("0.00")} KM";
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            var podaci = dgvPodaci.DataSource as List<Model.Izlazi>;
            foreach (var item in podaci)
            {
                var request = new Model.Requests.PretragaIspiInsertRequest
                {
                    DatumDO = dtpDo.Value,
                    DatumOD = dtpOd.Value,
                    IznosPrometa = item.IznosSaPdv,
                    KupacId = item.Narudzba.KupacId,
                    MinIznosPrometa = int.Parse(txtMinIznos.Text),
                    VrstaProizvodaId = int.Parse(cmbProizvod.SelectedValue.ToString())
                };
                await _pretragaIspitService.Insert<Model.PretragaIspit>(request);
            }
            MessageBox.Show("Uspješno ste spasili podatke");
        }
    }
}
