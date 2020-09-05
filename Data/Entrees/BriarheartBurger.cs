/*
* Author: Carlan Walker
* Class name: BriarheartBurger.cs
* Purpose: Class used to represent a Briarheart Burger
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent a Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// The item's price
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public uint Calories => 743;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get 
            {
                List<string> instructions = new List<string>();
                if (!this.Bun) instructions.Add("Hold bun");
                if (!this.Ketchup) instructions.Add("Hold ketchup");
                if (!this.Mustard) instructions.Add("Hold mustard");
                if (!this.Pickle) instructions.Add("Hold pickle");
                if (!this.Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }


        /// <summary>
        /// Whether the burger is to have a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Gives the name of the entree
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}