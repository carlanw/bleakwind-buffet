using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using System.Runtime.CompilerServices;
using System.Linq;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gives a list of entrees
        /// </summary>
        /// <returns>Enumerable list of all available entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            return list;
        }

        /// <summary>
        /// Gives a list of sides
        /// </summary>
        /// <returns>Enumerable list of all available sides in all sizes</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new DragonbornWaffleFries());
            list.Add(new FriedMiraak());
            list.Add(new MadOtarGrits());
            list.Add(new VokunSalad());

            list.Add(new DragonbornWaffleFries() { Size = Size.Medium });
            list.Add(new FriedMiraak() { Size = Size.Medium });
            list.Add(new MadOtarGrits() { Size = Size.Medium });
            list.Add(new VokunSalad() { Size = Size.Medium });

            list.Add(new DragonbornWaffleFries() { Size = Size.Large });
            list.Add(new FriedMiraak() { Size = Size.Large });
            list.Add(new MadOtarGrits() { Size = Size.Large });
            list.Add(new VokunSalad() { Size = Size.Large });

            return list;
        }

        /// <summary>
        /// Gives a list of sides
        /// </summary>
        /// <returns>Enumerable list of all available sides without repeats</returns>
        public static IEnumerable<IOrderItem> SidesShort()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new DragonbornWaffleFries());
            list.Add(new FriedMiraak());
            list.Add(new MadOtarGrits());
            list.Add(new VokunSalad());

            return list;
        }

        /// <summary>
        /// Gives a list of drinks
        /// </summary>
        /// <returns>Enumerable list of all available drinks in all sizes and flavors</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new AretinoAppleJuice());
            list.Add(new CandlehearthCoffee());
            list.Add(new MarkarthMilk());
            list.Add(new SailorSoda() {Flavor = SodaFlavor.Blackberry });
            list.Add(new SailorSoda() {Flavor = SodaFlavor.Cherry });
            list.Add(new SailorSoda() {Flavor = SodaFlavor.Grapefruit });
            list.Add(new SailorSoda() {Flavor = SodaFlavor.Lemon });
            list.Add(new SailorSoda() {Flavor = SodaFlavor.Peach });
            list.Add(new SailorSoda() {Flavor = SodaFlavor.Watermelon });
            list.Add(new WarriorWater());

            list.Add(new AretinoAppleJuice() { Size = Size.Medium });
            list.Add(new CandlehearthCoffee() { Size = Size.Medium });
            list.Add(new MarkarthMilk() { Size = Size.Medium });
            list.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Blackberry });
            list.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Cherry });
            list.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit });
            list.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Lemon });
            list.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Peach });
            list.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Watermelon });
            list.Add(new WarriorWater() { Size = Size.Medium });

            list.Add(new AretinoAppleJuice() { Size = Size.Large });
            list.Add(new CandlehearthCoffee() { Size = Size.Large });
            list.Add(new MarkarthMilk() { Size = Size.Large });
            list.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Blackberry });
            list.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Cherry });
            list.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Grapefruit });
            list.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Lemon });
            list.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Peach });
            list.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Watermelon });
            list.Add(new WarriorWater() { Size = Size.Large });

            return list;
        }

        /// <summary>
        /// Gives a list of drinks
        /// </summary>
        /// <returns>Enumerable list of all available drinks without repeats</returns>
        public static IEnumerable<IOrderItem> DrinksShort()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            list.Add(new AretinoAppleJuice());
            list.Add(new CandlehearthCoffee());
            list.Add(new MarkarthMilk());
            list.Add(new SailorSoda());
            list.Add(new WarriorWater());

            return list;
        }

            public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.Entrees());
            list.AddRange(Menu.Sides());
            list.AddRange(Menu.Drinks());
            return list;
        }

        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string[] types)
        {
            List<IOrderItem> list = new List<IOrderItem>();

            if (types is null || types.Count() == 0)
                return items;
                    
            foreach(IOrderItem i in items)
            {
                if (types.Contains("Entree") && i is Entree)
                    list.Add(i);
                if (types.Contains("Side") && i is Side)
                    list.Add(i);
                if (types.Contains("Drink") && i is Drink)
                    list.Add(i);
            }

            return list;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            List<IOrderItem> list = new List<IOrderItem>();

            if (min is null && max is null)
                return items;
            else if ((min is null && max != null))
                min = 0;
            else if ((min != null && max == null))
                max = 10;

            foreach (IOrderItem i in items)
            {
                if (i.Price >= min && i.Price <= max)
                    list.Add(i);
            }

            return list;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            List<IOrderItem> list = new List<IOrderItem>();

            if (min is null && max is null)
                return items;
            else if ((min is null && max != null))
                min = 0;
            else if ((min != null && max == null))
                max = 1000;

            foreach (IOrderItem i in items)
            {
                if (i.Calories >= min && i.Calories <= max)
                    list.Add(i);
            }

            return list;
        }
    }
}
