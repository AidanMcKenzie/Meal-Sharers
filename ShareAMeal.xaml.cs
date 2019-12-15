using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SEM_Coursework
{
    /// <summary>
    /// Interaction logic for ShareAMeal.xaml
    /// </summary>
    public partial class ShareAMeal : Window
    {
        mealSystem newSystem = new mealSystem();
        private void addEaters()
        {
            string[] eaterList = new string[4];

            eaterList[0] = "John Smith";
            eaterList[1] = "James Brown";
            eaterList[2] = "David Jones";
            eaterList[3] = "Susan White";


            string listOfEaters = string.Join(" \n", eaterList);
            listBox.Items.Add(listOfEaters.ToString());
        }
        public ShareAMeal()
        {
            InitializeComponent();
            addEaters();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            newSystem.Comments = boxComments.Text;
            MessageBox.Show("Comments Submitted.");
        }

        private void btnShare_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Meal Delivered!");
        }
    }
}
