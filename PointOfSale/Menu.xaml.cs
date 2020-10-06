using BleakwindBuffet.Data.Entrees;
using PointOfSale.Items;
using PointOfSale.Items.Entrees;
using PointOfSale.Items.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.ItemPages.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BriarheartBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if(Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new BriarheartBurgerPage());
        }

        private void DoubleDraugrButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new DoubleDraugrPage());
        }

        private void GardenOrcOmeletteButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new GardenOrcOmelettePage());
        }

        private void PhillyPoacherButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new PhillyPoacherPage());
        }

        private void SmokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new SmokehouseSkeletonPage());
        }

        private void ThalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new ThalmorTriplePage());
        }

        private void ThugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new ThugsTBonePage());
        }

        private void DragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new DragonbornWaffleFriesPage());
        }

        private void FriedMiraakButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new FriedMiraakPage());
        }

        private void MadOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new MadOtarGritsPage());
        }

        private void VokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new VokunSaladPage());
        }

        private void AretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new AretinoAppleJuicePage());
        }

        private void CandlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new CandlehearthCoffeePage());
        }

        private void MarkarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new MarkarthMilkPage());
        }

        private void SailorSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new SailorSodaPage());
        }

        private void WarriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.Children.Count > 3)
            {
                Panel.Children.RemoveAt(3);
            }
            Panel.Children.Insert(3, new WarriorWaterPage());
        }
    }
}
