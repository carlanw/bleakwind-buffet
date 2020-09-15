using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Base class for sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The side's size
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

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
