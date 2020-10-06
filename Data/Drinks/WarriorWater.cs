/*
* Author: Carlan Walker
* Class name: WarriorWater.cs
* Purpose: Class used to represent Warrior Water
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent water
    /// </summary>
    public class WarriorWater : Drink
    {
        /// <summary>
        /// Event handler for when a property is changed
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Drink's calorie count
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Whether the drink is to have ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }
        private bool ice = true;

        /// <summary>
        /// Whether the drink is to have lemon
        /// </summary>
        public bool Lemon 
        {
            get => lemon;
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        } 
        private bool lemon = false;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!this.Ice) instructions.Add("Hold ice");
                if (this.Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Gives the name of the drink
        /// </summary>
        /// <returns>The name of the drink</returns>
        public override string ToString()
        {
            return this.Size + " Warrior Water";
        }
    }
}
