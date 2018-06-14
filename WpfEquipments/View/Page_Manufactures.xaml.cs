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
    /// Interaction logic for Page_Manufactures.xaml
    /// </summary>
    public partial class Page_Manufactures : Page
    {
        private mcs db = new mcs();
        public Page_Manufactures()
        {
            InitializeComponent();

            lvManufactures.ItemsSource = 
                db.TablesManufacturer.OrderByDescending(o=>o.intManufacturerID).ToList();
        }
    }
}
