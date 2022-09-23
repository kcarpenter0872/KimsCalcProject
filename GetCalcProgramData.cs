using System;
using System.Collections.Generic;

public class GetCalcProgramData
{
    public void ContinueYorN()
    {
        bool continueYesNo = true;
        double number1Input;
        double number2Input; 
        double numberInputs = 0.0;
        double result;
        string operatorChar = "+-*/";
        int continueNum = 0;
        string yesOrNoToContinue;


        Console.Clear();
        Console.WriteLine("\nWelcome to the Calculator Projects");
        Console.WriteLine("************************************\n");
        Console.WriteLine("This Program will let the user perform 2 types of options:\n");
        Console.WriteLine("1) Use a Simple Calculator that performs arithmetic on 2 numbers");
        Console.WriteLine("2) Use a Tip Calculator that calculates a tip  \n");


        while (continueYesNo)
        {
            Console.WriteLine("Enter a 1 to perform a simple calculation");
            Console.WriteLine("Enter a 2 to calculate a tip");
            Console.WriteLine("Enter a 3 to EXIT the program\n");

            yesOrNoToContinue = Console.ReadLine();
            bool ynContinue = Int32.TryParse(yesOrNoToContinue, out continueNum);
            Thread.Sleep(2000);
            Console.Clear();

            switch (continueNum)
            {
                case 3:
                {
                    Console.WriteLine("Thank you for using the Calculator Project");
                    continueYesNo = false;
                    break;
                }
                case 2:
                {
                    Console.WriteLine("You are going to the tip calculator");
                    TipProgram tipVersion = new TipProgram();
                    tipVersion.TipCalcProg();
                    break;
                }
                case 1:
                {
                    string? operatorInput = getOperator();
                    getCalcData(operatorInput);
                    break;
                }
                default:
                {
                    Console.WriteLine("You did not enter a valid number.");
                    Console.WriteLine("Please enter 1, 2, or 3.");
                    break;
                }
            }
        }

        string getCalcData(string operatorInput)
        {
            if (operatorChar.Contains(operatorInput))
            {
                number1Input = getNumbers();
                number2Input = getNumbers();

                switch (operatorInput)
                {
                    case "+":
                    {
                        result = number1Input + number2Input;
                        Console.WriteLine(
                            $"Your result is: {number1Input} + {number2Input} = {result}\n\n");
                        break;
                    }
                    case "-":
                    {
                        result = number1Input - number2Input;
                        Console.WriteLine(
                            $"Your result is: {number1Input} - {number2Input} = {result}\n\n");
                        break;
                    }
                    case "*":
                    {
                        result = number1Input * number2Input;
                        Console.WriteLine(
                            $"Your result is: {number1Input} * {number2Input} = {result}\n\n");
                        break;
                    }
                    case "/":
                    {
                        while (number2Input == 0)
                        {
                            Console.WriteLine("\n\n\n\nERROR");
                            Console.WriteLine("Please enter a number greater than 0 for your 2nd number:");
                            number2Input = Convert.ToDouble(Console.ReadLine());
                        }

                        result = number1Input / number2Input;
                        Console.WriteLine(
                            $"Your result is: {number1Input} / {number2Input} = {result}\n\n");
                        break;
                    }
                    default:
                    {
                        getOperator();
                        break;
                    }
                }
            }
            else
            {
                getOperator();
            }
            return operatorInput;
        }

        static string getOperator()
        {
            Console.WriteLine("Please enter an operator value: (+, -, *, or /) ");
            string? operatorInput = Console.ReadLine();

            while (operatorInput != "-" && operatorInput != "+" && operatorInput != "/" && operatorInput != "*")
            {
                Console.WriteLine("The value you entered was not an operator(+, -, *, or /) ");
                Console.WriteLine("Please enter an operator value: ");
                operatorInput = Console.ReadLine();
            }

            return operatorInput;
        }

        double getNumbers()
        {
            bool numberContinue = true;

            while (numberContinue)
            {
                Console.WriteLine("Please enter your value: ");
                string? numberInput = Console.ReadLine();

                double num = 0;
                bool successfulnumber = Double.TryParse(numberInput, out num);

                if (successfulnumber)
                {
                    numberInputs = num;
                     numberContinue = false;
                }
                else
                {
                    Console.WriteLine("The value you entered was not a valid number! ");
                }
            }
            return numberInputs;
        }
         System.Environment.Exit(0);
    }
}