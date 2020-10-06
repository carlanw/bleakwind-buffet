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
    public partial class ThalmorTriplePage : UserControl
    {
        public ThalmorTriplePage()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            ThalmorTriple item = new ThalmorTriple
            {
                Bun = (bool)Bun.IsChecked,
                Ketchup = (bool)Ketchup.IsChecked,
                Mustard = (bool)Mustard.IsChecked,
                Pickle = (bool)Pickle.IsChecked,
                Cheese = (bool)Cheese.IsChecked,
                Tomato = (bool)Tomato.IsChecked,
                Lettuce = (bool)Lettuce.IsChecked,
                Mayo = (bool)Mayo.IsChecked,
                Bacon = (bool)Bacon.IsChecked,
                Egg = (bool)Egg.IsChecked
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
