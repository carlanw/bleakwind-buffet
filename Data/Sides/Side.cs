using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Base class for sides
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    { 
        /// <summary>
        /// Event handler for when a property changes
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The side's size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// The side's price
        /// </summary>
        /// <value>
        /// In USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The side's calorie count
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instuctions for the side's preparation
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
