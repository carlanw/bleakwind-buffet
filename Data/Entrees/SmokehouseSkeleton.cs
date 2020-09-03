/*
* Author: Carlan Walker
* Class name: SmokehouseSkeleton.cs
* Purpose: Class used to represent a Smokehouse Skeleton
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// The item's price
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!this.SausageLink) instructions.Add("Hold sausage");
                if (!this.Egg) instructions.Add("Hold eggs");
                if (!this.HashBrowns) instructions.Add("Hold hash browns");
                if (!this.Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Whether the combo is to have sausage links
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Whether the combo is to have eggs
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Whether the combo is to have hash browns
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Whether the ccombo is to have pancakes
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Gives the name of the dish
        /// </summary>
        /// <returns>The name of the dish</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
