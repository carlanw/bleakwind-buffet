﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = false;
            Assert.False(omelette.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Mushrooms = false;
            Assert.False(omelette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Tomato = false;
            Assert.False(omelette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Cheddar = false;
            Assert.False(omelette.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal(4.57, omelette.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal((uint)404, omelette.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };
            if (!includeBroccoli)
                Assert.Contains("Hold broccoli", omelette.SpecialInstructions);
            if (!includeMushrooms)
                Assert.Contains("Hold mushrooms", omelette.SpecialInstructions);
            if (!includeTomato)
                Assert.Contains("Hold tomato", omelette.SpecialInstructions);
            if (!includeCheddar)
                Assert.Contains("Hold Cheddar", omelette.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", omelette.ToString());
        }
    }
}