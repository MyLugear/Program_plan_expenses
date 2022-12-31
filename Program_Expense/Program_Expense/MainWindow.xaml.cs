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

namespace Program_Expense
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(txtIncome.Text);
            int cost = int.Parse(txtCost.Text);
            int price_of_item = int.Parse(txtPriceOfItem.Text);

            int moneyLeft = (income - cost);
            string  number_of_days = (price_of_item / moneyLeft).ToString();

            txtNumberOfDays.Text = number_of_days;

        }

        private void txtIncome_TextChanged()
        {

        }
    }
}
