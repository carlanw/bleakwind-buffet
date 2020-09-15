using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Base class representing common properties of drinks
    /// </summary>
    public abstract class Smoke : IOrderItem
    {
        /// <summary>
        /// The drink's size
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

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
