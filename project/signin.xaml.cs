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
    /// Interaction logic for signin.xaml
    /// </summary>
    public partial class signin : Page
    {
        projectEntities db = new projectEntities();
        public signin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            project mm = new project();
            mm = db.projects.FirstOrDefault(x => x.username == user_text.Text && x.pass_word == pass.Text);
            if(mm != null)
            {
                MessageBox.Show("signin successfull");
                profile pp = new profile();
                this.NavigationService.Navigate(pp);
            }
            else
            {
                MessageBox.Show("Error please try again");
            }
        }

        private void Button_Click(object sender, object e)
        {

        }
    }
}
