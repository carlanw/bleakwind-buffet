/*
* Author: Carlan Walker
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to represent Candlehearth Coffee
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Drink's calorie count
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Whether the drink is to have ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Whether the coffee is to have cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether the coffee is to be decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (this.Ice) instructions.Add("Add ice");
                if (this.RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Gives the name of the drink
        /// </summary>
        /// <returns>The name of the drink</returns>
        public override string ToString()
        {
            if (!this.Decaf)
                return this.Size + " Candlehearth Coffee";
            else
                return this.Size + " Decaf Candlehearth Coffee";
        }
    }
}
