using eProdaja.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PretragaIspitPage : ContentPage
    {
        private PretragaIspitViewModel model = null;
        public PretragaIspitPage()
        {
            InitializeComponent();
            BindingContext = model = new PretragaIspitViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}