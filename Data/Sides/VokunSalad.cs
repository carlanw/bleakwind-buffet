/*
* Author: Carlan Walker
* Class name: VokunSalad.cs
* Purpose: Class used to represent Vokun Salad
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to represent a Vokun Salad
    /// </summary>
    public class VokunSalad : Side
    {
        /// <summary>
        /// Event handleer for when a property is changed
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The side's size
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                if (value != size)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                size = value;
            }
        }
        private Size size = Size.Small;

        /// <summary>
        /// Price of the item
        /// </summary>
        public override double Price
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 0.93;
                    case Size.Medium:
                        return 1.28;
                    case Size.Large:
                        return 1.82;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Item's calorie count
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (this.Size)
                {
                    case Size.Small:
                        return 41;
                    case Size.Medium:
                        return 52;
                    case Size.Large:
                        return 73;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// List of instructions for item's preparation
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Gives the name of the item
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return this.Size + " Vokun Salad";
        }
    }
}
