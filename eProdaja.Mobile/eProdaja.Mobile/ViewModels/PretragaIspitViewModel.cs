using eProdaja.Mobile.Services;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Mobile.ViewModels
{
   public  class PretragaIspitViewModel:BaseViewModel
    {
        private readonly APIService _pretragaIspitService = new APIService("PretragaIspit");
        private readonly APIService _kupciService = new APIService("Kupci");

        public ObservableCollection<PretragaIspit> PretragaIspitList { get; set; } = new ObservableCollection<PretragaIspit>();
        public ObservableCollection<Kupci> KupciList { get; set; } = new ObservableCollection<Kupci>();
        Kupci _selectedKupac = null;

        public Kupci SelectedKupac
        {
            get { return _selectedKupac; }
            set
            {
                SetProperty(ref _selectedKupac, value);
                if (value != null)
                {
                    UcitajPodatke();
                }

            }
        }

        private async void UcitajPodatke()
        {
            var request = new Model.Requests.PretragaIspitSearchRequest
            {
                KupacId = _selectedKupac.KupacId
            };
            PretragaIspitList.Clear();
            var podaci = await _pretragaIspitService.Get<List<Model.PretragaIspit>>(request);
            foreach (var item in podaci)
            {
                PretragaIspitList.Add(item);
            }
        }

        public async Task Init()
        {
            PretragaIspitList.Clear();
            KupciList.Clear();
            var podaci = await _kupciService.Get<List<Model.Kupci>>();
            foreach (var item in podaci)
            {
                KupciList.Add(item);
            }
        }
    }
}
