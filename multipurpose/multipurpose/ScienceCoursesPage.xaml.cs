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
    public partial class ScienceCoursesPage : ContentPage
    {
        public ScienceCoursesPage()
        {
            InitializeComponent();

            eeImage.Source = ImageSource.FromResource("multipurpose.Images.ee.jpg");
            bioImage.Source = ImageSource.FromResource("multipurpose.Images.biology.png");
            chemImage.Source = ImageSource.FromResource("multipurpose.Images.chemistry_logo.jpg");
        }

        async private void eeGrid_Tapped(object sender, EventArgs e)
        {
            //DisplayAlert("Task", "You clicked me ", "All right");
            await Navigation.PushAsync(new EEIntroPage());
        }

        private void bioGrid_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Error", "Not updated", "OK");
        }

        private void chemGrid_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Error", "Yeah", "Bye");
        }

        private void phyGrid_Tapped(object sender, EventArgs e)
        {

        }
    }
}