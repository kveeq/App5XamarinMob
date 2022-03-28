using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App5XamarinMob.Models;
using App5XamarinMob.ViewModel;

namespace App5XamarinMob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : TabbedPage
    {
        readonly Project project;
        public static string Name;

        protected override void OnAppearing()
        {
            FillInfo();
            base.OnAppearing();
        }

        public ProjectPage(ProjectViewModel project)
        {
            InitializeComponent();
            BindingContext = project;
            FillInfo();
        }

        public void FillInfo()
        {
            ProjectDescriptionLbl.Text = project.Description;
            AddressLbl.Text = project.Address;
            EmailLbl.Text = project.Email;
            TelephoneNumberLbl1.Text = project.TelephoneNumber1;
            Img1.Source = project.ImagePath;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProjectPage(project));
        }
    }
}