using EquipmentRent3ISP9_7.HelperClass;
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
using System.Windows.Shapes;

namespace EquipmentRent3ISP9_7.Windows
{
    /// <summary>
    /// Логика взаимодействия для SaleList.xaml
    /// </summary>
    public partial class SaleList : Window
    {
        public SaleList()
        {
            InitializeComponent();
            LV_Sale.ItemsSource = HelperCl.Context.Sale.ToList();
        }
    }
}
