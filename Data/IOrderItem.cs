using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interfect implemented by every orderable item
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The item's price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The item's calorie count
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions for the item's preparation
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// A description of the item
        /// </summary>
        string Description { get; }
    }
}
