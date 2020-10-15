using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldStartAsEmptyCollection()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(o);
            Assert.Empty(o);
        }

        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            o.Add(b);
            Assert.Contains(b, o);
        }

        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            o.Add(b);
            o.Add(new DoubleDraugr());
            o.Add(new SailorSoda());
            o.Remove(b);
            Assert.DoesNotContain(b, o);
        }

        [Fact]
        public void ShouldAlertWhenPropertyChanged()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            DoubleDraugr d = new DoubleDraugr();
            DragonbornWaffleFries f = new DragonbornWaffleFries();
            SailorSoda s = new SailorSoda();
            Assert.PropertyChanged(o, "Subtotal", () => o.Add(b));
            Assert.PropertyChanged(o, "Tax", () => o.Add(d));
            Assert.PropertyChanged(o, "Total", () => o.Add(f));
            Assert.PropertyChanged(o, "Calories", () => o.Add(s));

            Assert.PropertyChanged(o, "Subtotal", () => s.Size = Data.Enums.Size.Large);
            Assert.PropertyChanged(o, "Tax", () => f.Size = Data.Enums.Size.Large);
            Assert.PropertyChanged(o, "Total", () => s.Size = Data.Enums.Size.Medium);
            Assert.PropertyChanged(o, "Calories", () => f.Size = Data.Enums.Size.Medium);
        }

        [Fact]
        public void GivesCorrectPrice()
        {
            Order o = new Order
            {
                new BriarheartBurger(),
                new DragonbornWaffleFries(),
                new SailorSoda()
            };
            Assert.Equal(8.16, o.Subtotal);
            Assert.Equal(0.9792, o.Tax);
            Assert.Equal(9.1392, o.Total);
        }

        [Fact]
        public void GivesCorrectCalorieCount()
        {
            Order o = new Order
            {
                new BriarheartBurger(),
                new DragonbornWaffleFries(),
                new SailorSoda()
            };
            Assert.Equal((uint)937, o.Calories);
        }
    }
}
