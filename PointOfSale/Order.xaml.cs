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
        /// <summary>
        /// Object to represent the order items
        /// </summary>
        public BleakwindBuffet.Data.Order OrderObj = new BleakwindBuffet.Data.Order();

        /// <summary>
        /// List of items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        private List<double> prices = new List<double>();

        public Order()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the order screen and starts a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextOrderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderObj = new BleakwindBuffet.Data.Order();

            OrderNumber.Text = OrderObj.Number.ToString();

            Items.Text = "";
            Prices.Text = "";

            Subtotal.Text = "$0.00";
            Tax.Text = "$0.00";
            GrandTotal.Text = "$0.00";
        }

        /// <summary>
        /// Helper function to add items to the order
        /// </summary>
        /// <param name="item">Item to be added to order</param>
        public void AddItem(IOrderItem item)
        {
            OrderObj.Add(item);

            Items.Text += (item.ToString() + '\n');
            Prices.Text += (item.Price.ToString("C2") + '\n');

            foreach(string s in item.SpecialInstructions)
            {
                Items.Text += (" - " + s + '\n');
                Prices.Text += '\n';
            }

            Subtotal.Text = OrderObj.Subtotal.ToString("C2");
            Tax.Text = OrderObj.Tax.ToString("C2");
            GrandTotal.Text = OrderObj.Total.ToString("C2");
        }
    }
}
