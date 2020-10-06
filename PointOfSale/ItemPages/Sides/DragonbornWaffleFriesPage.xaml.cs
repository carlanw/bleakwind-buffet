using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.Items.Sides
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFriesPage.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesPage : UserControl
    {
        public DragonbornWaffleFriesPage()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries item = new DragonbornWaffleFries();

            if ((bool)Small.IsChecked)
                item.Size = BleakwindBuffet.Data.Enums.Size.Small;
            else if ((bool)Medium.IsChecked)
                item.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            else if ((bool)Large.IsChecked)
                item.Size = BleakwindBuffet.Data.Enums.Size.Large;

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
