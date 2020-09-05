/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.InteropServices;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
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
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
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
    }
}