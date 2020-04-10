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
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        /// <summary>
        /// Constructor for the CustomizeCobblerControl
        /// </summary>
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click Event handler for all the FruitFilling RadioButtons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsClicked(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = (Cobbler)this.DataContext;

            switch (((RadioButton)sender).Name)
            {
                case "PeachButton":
                    cobbler.Fruit = FruitFilling.Peach;
                    FruitFillingSwitch(cobbler.Fruit);
                    break;
                case "CherryButton":
                    cobbler.Fruit = FruitFilling.Cherry;
                    FruitFillingSwitch(cobbler.Fruit);
                    break;
                case "BlueBerryButton":
                    cobbler.Fruit = FruitFilling.Blueberry;
                    FruitFillingSwitch(cobbler.Fruit);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Separates the cases of FruitFilling to the correct FruitFilling RadioButton to be checked
        /// </summary>
        /// <param name="size"></param>
        public void FruitFillingSwitch(FruitFilling filling)
        {
            switch (filling)
            {
                case FruitFilling.Peach:
                    PeachButton.IsChecked = true;
                    CherryButton.IsChecked = false;
                    BlueBerryButton.IsChecked = false;
                    break;
                case FruitFilling.Cherry:
                    PeachButton.IsChecked = false;
                    CherryButton.IsChecked = true;
                    BlueBerryButton.IsChecked = false;
                    break;
                case FruitFilling.Blueberry:
                    PeachButton.IsChecked = false;
                    CherryButton.IsChecked = false;
                    BlueBerryButton.IsChecked = true;
                    break;
                default:
                    break;
            }
        }
    }
}
