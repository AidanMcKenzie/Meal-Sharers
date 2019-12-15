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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SEM_Coursework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cook newCook = new Cook();
        Random rand = new Random();

        private bool pvgAccepted = false;
        private bool hygAccepted = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void pvgYes()
        {
            pvgAccepted = true;
            lblPVG.Content = "PVG Approved";
        }

        private void pvgRej()
        {
            pvgAccepted = false;
            lblPVG.Content = "PVG Rejected";
        }

        private void hygOK()
        {
            hygAccepted = true;
            lblFood.Content = "Food Hygiene Certificate is OK";
        }
        private void hygRenew()
        {
            hygAccepted = true;
            lblFood.Content = "Food Hygiene Certificate needs Renewed";
        }


        private void btnRenewHyg_Click_1(object sender, RoutedEventArgs e)
        {
            if (rand.Next(0, 2) == 0)
            {
                hygAccepted = true;
            }
            else
            {
                hygAccepted = false;
            }
            switch (hygAccepted)
            {
                case true: hygOK(); break;
                case false: hygRenew(); break;
            }
        }

        private void btnPVG_Click_1(object sender, RoutedEventArgs e)
        {
            if (rand.Next(0, 2) == 0)
            {
                pvgAccepted = true;
            }
            else
            {
                pvgAccepted = false;
            }
            switch (pvgAccepted)
            {
                case true: pvgYes(); break;
                case false: pvgRej(); break;
            }
        }

        private void btnCont_Click(object sender, RoutedEventArgs e)
        {
            if (pvgAccepted == false && hygAccepted == false)
            {
                MessageBox.Show("You must pass the Food Hygiene and PVG checks");
            }
            else
            {
                newCook.Cook_name = boxName.Text;
                newCook.Cook_address = boxAdd.Text;
                newCook.Cook_phone_no = boxPhone.Text;

                Window ShareAMeal = new ShareAMeal();
                ShareAMeal.Show();
            }
        }
    }
}