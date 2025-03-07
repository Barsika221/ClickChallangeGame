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
using System.Windows.Threading;

namespace ClickChallangeGame;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int time = 10;
    private int count = 0;
    private DispatcherTimer Timer;
    public MainWindow()
    {
        InitializeComponent();

        Timer = new DispatcherTimer();
        Timer.Interval = new TimeSpan(0, 0, 1);
        Timer.Tick += Timer_Tick;
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
        time--;
        visszaszamlalo.Text = time.ToString();
        if (time == 0)
        {
            Timer.Stop();
            MessageBox.Show("Lejárt az idő");
            count = 0;
            kattintoButton.Visibility = Visibility.Collapsed;
            startbutton.Visibility = Visibility.Visible;
        }
    }
    private void ClickCounterButton(object sender, RoutedEventArgs e)
    {
        count++;
        pontszamlalo.Text ="Kattintások száma: " + count.ToString();
    }

    private void ClickStartButton(object sender, RoutedEventArgs e)
    {
        time = 10;
        Timer.Start();
        pontszamlalo.Text = "Kattintások száma: 0";
        kattintoButton.Visibility = Visibility.Visible;
        startbutton.Visibility = Visibility.Collapsed;
    }
}