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
using System.Windows.Threading;


namespace MyProject
{
    //<summary>
     //Interaction logic for MainWindow.xaml
     //</summary>
    public partial class MainWindow : NavigationWindow
    {
    //DispatcherTimer _timer;
    //TimeSpan _time;

    public MainWindow()
    {
        InitializeComponent();



        // _timer.Start();
    }
        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    _time = TimeSpan.FromSeconds(10);

        //    _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
        //    {
        //        tbTime.Text = _time.ToString("c");
        //        if (_time == TimeSpan.Zero) _timer.Stop();
        //        _time = _time.Add(TimeSpan.FromSeconds(-1));
        //    }, Application.Current.Dispatcher);
        //    _timer.Start();
        //}

        //public void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService nav = NavigationService.GetNavigationService(this);
        //    NextPage newpage = new NextPage();
        //    nav.Navigate(newpage);
            

        //}
    }

    
}
