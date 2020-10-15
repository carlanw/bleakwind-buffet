/*
* Author: Carlan Walker
* Class name: GardenOrcOmelette.cs
* Purpose: Class used to represent a Briarheart Burger
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent a Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// Event handler for when a property is changed
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item's price
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public override uint Calories => 404; // Calories not found

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!this.Broccoli) instructions.Add("Hold broccoli");
                if (!this.Mushrooms) instructions.Add("Hold mushrooms");
                if (!this.Tomato) instructions.Add("Hold tomato");
                if (!this.Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Whether the ommelette is to have Broccoli
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                if (value != broccoli)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                broccoli = value;
            }
        }
        private bool broccoli = true;

        /// <summary>
        /// Whether the ommelette is to have mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (value != mushrooms)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                mushrooms = value;
            }
        }
        private bool mushrooms = true;

        /// <summary>
        /// Whether the omelette is to have tomato
        /// </summary>
        public bool Tomato 
        {
            get => tomato;
            set
            {
                if (value != mushrooms)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                tomato = value;
            }
        }
        private bool tomato = true;

        /// <summary>
        /// Whether the omelette is to have cheddar
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (value != cheddar)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                cheddar = value;
            }
        }
        private bool cheddar = true;

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
