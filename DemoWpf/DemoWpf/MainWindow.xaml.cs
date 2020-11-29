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
        //will show the content within the buttons on the display(textblock) when clicked on
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button) //Kollar ifall sender är en knapp och isåfall läggs den  i en variabel(button)
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
                    case "*": 
                    case "+":
                    case "-":
                    case "/":
                    case ",":

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

            var result = 0.0;
            
            var operationList = Display.Text.Split('*', '/', '+', '-');

            //kollar ifall man bara klickar på = så kraschar det inte
            if(operationList.Length != 2)
            {
                return;
            }

            var numberOne = Convert.ToDouble(operationList[0]); 
            var numberTwo = Convert.ToDouble(operationList[1]);
            
            
            if (Display.Text.Contains("+"))
            {
               var additionSum = numberOne + numberTwo; 
                 result = additionSum ;
               
            }
            else if (Display.Text.Contains("*"))
            {
               var multiplicationSum = numberOne * numberTwo;
                 result = multiplicationSum ;
            }
            else if (Display.Text.Contains("-"))
            {
                var subtractionSum = numberOne - numberTwo;
                 result = subtractionSum;
            }
            else if (Display.Text.Contains("/"))
            {   if(numberTwo == 0)
                {
                    Display.Text = "dont divid by 0 you doughnut";
                    return;
                }

                var divisonSum = numberOne / numberTwo;
                 result = divisonSum;
            }
            Display.Text += "=" + result;


        }
        //Backspace, checks if it's something on the display and will then delete it by one, if it's nothing on the display it will not do anything
        private void Button_Click_BackSpace(object sender, RoutedEventArgs e)
        {
           
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            }
            else
            {
                Display.Text = "";
                
            }
           

        }

        //delete this shit, delete everything on the display
        private void Button_CLick_Delete(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
        }
       
        //Squareroot of the number you choose, converting the textblock to double just to execute the Math.Sqrt method and then converting back to an String to display it on the textblock
        private void Button_Click_SquareRoot(object sender, RoutedEventArgs e)
          {
            if (Display.Text.Length > 0)
            {
                var squareRootSum = Convert.ToString(Math.Sqrt(Convert.ToDouble(Display.Text)));
                Display.Text += "=" + squareRootSum;
            }
            else
            {
                Display.Text = "";
            }
          
        }
        //on click, divide the number on the display / 100  
        private void Button_Click_PercentageToDecimal(object sender, RoutedEventArgs e)
        {
            var percentageToDecimalSum = "";

            if (Display.Text.Length > 0)
            {
                percentageToDecimalSum = Convert.ToString(double.Parse(Display.Text) / 100);
                Display.Text += "=" + percentageToDecimalSum;
            }
            else
            {
                Display.Text = "";
            }
        }
    }


}
