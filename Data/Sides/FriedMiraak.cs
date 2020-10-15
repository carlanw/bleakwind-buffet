/*
* Author: Carlan Walker
* Class name: FriedMiraak.cs
* Purpose: Class used to represent Fried Miraak
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to represent Fried Miraak
    /// </summary>
    public class FriedMiraak : Side
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
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    case Size.Large:
                        return 2.88;
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
                        return 151;
                    case Size.Medium:
                        return 236;
                    case Size.Large:
                        return 306;
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
            return this.Size + " Fried Miraak";
        }
    }
}
