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
        /// Current order number
        /// </summary>
        private int ordernumber = 1;

        /// <summary>
        /// Price of all items prior to sales tax
        /// </summary>
        private double subtotal { get; set; } = 0;

        /// <summary>
        /// Sales tax rate as a percentage
        /// Declared for ease of changing
        /// </summary>
        private double salestaxrate = 8.95;

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
            ordernumber += 1;
            items = new List<IOrderItem>();
            prices = new List<double>();
            subtotal = 0;

            OrderNumber.Text = ordernumber.ToString();

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
            items.Add(item);
            prices.Add(item.Price);
            subtotal += item.Price;

            Items.Text += (item.ToString() + '\n');
            Prices.Text += (item.Price.ToString("C2") + '\n');

            Subtotal.Text = subtotal.ToString("C2");
            Tax.Text = (subtotal * (salestaxrate/100)).ToString("C2");
            GrandTotal.Text = (subtotal * ((salestaxrate / 100) + 1)).ToString("C2");
        }
    }
}
