/*
 * Author: Carlan Waler
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldNotifyWhenPropertyChanged()
        {
            WarriorWater water = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
            Assert.PropertyChanged(water, "Ice", () => water.Ice = false);
        }

        [Fact]
        public void ShouldBeAnOrderItem()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water is IOrderItem);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water is Drink);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater water = new WarriorWater();
            water.Ice = false;
            Assert.False(water.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater water = new WarriorWater();
            water.Lemon = true;
            Assert.True(water.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater water = new WarriorWater();
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
        }

        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(0, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal((uint)0, water.Calories);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(true, true)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater water = new WarriorWater
            {
                Ice = includeIce,
                Lemon = includeLemon
            };
            if (!includeIce)
                Assert.Contains("Hold ice", water.SpecialInstructions);
            if (includeLemon)
                Assert.Contains("Add lemon", water.SpecialInstructions);
            if (includeIce && !includeLemon)
                Assert.Empty(water.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater water = new WarriorWater();
            water.Size = size;
            Assert.Equal(name, water.ToString());
        }

        [Fact]
        public void HasDescription()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal("It’s water. Just water.", water.Description);
        }
    }
}
