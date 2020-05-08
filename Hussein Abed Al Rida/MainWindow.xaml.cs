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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hussein_Abed_Al_Rida
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public static List<Ticket> tickets;
        public string customerName1, eventName1, ticketsNumber1, isFirstClass1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int sl;
            sl = Convert.ToInt16(slider.Value);
            ticketTextBlock.Text = sl.ToString();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            tickets = new List<Ticket>();
            customerName1 = customerTextBlock.Text;
            eventName1 = eventComboBox.SelectionBoxItem.ToString();
            ticketsNumber1 = ticketTextBlock.Text;
            if (firstClassRadioButton.IsChecked == true)
                isFirstClass1 = "First Class";
            else if (secondClassradioButton.IsChecked == true)
                isFirstClass1 = "Second Class";
            tickets.Add(new Ticket { eventName = eventName1, customerName = customerName1, ticketsNumber = ticketsNumber1, isFirstClass = isFirstClass1 });
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            Reservations reservation = new Reservations();
            reservation.InitializeComponent();

            NavigationWindow navWindow = (NavigationWindow)App.Current.MainWindow;
            navWindow.Content = reservation;
        }
    }
}
