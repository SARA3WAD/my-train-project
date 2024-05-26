using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        projectEntities db = new projectEntities();
        public profile()
        {
            InitializeComponent();
            data.ItemsSource = db.projects.ToList();
        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            project ss = new project();
            ss.username = text1.Text;
            ss.pass_word = text2.Text;
            ss.gender = text3.Text;
            ss.city = text4.Text;
            ss.phone = int.Parse(text5.Text);
            db.projects.Add(ss);
            db.SaveChanges();
            MessageBox.Show("successfull");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            project yy = new project();
            yy = db.projects.Remove(db.projects.First(x => x.username == text1.Text));
            db.SaveChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            data.ItemsSource = db.projects.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            project mm = new project();
            mm = db.projects.First(x =>x.username == text1.Text);
            mm.gender = text3.Text;
            mm.city = text4.Text;
            mm.phone = int.Parse(text5.Text);s
            db.projects.AddOrUpdate(mm);

        }
    }
}
