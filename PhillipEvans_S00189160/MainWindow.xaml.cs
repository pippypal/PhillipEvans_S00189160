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

namespace PhillipEvans_S00189160
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Phones
                        select p.Name;

            var phones = query.ToList();

            lbxPhone.ItemsSource = query.ToList();

            //lbxPhone.SelectedItem = 0;

            //string phoneName = phones.ElementAt(0);

            //var phone = from p in db.Phones
            //            where p.Name == phoneName
            //            select p.Price;

            //txtPrice.Text = String.Format("{0:c}",phone);
        }

        private void lbxPhone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selected = lbxPhone.SelectedItem as Phone;
            
            if (selected != null)
            {
                //var query = from p in db.Phones
                //            select p.Price;
                ////txtPrice.Text = query.ToString();
                ///
                string phoneCost = $"Cost >> {selected.Price:C}";
                txtPrice.Text = phoneCost
               txtPrice.Text = selected.Price.ToString();
            }
        }
    }
}
