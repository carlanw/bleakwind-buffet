using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.ItemPages.Drinks
{
    /// <summary>
    /// Interaction logic for WarriorWaterPage.xaml
    /// </summary>
    public partial class WarriorWaterPage : UserControl
    {
        public WarriorWaterPage()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater drink = new WarriorWater();
            if ((bool)Small.IsChecked)
                drink.Size = BleakwindBuffet.Data.Enums.Size.Small;
            else if ((bool)Medium.IsChecked)
                drink.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            else if ((bool)Large.IsChecked)
                drink.Size = BleakwindBuffet.Data.Enums.Size.Large;

            drink.Ice = (bool)Ice.IsChecked;
            drink.Lemon = (bool)Lemon.IsChecked;

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
