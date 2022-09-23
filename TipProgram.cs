using System;

public class TipProgram
{
    public void TipCalcProg()
    {
        bool continueYesNoTip = true;
        decimal dollarInputs = 0;
        double numberInputs = 0;
        int tipInputs = 0;
        int percentageInputs = 0;
        string operatorChar = "+-*/";
        int percentagenum = 0;
       

        Console.WriteLine("Welcome to the Tip Calculator");
        Console.WriteLine("*****************************\n");
        Console.WriteLine("In this program you will enter in a total dollar amount and then a tip percentage");
        Console.WriteLine("Then the program will calculate the amount of the tip");
       
        decimal totalDollarAmount = getDollarAmount();
        getPercentageAmount();
        calcTip(totalDollarAmount, percentageInputs);

        decimal getDollarAmount()
        {
            bool dollarContinue = true;

            while (dollarContinue)
            {
                Console.WriteLine("Please enter your total bill amount: ");
                Console.WriteLine("Example: 10.53, 100.00, 5");
                string? dollarInput = Console.ReadLine();

                decimal num = 0;
                bool successfulDollarAmount = decimal.TryParse(dollarInput, out num);

                if (successfulDollarAmount)
                {
                    dollarInputs = num;
                    dollarContinue = false;
                }
                else
                {
                    Console.WriteLine("The value you entered was not a valid decimal amount! ");
                }
            }

            return dollarInputs;
        }

        decimal getPercentageAmount()
        {
            bool percentageContinue = true;

            while (percentageContinue)
            {
                Console.WriteLine("Please choose a percent amount to tip: ");
                Console.WriteLine("1) 18%");
                Console.WriteLine("2) 20%");
                Console.WriteLine("3) 25%");
                string? percentageInput = Console.ReadLine();
                bool validPercentageYOrN = Int32.TryParse(percentageInput, out percentagenum);

                if (validPercentageYOrN)
                {
                    switch (percentagenum)
                    {
                        case 1 or 2 or 3:
                            percentageContinue = false;
                            calcTip(dollarInputs, percentagenum);
                            break;
                        default:
                        {
                            getTipInput();
                            break;
                        }
                    }
                }
            }
            return percentageInputs;
        }

        int getTipInput()
        {
            bool tipContinue = true;

            while (tipContinue)
            {
                Console.WriteLine("Please choose a percent amount to tip: ");
                Console.WriteLine("1) 18%");
                Console.WriteLine("2) 20%");
                Console.WriteLine("3) 25%");
                string? tipInput = Console.ReadLine();

                int num = 0;
                bool successfulnumber = Int32.TryParse(tipInput, out num);

                if (successfulnumber)
                {
                    tipInputs = num;
                    tipContinue = false;
                }
                else
                {
                    Console.WriteLine("The value you entered was not a valid number! ");
                }
            }

            return tipInputs;
        }

        static void calcTip(decimal dollarInputs, int tipInputs)
        {
            decimal percent;
            switch (tipInputs)
            {
                case 1:
                    percent = .18m;
                    printresult(dollarInputs, percent);
                    break;
                case 2:
                    percent = .20m;
                    printresult(dollarInputs, percent);
                    break;
                case 3:
                    percent = .25m;
                    printresult(dollarInputs, percent);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }

        static void  printresult(decimal dollarInputs, decimal percent)
        {
            decimal tip = Decimal.Multiply(dollarInputs, percent);
            decimal result = Decimal.Add(tip, dollarInputs);
            tip = decimal.Round(tip, 2, MidpointRounding.AwayFromZero);
            result= decimal.Round(result, 2, MidpointRounding.AwayFromZero);
            dollarInputs = decimal.Round(dollarInputs, 2, MidpointRounding.AwayFromZero);
            
            Console.WriteLine($"Your bill without tip is: ${dollarInputs}");
            Console.WriteLine($"Your tip amount is: ${tip}");
            Console.WriteLine($"Your total bill with tip is ${result}\n");
        }
    }
}
