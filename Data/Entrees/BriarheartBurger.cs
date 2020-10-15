/*
* Author: Carlan Walker
* Class name: BriarheartBurger.cs
* Purpose: Class used to represent a Briarheart Burger
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent a Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// Event handler for when a property is changed
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item's price
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public override uint Calories => 743;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public override List<string> SpecialInstructions
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
        public bool Bun 
        {
            get => bun;
            set
            {
                if (bun != value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                bun = value;
            }
        }
        private bool bun = true;

        /// <summary>
        /// Whether the burger is to have ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                if (ketchup != value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                }
                ketchup = value;
            }
        }
        private bool ketchup = true;

        /// <summary>
        /// Whether the burger is to have mustard
        /// </summary>
        public bool Mustard 
        {
            get => mustard;
            set
            {
                if (value != mustard)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                mustard = value;
            }
        }
        private bool mustard = true;

        /// <summary>
        /// Whether the burger is to have pickles
        /// </summary>
        public bool Pickle
        {
            get => pickle; 
            set
            {
                if (value != pickle)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                pickle = value;
            }
        }
        private bool pickle = true;

        /// <summary>
        /// Whether the burger is to have cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese; 
            set
            {
                if (cheese != value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                cheese = value;
            }
        }
        private bool cheese = true;

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