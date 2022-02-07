using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App5XamarinMob.Models;

namespace App5XamarinMob
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //App.db.SaveItem(new Project("111", "fmkrfmeofm", "0032-390392-23", "3920490-4904902", "imkwml", "fmkfmr"));
            //App.db.SaveItem(new Project("222", "fmkrfmeofm", "0032-390392-23", "3920490-4904902", "imkwml", "fmkfmr"));
            //App.db.SaveItem(new Project("333", "fmkrfmeofm", "0032-390392-23", "3920490-4904902", "imkwml", "fmkfmr"));
            UpdateList();
        }

        private async void ProjectsLstview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ProjectPage((Project)e.Item));
        }

        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Alert", "Tapped", "OK");
        //    //List.Projects.Add(new Project($"Проект{List.Projects.Count + 1}", $"Description{List.Projects.Count + 1}", "89047182492", "89047182402", "qwerty@mail.com", "Kazan"));
        //    //UpdateList();

        //    await Navigation.PushAsync(new AddProjectPage());
        //}

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            //List.Projects.Add(new Project($"Проект{List.Projects.Count + 1}", $"Description{List.Projects.Count + 1}", "89047182492", "89047182402", "qwerty@mail.com", "Kazan"));
            //UpdateList();

            await Navigation.PushAsync(new AddProjectPage());
        }

        void UpdateList()
        {
            ProjectsLstview.ItemsSource = null;
            ProjectsLstview.ItemsSource = List.Projects;
            //foreach (var item in App.db.GetProjects())
            //{
            //    DisplayAlert("fff", item.Name, "ok");
            //}
        }
    }
}