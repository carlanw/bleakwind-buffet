/*
* Author: Carlan Walker
* Class name: SmokehouseSkeleton.cs
* Purpose: Class used to represent a Smokehouse Skeleton
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent a Smokehouse Skeleton breakfast combo
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// 
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The item's price
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// The item's calorie count
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Special instructions for the making of this item
        /// </summary>
        public override List<string> SpecialInstructions
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
        public bool SausageLink
        {
            get => sausagelink;
            set
            {
                if(sausagelink != value)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                sausagelink = value;
            }
        }
        private bool sausagelink = true;

        /// <summary>
        /// Whether the combo is to have eggs
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                if(value != egg)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                egg = value;
            }
        }
        private bool egg = true;

        /// <summary>
        /// Whether the combo is to have hash browns
        /// </summary>
        public bool HashBrowns
        {
            get => hashbrowns;
            set
            {
                if(value != hashbrowns)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                hashbrowns = value;
            }
        }
        private bool hashbrowns = true;

        /// <summary>
        /// Whether the ccombo is to have pancakes
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                if(pancake != value)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                pancake = value;
            }
        }
        private bool pancake = true;

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
