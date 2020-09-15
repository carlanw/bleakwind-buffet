using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldReturnEveryEntree()
        {
            Assert.Collection(Menu.Entrees(),
                item => Assert.Equal(new BriarheartBurger().ToString(), item.ToString()),
                item => Assert.Equal(new DoubleDraugr().ToString(), item.ToString()),
                item => Assert.Equal(new GardenOrcOmelette().ToString(), item.ToString()),
                item => Assert.Equal(new PhillyPoacher().ToString(), item.ToString()),
                item => Assert.Equal(new SmokehouseSkeleton().ToString(), item.ToString()),
                item => Assert.Equal(new ThalmorTriple().ToString(), item.ToString()),
                item => Assert.Equal(new ThugsTBone().ToString(), item.ToString())
                );
        }

        [Fact]
        public void ShouldReturnEverySide()
        {
            Assert.Collection(Menu.Sides(),
                item => Assert.Equal(new DragonbornWaffleFries().ToString(),  item.ToString()),
                item => Assert.Equal(new FriedMiraak().ToString(),  item.ToString()),
                item => Assert.Equal(new MadOtarGrits().ToString(),  item.ToString()),
                item => Assert.Equal(new VokunSalad().ToString(),  item.ToString()),
                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Large }.ToString(), item.ToString())
                );
        }

        [Fact]
        public void ShouldRetrunEveryDrink()
        {
            Assert.Collection(Menu.Drinks(), 
                item => Assert.Equal(new AretinoAppleJuice().ToString(),  item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee().ToString(),  item.ToString()),
                item => Assert.Equal(new MarkarthMilk().ToString(),  item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater().ToString(),  item.ToString()),
                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Blackberry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Cherry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Lemon }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Peach }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Watermelon }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Blackberry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Cherry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Grapefruit }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Lemon }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Peach }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Watermelon }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Large }.ToString(), item.ToString())
                );
        }

        [Fact]
        public void ShouldReturnFullMenu()
        {
            Assert.Collection(Menu.FullMenu(), 
                item => Assert.Equal(new BriarheartBurger().ToString(),  item.ToString()),
                item => Assert.Equal(new DoubleDraugr().ToString(),  item.ToString()),
                item => Assert.Equal(new GardenOrcOmelette().ToString(),  item.ToString()),
                item => Assert.Equal(new PhillyPoacher().ToString(),  item.ToString()),
                item => Assert.Equal(new SmokehouseSkeleton().ToString(),  item.ToString()),
                item => Assert.Equal(new ThalmorTriple().ToString(),  item.ToString()),
                item => Assert.Equal(new ThugsTBone().ToString(),  item.ToString()),
                item => Assert.Equal(new DragonbornWaffleFries().ToString(),  item.ToString()),
                item => Assert.Equal(new FriedMiraak().ToString(),  item.ToString()),
                item => Assert.Equal(new MadOtarGrits().ToString(),  item.ToString()),
                item => Assert.Equal(new VokunSalad().ToString(),  item.ToString()),
                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new DragonbornWaffleFries() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new FriedMiraak() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MadOtarGrits() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new VokunSalad() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new AretinoAppleJuice().ToString(),  item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee().ToString(),  item.ToString()),
                item => Assert.Equal(new MarkarthMilk().ToString(),  item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Blackberry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Cherry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Grapefruit }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Lemon }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Peach }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Flavor = SodaFlavor.Watermelon }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater().ToString(),  item.ToString()),
                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Blackberry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Cherry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Lemon }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Peach }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Watermelon }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Medium }.ToString(), item.ToString()),
                item => Assert.Equal(new AretinoAppleJuice() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new CandlehearthCoffee() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new MarkarthMilk() { Size = Size.Large }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Blackberry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Cherry }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Grapefruit }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Lemon }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Peach }.ToString(), item.ToString()),
                item => Assert.Equal(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Watermelon }.ToString(), item.ToString()),
                item => Assert.Equal(new WarriorWater() { Size = Size.Large }.ToString(), item.ToString())
                );
        }
    }
}
