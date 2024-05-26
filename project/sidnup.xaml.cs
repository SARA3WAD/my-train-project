using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project
{
    /// <summary>
    /// Interaction logic for sidnup.xaml
    /// </summary>
    public partial class sidnup : Page
    {
        projectEntities db = new projectEntities();
        public sidnup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signin ss = new signin();
            this.NavigationService.Navigate(ss);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            project mm = new project();
            if(t1.Text == ""|| t2.Text == "" || t3.Text =="")
            {
                MessageBox.Show("Please fill the textboxes");
            }
            else
            {
                mm.username = t1.Text;
                mm.pass_word = t2.Text;
                db.projects.Add(mm);
                db.SaveChanges();
                MessageBox.Show("Data saved successfull");
                signisn ll = new signin();
                this.NavigationService.Navigate(ll);

            }
        }
    }
}
