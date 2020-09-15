/*
* Author: Carlan Walker
* Class name: DragonBornWaffleFires.cs
* Purpose: Class used to represent Dragonborn Waffle Fries
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to prepresent Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// Price of the item
        /// </summary>
        public override double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 0.42;
                    case Size.Medium:
                        return 0.76;
                    case Size.Large:
                        return 0.96;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Item's calorie count
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 77;
                    case Size.Medium:
                        return 89;
                    case Size.Large:
                        return 100;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// List of instructions for item's preparation
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Gives the name of the item
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return this.Size + " Dragonborn Waffle Fries";
        }
    }
}
