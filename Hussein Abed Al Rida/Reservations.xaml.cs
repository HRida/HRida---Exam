using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hussein_Abed_Al_Rida
{
    /// <summary>
    /// Interaction logic for Reservations.xaml
    /// </summary>
    public partial class Reservations : Page
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void displayButton_Click_1(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
            if (MainWindow.tickets != null)
            {
                foreach (Ticket t in MainWindow.tickets)
                {
                    listView.Items.Add(t.customerName + " " + "Reserved" + " " + t.ticketsNumber + " " + "ticket(s)," + " " + t.isFirstClass + " " + "for" + t.eventName + "\n");
                }
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.tickets != null)
            {
                listView.Items.Clear();
                var elements = from element in MainWindow.tickets
                               where nametextBox.Text == element.customerName
                               select element;
                foreach (var element in elements)
                {
                    listView.Items.Add(element.customerName + " " + "Reserved" + element.eventName + " " + "ticket(s)," + " " + element.isFirstClass + " " + "for" + element.ticketsNumber);
              
                }
            }
        }
    }
}
