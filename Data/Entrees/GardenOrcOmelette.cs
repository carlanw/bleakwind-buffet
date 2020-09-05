/*
* Author: Carlan Walker
* Class name: GardenOrcOmelette.cs
* Purpose: Class used to represent a Briarheart Burger
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent a Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// The item's price
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public uint Calories => 404; // Calories not found

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!this.Broccoli) instructions.Add("Hold broccoli");
                if (!this.Mushrooms) instructions.Add("Hold mushrooms");
                if (!this.Tomato) instructions.Add("Hold tomato");
                if (!this.Cheddar) instructions.Add("Hold Cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Whether the ommelette is to have Broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Whether the ommelette is to have mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Whether the omelette is to have tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Whether the omelette is to have cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Returns the name of the dish
        /// </summary>
        /// <returns>The name of the dish</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
