using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing an order
    /// </summary>
    public class Order : List<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for when the collection is changed
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Number for the next order
        /// </summary>
        private static uint nextOrderNumber = 1;

        /// <summary>
        /// Constructor
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// Unique order number
        /// </summary>
        public uint Number;

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item">Item to be added</param>
        public new void Add(IOrderItem item)
        {
            item.PropertyChanged += CheckIfOrderItemChanged;
            base.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item">Item to be removed</param>
        public new void Remove(IOrderItem item)
        {
            base.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Checks if any of the order's items have significan properties changed
        /// </summary>
        private void CheckIfOrderItemChanged(object sender, PropertyChangedEventArgs args)
        {
            switch (args.PropertyName)
            {
                case "Price":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                    break;
                case "Calories":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    break;
            }
        }

        /// <summary>
        /// Sales tax rate for this order
        /// </summary>
        public double SalesTaxRate
        {
            get => salestaxrate;
            set
            {
                salestaxrate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
            }
        }
        private double salestaxrate = 0.12;

        /// <summary>
        /// Sum of the prices of every menu item
        /// </summary>
        public double Subtotal
        {
            get
            {
                double sum = 0;
                foreach(IOrderItem item in this)
                    sum += item.Price;
                return sum;
            }
        }

        /// <summary>
        /// Sales tax bsed on subtotal
        /// </summary>
        public double Tax => Subtotal * SalesTaxRate;

        /// <summary>
        /// Grand total price, sum of subtotal and tax
        /// </summary>
        public double Total => Subtotal + Tax;

        /// <summary>
        /// Total calorie count of the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint sum = 0;
                foreach (IOrderItem item in this)
                    sum += item.Calories;
                return sum;
            }
        }
    }
}
