/*
* Author: Carlan Walker
* Class name: ThalmorTriple.cs
* Purpose: Class used to represent a Thalmor Triple
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// The item's price
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public uint Calories => 943;

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
                if (!this.Tomato) instructions.Add("Hold tomato");
                if (!this.Lettuce) instructions.Add("Hold lettuce");
                if (!this.Mayo) instructions.Add("Hold mayo");
                if (!this.Bacon) instructions.Add("Hold bacon");
                if (!this.Egg) instructions.Add("Hold egg");
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
        /// Whether the burger is to have tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Whether the burger is to have an egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gives the name of the entree
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
