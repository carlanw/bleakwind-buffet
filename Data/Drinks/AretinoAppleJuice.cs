/*
* Author: Carlan Walker
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent Aretino Apple Juice
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        // <summary>
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
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    case Size.Large:
                        return 1.01;
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
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
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
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (this.Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Gives the name of the drink
        /// </summary>
        /// <returns>The name of the drink</returns>
        public override string ToString()
        {
            return this.Size + " Aretino Apple Juice";
        }
    }
}
