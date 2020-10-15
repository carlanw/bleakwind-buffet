using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeOrderItem()
        {
            Combo c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void ShouldNotifyWhenPropertyChanged()
        {
            Combo c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);

            // change entree
            Assert.PropertyChanged(c, "Entree", () => c.Entree = new GardenOrcOmelette());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "Price", () => c.Entree = new GardenOrcOmelette());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "Calories", () => c.Entree = new GardenOrcOmelette());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "SpecialInstructions", () => c.Entree = new GardenOrcOmelette());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());

            // change side
            Assert.PropertyChanged(c, "Side", () => c.Side = new VokunSalad());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "Price", () => c.Side = new VokunSalad());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "Calories", () => c.Side = new VokunSalad());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "SpecialInstructions", () => c.Side = new VokunSalad());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());

            // change drink
            Assert.PropertyChanged(c, "Drink", () => c.Drink = new AretinoAppleJuice());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "Price", () => c.Drink = new AretinoAppleJuice());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "Calories", () => c.Drink = new AretinoAppleJuice());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "SpecialInstructions", () => c.Drink = new AretinoAppleJuice());
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());

            // change an item's properties
            Assert.PropertyChanged(c, "Price", () => c.Side.Size = Data.Enums.Size.Medium);
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "Calories", () => c.Side.Size = Data.Enums.Size.Medium);
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.PropertyChanged(c, "SpecialInstructions", () => c.Side.Size = Data.Enums.Size.Medium);
            c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
        }

        [Fact]
        public void GivesCorrectPrice()
        {
            Combo c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.Equal(7.16, c.Price);
        }

        [Fact]
        public void GivesCorrectCalorieCount()
        {
            Combo c = new Combo(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            Assert.Equal((uint)937, c.Calories);
        }
    }
}
