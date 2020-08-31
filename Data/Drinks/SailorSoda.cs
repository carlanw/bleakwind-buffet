/*
* Author: Carlan Walker
* Class name: SailorSoda.cs
* Purpose: Class used to represent a Sailor Soda
*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks
{
    class SailorSoda
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
                switch(this.Size)
                {
                    case Size.Small:
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Whether the drink is to have ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!this.Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;


        /// <summary>
        /// Gives the name of the drink
        /// </summary>
        /// <returns>The name of the drink</returns>
        public override string ToString()
        {
            return this.Size + " " + this.Flavor + " Sailor Soda";
        }
    }
}
