using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App5XamarinMob.Models;

namespace App5XamarinMob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : TabbedPage
    {
        Project project;
        public static string Name;

        public ProjectPage(Project project)
        {
            this.project = project;
            Name = project.Name;
            InitializeComponent();
            FillInfo();
        }

        public void FillInfo()
        {
            ProjectDescriptionLbl.Text = project.Description;
            AddressLbl.Text = project.Address;
            EmailLbl.Text = project.Email;
            TelephoneNumberLbl2.Text = project.TelephoneNumber2;
            TelephoneNumberLbl1.Text = project.TelephoneNumber1;
        }

        private void ProjectEditNavBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditProjectPage());
        }
    }
}