using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing a combo
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="e">Combo's entree</param>
        /// <param name="s">Combo's side</param>
        /// <param name="d">Combo's drink</param>
        public Combo(Entree e, Side s, Drink d)
        {
            Entree = e;
            Side = s;
            Drink = d;
        }

        /// <summary>
        /// Event handler for when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Checks if any of the combo's items have significan properties changed
        /// </summary>
        public void CheckIfComboItemChanged(object sender, PropertyChangedEventArgs args)
        {
            switch(args.PropertyName)
            {
                case "Price":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    break;
                case "Calories":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    break;
                case "SpecialInstructions":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    break;
            }

        }

        /// <summary>
        /// Entree included in the Combo
        /// </summary>
        public Entree Entree
        {
            get => entree;
            set
            {
                //entree.PropertyChanged -= CheckIfComboItemChanged;
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                entree.PropertyChanged += CheckIfComboItemChanged;
            }
        }
        private Entree entree;

        /// <summary>
        /// Drink included with the combo
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                //drink.PropertyChanged -= CheckIfComboItemChanged;
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                drink.PropertyChanged += CheckIfComboItemChanged;
            }
        }
        private Drink drink;

        /// <summary>
        /// Side included with the combo
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                //side.PropertyChanged -= CheckIfComboItemChanged;
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                side.PropertyChanged += CheckIfComboItemChanged;
            }
        }
        private Side side;

        /// <summary>
        /// Price of the combo
        /// </summary>
        public double Price => Entree.Price + Side.Price + Drink.Price - 1.00;

        /// <summary>
        /// Total calorie count of all items in the combo
        /// </summary>
        public uint Calories => Entree.Calories + Side.Calories + Drink.Calories;

        /// <summary>
        /// List of items in the combo and their special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                list.Add(Entree.ToString());
                list.AddRange(Entree.SpecialInstructions);
                list.Add(Side.ToString());
                list.AddRange(Side.SpecialInstructions);
                list.Add(Drink.ToString());
                list.AddRange(Drink.SpecialInstructions);
                return list;
            }
        }

        public string Description => "Any entree, side, and drink can be added to a combo for a $1 doscount.";
    }
}
