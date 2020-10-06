/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldNotifyWhenPropertyChanged()
        {
            ThugsTBone steak = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(steak);
            // no properties to change
        }

        [Fact]
        public void ShouldBeAnOrderItem()
        {
            ThugsTBone steak = new ThugsTBone();
            Assert.True(steak is IOrderItem);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone steak = new ThugsTBone();
            Assert.True(steak is Entree);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone steak = new ThugsTBone();
            Assert.Equal(6.44, steak.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone steak = new ThugsTBone();
            Assert.Equal((uint)982, steak.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone steak = new ThugsTBone();
            Assert.Empty(steak.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone steak = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", steak.ToString());
        }
    }
}