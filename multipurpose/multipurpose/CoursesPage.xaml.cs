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
    public partial class CoursesPage : ContentPage
    {
        public CoursesPage()
        {
            InitializeComponent();

            stemImage.Source = ImageSource.FromResource("multipurpose.Images.stem_mockup.jpg");
            progImage.Source = ImageSource.FromResource("multipurpose.Images.programming.jpg");
            irkImage.Source = ImageSource.FromResource("multipurpose.Images.islam.jpg");
        }

        async private void irkParentGrid_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void progParentGrid_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void stemGrid_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScienceCoursesPage());
        }
    }
}