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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class GardenOrcOmelettePage : UserControl
    {
        public GardenOrcOmelettePage()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette item = new GardenOrcOmelette
            {
                Broccoli = (bool)Broccoli.IsChecked,
                Mushrooms = (bool)Mushrooms.IsChecked,
                Tomato = (bool)Tomato.IsChecked,
                Cheddar = (bool)Cheddar.IsChecked
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
