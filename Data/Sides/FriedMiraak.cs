﻿/*
* Author: Carlan Walker
* Class name: FriedMiraak.cs
* Purpose: Class used to represent Fried Miraak
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    class FriedMiraak
    {
        /// <summary>
        /// Size of the item
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Price of the item
        /// </summary>
        public double Price
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
        public uint Calories
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
        /// Gives the name of the item
        /// </summary>
        /// <returns>The name of the item</returns>
        public override string ToString()
        {
            return this.Size + " Fried Miraak";
        }
    }
}
