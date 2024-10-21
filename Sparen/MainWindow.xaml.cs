using System.Security.Principal;
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

namespace Sparen
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
        double weeklyMoney;
        double money;
        double desiredAmount;
        double extraMoney;
        double weeks;
        
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            weeklyMoney = double.Parse(moneyTextBox.Text);
            extraMoney = double.Parse(increaseMoneyTextBox.Text);
            money = 0;
            desiredAmount = double.Parse(desiredMoneyTB.Text);

            while (money < desiredAmount)
            {
                money += weeklyMoney;
                weeklyMoney += extraMoney;
                weeks++;
             
            }
            
            outputTextBox.Text = $"spaarbedrag na {weeks} weken:" + $"{desiredAmount}\n" + "Extra weekgeld op dat moment " + $"{weeks*extraMoney}\n" + "Totaal spaargeld: " + $"{money}\n";


        }
    }

}