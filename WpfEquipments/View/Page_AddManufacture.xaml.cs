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
using WpfEquipments.DAL.Model;

namespace WpfEquipments.View
{
    /// <summary>
    /// Interaction logic for Page_AddManufacture.xaml
    /// </summary>
  
    public partial class Page_AddManufacture : Page
    {
        private mcs db = new mcs();
        public Page_AddManufacture()
        {
            InitializeComponent();
        }

        private void btnAddManuf_Click(object sender, RoutedEventArgs e)
        {
            TablesManufacturer manuf = new TablesManufacturer();
            manuf.strName = tbName.Text;
            try
            {
                db.TablesManufacturer.Add(manuf);
                db.SaveChanges();

                MainWindow.mf.Source = new Uri("View/Page_Manufactures.xaml", UriKind.RelativeOrAbsolute);
            }
            catch (Exception ex)
            {

                ErrMessage.Content = ex.Message;
                ErrMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
           
        }
    }
}
