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
    /// <summary>
    /// Interaction logic for NextPage.xaml
    /// </summary>
    public partial class NextPage : Page
    {
        

        public NextPage()
        {
            InitializeComponent();
        }

        private void StartThread_1(object sender, RoutedEventArgs e)
        {
            
            

            //returns a string with corresponding numbers
            Task<string> t1 = new Task<string>(() => {

                string letters = "abcdefghijklmnopqrstuvwxyz";
                Random rand = new Random();
                string t1string = string.Empty;


                for (int i = 0; i != 5; i++)
                {
                    int next = rand.Next(0, letters.Length);
                    t1string += $"{letters[next]}{next.ToString()}";
                }
               
                return t1string;

                
            });
                t1.Start();
                Thread1.Text = t1.Result;

            //returns just numbers 
            Task<string> t2 = new Task<string>(() =>
            {
                string t2string = string.Empty;
                t1.Result.ToString();
                string numbers = "1234567890";
                for(int i = 0; i <= t1.Result.Length-1; i++)
                {
                    for(int j = 0; j <= numbers.Length-1; j++)
                    {
                        if(numbers[j] == t1.Result[i])
                        {
                            t2string += numbers[j];
                           
                        }
                    }
                }

                
                return t2string;
            });
            t2.Start();
            Thread2.Text = t2.Result;

            //returns just letters
            Task<string> t3 = new Task<string>(() =>
            {
                string t3string = string.Empty;
                t1.Result.ToString();
                string letters = "abcdefghijklmnopqrstuvwxyz";
                for (int i = 0; i <= t1.Result.Length - 1; i++)
                {
                    for (int j = 0; j <= letters.Length - 1; j++)
                    {
                        if (letters[j] == t1.Result[i])
                        {
                            t3string += letters[j];

                        }
                    }
                }
                return t3string;
            });
            t3.Start();
            Thread3.Text = t3.Result;
        }
    }
}
