using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace multipurpose
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VIRPage : ContentPage
    {
        public VIRPage()
        {
            InitializeComponent();
        }

        async private void virNextPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void virPrevPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EEIntroPage());
        }
    }
}