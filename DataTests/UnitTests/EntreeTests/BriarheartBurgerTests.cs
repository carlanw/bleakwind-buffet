﻿/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldNotifyWhenPropertyChanged()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
            Assert.PropertyChanged(burger, "Bun", () => burger.Bun = false);
        }

        [Fact]
        public void ShouldBeAnOrderItem()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger is IOrderItem);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger is Entree);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = false;
            Assert.False(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal(6.32, burger.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal((uint)743, burger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;
            if (includeBun)
                Assert.Empty(burger.SpecialInstructions);
            else
            {
                Assert.Contains("Hold bun", burger.SpecialInstructions);
                Assert.Contains("Hold ketchup", burger.SpecialInstructions);
                Assert.Contains("Hold mustard", burger.SpecialInstructions);
                Assert.Contains("Hold pickle", burger.SpecialInstructions);
                Assert.Contains("Hold cheese", burger.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", burger.ToString());
        }

        [Fact]
        public void HasDescription()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", burger.Description);
        }
    }
}