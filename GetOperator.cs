// using System;
//
//
// class GetOperator
// {
//     public string getOperatorvalue(string opervalue)
//     {
//         string operatorInput; 
//         double number1Input;
//         double number2Input;
//         double result;
//         string operatorChar = "+-*/";
//         bool notValidOperator;
//         string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//         string lowerCase = "abcdefghijklmnopqrstuvwxyz";
//         string digits = "0123456789"; 
//         string specialChars = "!@#$%^&()";
//         
//          Console.WriteLine("Please enter an Operator of +, -, *, or /");
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
//     }
// }