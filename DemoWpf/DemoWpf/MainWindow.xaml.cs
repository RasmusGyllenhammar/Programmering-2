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

namespace DemoWpf
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
            if(sender is Button button) //Kollar ifall sender är en knapp och isåfall läggs den  i en variabel(number)
            {
                switch (button.Content)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "0":
                    case "*": //operationer och neråt
                    case "+":
                    case "-":
                    case "/":
                    case ".":
                   
                        Display.Text += button.Content;
                        break;
                    case "=":
                        CalculateOperations();
                        break;

                    default:
                        break;
                }
            }
           
        }




        //This method Calculates the specific basic arithmetic mathematical operation you picked
        private void CalculateOperations()
        {
            // var talenSomText = Text.split('+')
            // var tal1 = convert.ToDouble(talenSomText+[0]
            String[] operationList;


            operationList = Display.Text.Split('*', '/', '+', '-');

            var numberOne = Convert.ToDouble(operationList[0]); //första talet, index 0
            var numberTwo = Convert.ToDouble(operationList[1]); //andra talet, listan tar med de fyra och då blir index 0,1 för talen
            
            if (Display.Text.Contains("+"))
            {   
                var result = "=" + numberOne + numberTwo;
                Display.Text += result;
            }
            else if (Display.Text.Contains("*"))
            {
                var result = "=" + numberOne * numberTwo;
                Display.Text += result;
            }
            else if (Display.Text.Contains("-"))
            {
                var result = numberOne - numberTwo;
                Display.Text += "=" + result;
            }
            else if (Display.Text.Contains("/"))
            {
                var result = numberOne / numberTwo;
                Display.Text += "=" + result;
            }
            

      
        }

        private void Button_Click_BackSpace(object sender, RoutedEventArgs e)
        {
            //backSPace, kollar ifall det är något skrivit i displayen så tar den bort det onClick
            if(Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            }
           
        }
    }

   
}
