/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldNotifyWhenPropertyChanged()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
            Assert.PropertyChanged(combo, "Pancake", () => combo.Pancake = false);
        } 

        [Fact]
        public void ShouldBeAnOrderItem()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.True(combo is IOrderItem);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.True(combo is Entree);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.True(combo.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.True(combo.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.True(combo.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.True(combo.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            combo.SausageLink = false;
            Assert.False(combo.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            combo.Egg = false;
            Assert.False(combo.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            combo.HashBrowns = false;
            Assert.False(combo.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            combo.Pancake = false;
            Assert.False(combo.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.Equal(5.62, combo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.Equal((uint)602, combo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton
            {
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake,
                SausageLink = includeSausage,
            };
            if (!includeSausage)
                Assert.Contains("Hold sausage", combo.SpecialInstructions);
            if (!includeEgg)
                Assert.Contains("Hold eggs", combo.SpecialInstructions);
            if (!includeHashbrowns)
                Assert.Contains("Hold hash browns", combo.SpecialInstructions);
            if (!includePancake)
                Assert.Contains("Hold pancakes", combo.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake)
                Assert.Empty(combo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", combo.ToString());
        }

        [Fact]
        public void HasDescription()
        {
            SmokehouseSkeleton combo = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", combo.Description);
        }
    }
}