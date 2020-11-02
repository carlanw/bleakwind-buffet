using PointOfSale.Items;
using PointOfSale.ItemPages.Drinks;
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
using PointOfSale.Items.Entrees;
using PointOfSale.Items.Sides;

namespace PointOfSale.ItemPages
{
    /// <summary>
    /// Interaction logic for ComboPage.xaml
    /// </summary>
    public partial class ComboPage : UserControl
    {
        public ComboPage()
        {
            InitializeComponent();
        }

        private void BriarheartBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(1);
            Panel.Children.Insert(1, new BriarheartBurgerPage());
        }

        private void DoubleDraugrButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(1);
            Panel.Children.Insert(1, new DoubleDraugrPage());
        }

        private void GardenOrcOmeletteButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(1);
            Panel.Children.Insert(1, new GardenOrcOmelettePage());
        }

        private void PhillyPoacherButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(1);
            Panel.Children.Insert(1, new PhillyPoacherPage());
        }

        private void SmokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(1);
            Panel.Children.Insert(1, new SmokehouseSkeletonPage());
        }

        private void ThalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(1);
            Panel.Children.Insert(1, new ThalmorTriplePage());
        }

        private void ThugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(1);
            Panel.Children.Insert(1, new ThugsTBonePage());
        }

        private void DragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(3);
            Panel.Children.Insert(3, new DragonbornWaffleFriesPage());
        }

        private void FriedMiraakButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(3);
            Panel.Children.Insert(3, new FriedMiraakPage());
        }

        private void MadOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(3);
            Panel.Children.Insert(3, new MadOtarGritsPage());
        }

        private void VokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(3);
            Panel.Children.Insert(3, new VokunSaladPage());
        }

        private void AretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(5);
            Panel.Children.Insert(5, new AretinoAppleJuicePage());
        }

        private void CandlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(5);
            Panel.Children.Insert(5, new CandlehearthCoffeePage());
        }

        private void MarkarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(5);
            Panel.Children.Insert(5, new MarkarthMilkPage());
        }

        private void SailorSodaButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(5);
            Panel.Children.Insert(5, new SailorSodaPage());
        }

        private void WarriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            Panel.Children.RemoveAt(5);
            Panel.Children.Insert(5, new WarriorWaterPage());
        }
    }
}
