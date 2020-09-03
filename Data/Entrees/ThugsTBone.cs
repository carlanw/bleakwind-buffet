/*
* Author: Carlan Walker
* Class name: ThugsTBone.cs
* Purpose: Class used to represent Thug's T-Bone
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// The item's price
        /// </summary>
        public double Price => 6.44; // I wish

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Thug's T-Bone";
        }
    }
}
