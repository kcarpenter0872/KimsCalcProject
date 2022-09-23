// using System.Security.Authentication;
//
// namespace CalcProjectV2
// {
//     class CalcProgram
//     {
//        private static void Main(string[] args)
//         {
//             string operatorInput;
//             double number1Input;
//             double number2Input;
//             double result;
//             string operatorChar = "+-*/";
//             bool notValidOperator;
//             int continueYesNo = 1;
//             int ynContinue;
//             string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//             string lowerCase = "abcdefghijklmnopqrstuvwxyz";
//             string digits = "0123456789"; 
//             string specialChars = "!@#$%^&()";
//
//             Console.Clear();
//             Console.WriteLine("\nWelcome to the Calculator Projects");
//             Console.WriteLine("************************************\n");
//             Console.WriteLine("This Program will let the user perform 2 types of options:\n");
//             Console.WriteLine("1) Use a Simple Calculator that performs arithmetic on 2 numbers"); 
//             Console.WriteLine("2) Use a Tip Calculator that calculates a tip  \n"); 
//             
//              while (continueYesNo == 1)
//              {
//                  string yesOrNoToContinue;
//                  
//                  Console.WriteLine("Enter a 1 to perform a simple calculation");
//                  Console.WriteLine("Enter a 2 to calculate a tip");
//                  Console.WriteLine("Enter a 3 to EXIT the program");
//                  
//                  yesOrNoToContinue = Console.ReadLine();
//                  ynContinue = Convert.ToInt32(yesOrNoToContinue);
//
//                  switch (ynContinue)
//                  {
//                      case 3:
//                      {
//                          Console.WriteLine("Thank you for using the Calculator Project");
//                          continueYesNo = 3;
//                          System.Environment.Exit(0);
//                          break;
//                      }
//                      case 2:
//                      {
//                          Console.WriteLine("You are going to the tip calculator");
//                          TipProgram tipVersion = new TipProgram();
//                          tipVersion.TipCalc();
//                          break;
//                      }
//                      case 1:
//                      {
//                          Console.WriteLine("Please enter an Operator of +, -, *, or /");
//                          operatorInput = Console.ReadLine();
//                          
//                           if (operatorChar.Contains(operatorInput))
//                          {
//                              Console.WriteLine("Enter your first number: ");
//                              number1Input = Convert.ToDouble(Console.ReadLine());
//                              Console.WriteLine("Enter your second number: ");
//                              number2Input = Convert.ToDouble(Console.ReadLine());
//
//                              switch (operatorInput)
//                              {
//                                  case "+":
//                                  {
//                                      result = number1Input + number2Input;
//                                      Console.WriteLine(
//                                          $"Your result is: {number1Input} + {number2Input} = {result}\n\n");
//                                      break;
//                                  }
//                                  case "-":
//                                  {
//                                      result = number1Input - number2Input;
//                                      Console.WriteLine(
//                                          $"Your result is: {number1Input} - {number2Input} = {result}\n\n");
//                                      break;
//                                  }
//                                  case "*":
//                                  {
//                                      result = number1Input * number2Input;
//                                      Console.WriteLine(
//                                          $"Your result is: {number1Input} * {number2Input} = {result}\n\n");
//                                      break;
//                                  }
//                                  case "/":
//                                  {
//                                      while (number2Input == 0)
//                                      {
//                                          Console.WriteLine("\n\n\n\nERROR");
//                                          Console.WriteLine("Please enter a number greater than 0 for your 2nd number:");
//                                          number2Input = Convert.ToDouble(Console.ReadLine());
//                                      }
//
//                                      result = number1Input / number2Input;
//                                      Console.WriteLine(
//                                          $"Your result is: {number1Input} / {number2Input} = {result}\n\n");
//                                      break;
//                                  }
//                                  default:
//                                  {
//                                      while (operatorChar.Contains(operatorInput) || (upperCase.Contains(operatorInput)) || (lowerCase.Contains(operatorInput)) || (digits.Contains(operatorInput)) || (specialChars.Contains(operatorInput)) || (operatorInput is null))
//                                      //     (digits.Contains(operatorInput)) || (specialChars.Contains(operatorInput)) || (operatorInput is null))
//                                      {
//                                          Console.WriteLine("The value you entered was not an operator(+, -, *, or /) ");
//                                          Console.WriteLine("Please enter an operator value: ");
//                                          operatorInput = Console.ReadLine();
//                                      }
//                                      
//                                      // if ((upperCase.Contains(operatorInput)) || (lowerCase.Contains(operatorInput)) ||
//                                      //     (digits.Contains(operatorInput)) || (specialChars.Contains(operatorInput)) || (operatorInput is null))
//                                      // {
//                                      //     Console.WriteLine("The value you entered was not an operator(+, -, *, or /) ");
//                                      //         Console.WriteLine("Please enter an operator value: ");
//                                      //         operatorInput = Console.ReadLine();
//                                      // } 
//                                      break;
//                                  }
//                              }
//
//                          }
//                          else
//                          {
//
//                              Console.WriteLine("The value you entered was not an operator(+, -, *, or /) ");
//                              Console.WriteLine("Please enter an operator value: ");
//                              operatorInput = Console.ReadLine();
//                          }
//
//                          break;
//                      }
//                      default:
//                      {
//                          // if ((upperCase.Contains(operatorInput)) || (lowerCase.Contains(operatorInput)) ||
//                          //     (digits.Contains(operatorInput)) || (specialChars.Contains(operatorInput)) || (operatorInput is null))
//                          // {
//                          //     Console.WriteLine("The value you entered was not an operator(+, -, *, or /) ");
//                          //         Console.WriteLine("Please enter an operator value: ");
//                          //         operatorInput = Console.ReadLine();
//                          // } 
//                          Console.WriteLine("You did not enter a valid number.");
//                          Console.WriteLine("Please enter 1, 2, or 3.");
//                          break;
//                      }
//                     
//                  }
//              }
//         } 
//     }
// }