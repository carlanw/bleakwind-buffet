/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldNotifyWhenPropertyChanged()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
            Assert.PropertyChanged(side, "Size", () => side.Size = Size.Large);
        }

        [Fact]
        public void ShouldBeAnOrderItem()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.True(side is IOrderItem);
        }

        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.True(side is Side);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = Size.Medium;
            Assert.Equal(Size.Medium, side.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}