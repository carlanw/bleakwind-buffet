﻿/*
* Author: Carlan Walker
* Class name: PhillyPoacher.cs
* Purpose: Class used to represent a Philly Poacher
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// The item's price
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!this.Sirloin) instructions.Add("Hold sirloin");
                if (!this.Onion) instructions.Add("Hold onion");
                if (!this.Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Whether the sandwich is to have sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Whether the sandwich is to have onion 
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Whether the sandwich is to have a roll. 
        /// Really challenging the definition of a sandwich here.
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Gives the name of the entree
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
