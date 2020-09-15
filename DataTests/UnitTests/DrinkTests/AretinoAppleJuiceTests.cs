/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeAnOrderItem()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.True(juice is IOrderItem);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.True(juice is Smoke);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.False(juice.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.Equal(Size.Small, juice.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Ice = true;
            Assert.True(juice.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Size = Size.Medium;
            Assert.Equal(Size.Medium, juice.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal(price, juice.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal(cal, juice.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Ice = includeIce;
            if(includeIce)
                Assert.Contains("Add ice", juice.SpecialInstructions);
            else
                Assert.Empty(juice.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal(name, juice.ToString());
        }
    }
}