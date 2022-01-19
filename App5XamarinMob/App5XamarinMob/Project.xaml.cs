using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
        }
    }
}