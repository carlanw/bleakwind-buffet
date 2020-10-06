using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Base class for entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for when a property is changed
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The entree's price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The entree's calorie count
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the entree's preparation
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
