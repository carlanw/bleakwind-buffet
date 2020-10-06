/*
* Author: Carlan Walker
* Class name: PhillyPoacher.cs
* Purpose: Class used to represent a Philly Poacher
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent a Philly Poacher
    /// </summary>
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// Event handler for when a property is changed
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item's price
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!this.Sirloin) instructions.Add("Hold sirloin");
                if (!this.Onion) instructions.Add("Hold onions");
                if (!this.Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Whether the sandwich is to have sirloin
        /// </summary>
        public bool Sirloin 
        {
            get => sirloin;
            set
            {
                if(value != sirloin)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                sirloin = value;
            }
        }
        private bool sirloin = true;

        /// <summary>
        /// Whether the sandwich is to have onion 
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                if(onion != value)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                onion = value;
            }
        }
        private bool onion = true;

        /// <summary>
        /// Whether the sandwich is to have a roll. 
        /// Really challenging the definition of a sandwich here.
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                if(roll != value)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                roll = value;
            }
        }
        private bool roll = true;

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
