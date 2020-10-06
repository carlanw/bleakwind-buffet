using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Items.Entrees
{
    /// <summary>
    /// Interaction logic for PhillyPoacherPage.xaml
    /// </summary>
    public partial class PhillyPoacherPage : UserControl
    {
        public PhillyPoacherPage()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            PhillyPoacher item = new PhillyPoacher
            {
                Sirloin = (bool)Sirloin.IsChecked,
                Roll = (bool)Roll.IsChecked,
                Onion = (bool)Onion.IsChecked
            };

            DependencyObject parent = this;
            while (!(parent is MainWindow) || parent is null)
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            MainWindow window = parent as MainWindow;
            Order order = window.MainGrid.Children[1] as Order;
            order.AddItem(item);
        }
    }
}
