using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinAllianceApp.Views
{
    public partial class CharDetail : ContentPage
    {
        public CharDetail()
        {
            InitializeComponent();
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
