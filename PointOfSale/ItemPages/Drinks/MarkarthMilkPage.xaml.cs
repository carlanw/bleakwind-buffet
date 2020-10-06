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
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale.ItemPages.Drinks
{
    /// <summary>
    /// Interaction logic for MarkarthMilkPage.xaml
    /// </summary>
    public partial class MarkarthMilkPage : UserControl
    {
        public MarkarthMilkPage()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk drink = new MarkarthMilk();
            if ((bool)Small.IsChecked)
                drink.Size = BleakwindBuffet.Data.Enums.Size.Small;
            else if ((bool)Medium.IsChecked)
                drink.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            else if ((bool)Large.IsChecked)
                drink.Size = BleakwindBuffet.Data.Enums.Size.Large;

            drink.Ice = (bool)Ice.IsChecked;

            DependencyObject parent = this;
            while (!(parent is MainWindow) || parent is null)
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            MainWindow window = parent as MainWindow;
            Order order = window.MainGrid.Children[1] as Order;
            order.AddItem(drink);
        }
    }
}
