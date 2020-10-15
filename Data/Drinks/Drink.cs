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
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The drink's size
        /// </summary>
        public abstract Size Size { get; set; }

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
