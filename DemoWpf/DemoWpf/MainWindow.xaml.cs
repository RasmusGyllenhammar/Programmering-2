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

            var numberOne = Convert.ToDouble(operationList[0]);                 //första talet, index 0
            var numberTwo = Convert.ToDouble(operationList[1]);                  //andra talet, listan tar med de fyra och då blir index 0,1 för talen
            
            if (Display.Text.Contains("+"))
            {
               var additionSum = numberOne + numberTwo; //gör beräkningar sepererat sen lägg till strängar
                var result = "=" + additionSum ;
               
                Display.Text += result;
            }
            else if (Display.Text.Contains("*"))
            {
               var multiplicationSum = numberOne * numberTwo;
                var result = "=" + multiplicationSum ;
                Display.Text += result;
            }
            else if (Display.Text.Contains("-"))
            {
                var subtractionSum = numberOne - numberTwo;
                var result = "=" + subtractionSum;
                Display.Text += result;
            }
            else if (Display.Text.Contains("/"))
            {
                var divisonSum = numberOne / numberTwo;
                var result = "=" + divisonSum;
                Display.Text += result;
            }
           
            
            

      
        }

        private void Button_Click_BackSpace(object sender, RoutedEventArgs e)
        {
            //backSPace, kollar ifall det är något skrivit i displayen så tar den bort det onClick
            //just nu måste man klicka två gånger för att det ska försvinna
            if (Display.Text == "error")
            {
                Display.Text = "";
            }
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            }
            else
            {
                Display.Text = "error";
            }
           




        }
        //delete att this shit, deletes everything on the display87
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
                Display.Text = "try again";
            }



            
            
           

          
        }

        private void Button_Click_Percentage(object sender, RoutedEventArgs e)
        {
            // ta det delat på 100
            
        }
    }


}
