using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
            this.DataContext = new BleakwindBuffet.Data.Order();
        }

        /// <summary>
        /// Clears the order screen and starts a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new BleakwindBuffet.Data.Order();
        }

        /// <summary>
        /// Helper function to add items to the order
        /// </summary>
        /// <param name="item">Item to be added to order</param>
        public void AddItem(IOrderItem item)
        {
            if(DataContext is BleakwindBuffet.Data.Order orderObj)
            {
                orderObj.Add(item);
            }
        }
    }
}
