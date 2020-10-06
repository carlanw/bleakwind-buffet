/*
* Author: Carlan Walker
* Class name: DoubleDraugr.cs
* Purpose: Class used to represent a Double Draugr
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent a Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree
    {
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item's price
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public override uint Calories => 843;

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
                if (!this.Tomato) instructions.Add("Hold tomato");
                if (!this.Lettuce) instructions.Add("Hold lettuce");
                if (!this.Mayo) instructions.Add("Hold mayo");
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                cheese = value;
            }
        }
        private bool cheese = true;

        /// <summary>
        /// Whether the burger is to have tomato
        /// </summary>
        public bool Tomato 
        {
            get => tomato;
            set
            {
                if(tomato != value)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                tomato = value;
            }
        }
        public bool tomato = true;

        /// <summary>
        /// Whether the burger is to have lettuce
        /// </summary>
        public bool Lettuce 
        {
            get => lettuce;
            set
            {
                if(tomato != value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                }
                lettuce = value;
            }
        }
        private bool lettuce = true;

        /// <summary>
        /// Whether the burger is to have mayo
        /// </summary>
        public bool Mayo
        { 
            get => mayo;
            set
            {
                if(mayo != value)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                mayo = value;
            }
        }
        private bool mayo = true;

        /// <summary>
        /// Gives the name of the entree
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
