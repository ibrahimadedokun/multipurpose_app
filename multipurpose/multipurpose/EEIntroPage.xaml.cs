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
    public partial class EEIntroPage : ContentPage
    {
        public EEIntroPage()
        {
            InitializeComponent();
        }

        async private void eeStartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VIRPage());
        }
    }
}