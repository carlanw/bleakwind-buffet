/*
* Author: Carlan Walker
* Class name: VokunSalad.cs
* Purpose: Class used to represent Vokun Salad
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    class VokunSalad
    {
        /// <summary>
        /// Size of the item
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Price of the item
        /// </summary>
        public double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 0.93;
                    case Size.Medium:
                        return 1.28;
                    case Size.Large:
                        return 1.82;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Item's calorie count
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 41;
                    case Size.Medium:
                        return 52;
                    case Size.Large:
                        return 73;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Gives the name of the item
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return this.Size + " Vokun Salad";
        }
    }
}
