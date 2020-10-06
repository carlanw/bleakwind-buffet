using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Base class representing common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for when a property is changed
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The drink's size
        /// </summary>
        public virtual Size Size 
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        private Size size = Size.Small;

        /// <summary>
        /// The drink's price
        /// </summary>
        /// <value>
        /// In USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The drink's calorie count
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instuctions for the drink's preparation
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
