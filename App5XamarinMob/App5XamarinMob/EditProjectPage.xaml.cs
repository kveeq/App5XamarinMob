using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App5XamarinMob.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5XamarinMob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProjectPage : ContentPage
    {
        Project project;
        public EditProjectPage(Project proj)
        {
            project = proj;
            InitializeComponent();
            FillFields();
        }

        public void FillFields()
        {
            ProjectNameTxt.Text = project.Name;
            ProjectDescriptionTxt.Text = project.Description;
            TelNumber1Txt.Text = project.TelephoneNumber1;
            TelNumber2Txt.Text = project.TelephoneNumber2;
            EmailTxt.Text = project.Email;
            AddressTxt.Text = project.Address;
        }

        private void ProjectDeleteNavBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Изменение", $"Вы точно хотите удалить {project.Name}?", "Ок");
        }

        private async void CancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void EditBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Изменение", $"Вы точно хотите изменить {project.Name}?", "Ок");
        }
    }
}