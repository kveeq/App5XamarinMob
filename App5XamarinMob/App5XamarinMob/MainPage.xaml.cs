using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5XamarinMob
{
    public partial class MainPage : ContentPage
    {
        public List<Project> Projects;
        public MainPage()
        {
            InitializeComponent();
            Projects = new List<Project>() { new Project("Проект1"), new Project("Проект2"), new Project("Проект3"), new Project("Проект4"), new Project("Проект5"), new Project("Проект6") };
            //ProjectsLstview.ItemsSource = Projects;
            UpdateList();
        }

        private async void ProjectsLstview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ProjectPage((Project)e.Item));
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("asdasd", "asdasd", "asdasd");
            Projects.Add(new Project($"Проект {Projects.Count + 1}"));
            UpdateList();
        }


        void UpdateList()
        {
            ProjectsLstview.ItemsSource = Projects;

        }
    }

    public class Project
    {
        public Project(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}