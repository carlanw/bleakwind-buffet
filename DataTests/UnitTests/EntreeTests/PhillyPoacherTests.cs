/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldNotifyWhenPropertyChanged()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(sandwich);
            Assert.PropertyChanged(sandwich, "Roll", () => sandwich.Roll = false);
        }

        [Fact]
        public void ShouldBeAnOrderItem()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.True(sandwich is IOrderItem);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.True(sandwich is Entree);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.True(sandwich.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.True(sandwich.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.True(sandwich.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            sandwich.Sirloin = false;
            Assert.False(sandwich.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            sandwich.Onion = false;
            Assert.False(sandwich.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            sandwich.Roll = false;
            Assert.False(sandwich.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.Equal(7.23, sandwich.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.Equal((uint)784, sandwich.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher sandwich = new PhillyPoacher
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            };
            if (!includeSirloin)
                Assert.Contains("Hold sirloin", sandwich.SpecialInstructions);
            if (!includeOnion)
                Assert.Contains("Hold onions", sandwich.SpecialInstructions);
            if (!includeRoll)
                Assert.Contains("Hold roll", sandwich.SpecialInstructions);
            if (includeRoll && includeOnion && includeSirloin)
                Assert.Empty(sandwich.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher sandwich = new PhillyPoacher();
            Assert.Equal("Philly Poacher", sandwich.ToString());
        }
    }
}