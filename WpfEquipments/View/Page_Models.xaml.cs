﻿using System;
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
using System.Xml.Linq;
using WpfEquipments.DAL.Model;

namespace WpfEquipments.View
{
    /// <summary>
    /// Interaction logic for Page_Models.xaml
    /// </summary>
    public partial class Page_Models : Page
    {
        private mcs db = new mcs();
        public Page_Models()
        {
            InitializeComponent();
            lvModels.ItemsSource = db.TablesModel
            //    .Select(s =>new
            //{
            //    s.intModelID,
            //    s.strName,
            //    strNameManuf = s.TablesManufacturer.strName,
            //    s.intSMCSFamilyID
            //})
            .ToList();
        }

        private void lvModels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TablesModel test = (TablesModel)((ListView)sender).SelectedItem; 
             dvData.DataContext = test; 
        }
    }
}
