using System;
using System.Runtime.CompilerServices;

namespace BudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double projectedIncome = 0;
            double actualIncome = 0;

            double projectedExpenseTotal = 0;
            double actualExpenseTotal = 0;


            double projectedMortgage = 0;
            double actualMortgage = 0;

            double projectedElectricGas = 0;
            double actualElectricGas = 0;

            double projectedWater = 0;
            double actualWater = 0;

            double projectedPhoneInternet = 0;
            double actualPhoneInternet = 0;

            bool isValidChoice = false;
            while (!isValidChoice)
            {
                Console.Write("Enter [1]Projected Values or [2]Actual Values: ");
                int projectedOrActual = int.Parse(Console.ReadLine());

                if (projectedOrActual == 1)
                {
                    isValidChoice = true;

                    //Get projected expenses
                    Console.Write("Projected Income: ");
                    projectedIncome = double.Parse(Console.ReadLine());

                    Console.Write("Projected Mortgage: ");
                    projectedMortgage = double.Parse(Console.ReadLine());

                    Console.Write("Projected Electric/Gas: ");
                    projectedElectricGas = double.Parse(Console.ReadLine());

                    Console.Write("Projected Water: ");
                    projectedWater = double.Parse(Console.ReadLine());

                    Console.Write("Projected Phone/Internet: ");
                    projectedPhoneInternet = double.Parse(Console.ReadLine());

                    //Total Projected Expenses
                    projectedExpenseTotal = projectedMortgage + projectedElectricGas + projectedWater + projectedPhoneInternet;
                    Console.WriteLine($"Your total projected expenses are {projectedExpenseTotal:C}");
                }
                else if (projectedOrActual == 2)
                {
                    isValidChoice = true;

                    //Get actual expenses
                    Console.Write("Actual Income: ");
                    actualIncome = double.Parse(Console.ReadLine());

                    Console.Write("Actual Mortgage: ");
                    actualMortgage = double.Parse(Console.ReadLine());

                    Console.Write("Actual Electric/Gas: ");
                    actualElectricGas = double.Parse(Console.ReadLine());

                    Console.Write("Actual Water: ");
                    actualWater = double.Parse(Console.ReadLine());

                    Console.Write("Actual Phone/Internet: ");
                    actualPhoneInternet = double.Parse(Console.ReadLine());

                    //Total Actual Expenses
                    actualExpenseTotal = actualMortgage + actualElectricGas + actualWater + actualPhoneInternet;

                    Console.WriteLine($"Your total actual expenses are {actualExpenseTotal:C}");

                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

                string addValues = "";

                if (actualExpenseTotal <= 0)
                {
                    Console.Write("Would you like to add values for the actual expense? Y or N: ");
                    addValues = Console.ReadLine().ToLower();
                    isValidChoice = false;
                }
                else if (projectedExpenseTotal <= 0)
                {
                    Console.Write("Would you like to add values for the actual expense? Y or N: ");
                    addValues = Console.ReadLine().ToLower();
                    isValidChoice = false;
                }

                if (addValues != "y")
                {
                    isValidChoice = true;
                }

            }

            if (actualExpenseTotal > 0 && projectedExpenseTotal > 0)
            {
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write("[1]Income Difference [2]Mortgage Difference [3]Electric/Gas Difference [4]Water Difference [5]Phone/Internet Difference [6]Total Gain or Losses: ");
                    int userMenuOption = int.Parse(Console.ReadLine());



                    switch (userMenuOption)
                    {
                        case 1:
                            Console.WriteLine($"The difference is {CalculateBudgetDifference(actualIncome, projectedIncome):C}");
                            isValid = true;
                            break;

                        case 2:
                            Console.WriteLine($"The difference is {CalculateBudgetDifference(actualMortgage, projectedMortgage):C}");
                            isValid = true;
                            break;

                        case 3:
                            Console.WriteLine($"The difference is {CalculateBudgetDifference(actualElectricGas, projectedElectricGas):C}");
                            isValid = true;
                            break;

                        case 4:
                            Console.WriteLine($"The difference is {CalculateBudgetDifference(actualWater, projectedWater):C}");
                            isValid = true;
                            break;

                        case 5:
                            Console.WriteLine($"The difference is {CalculateBudgetDifference(actualPhoneInternet, projectedPhoneInternet):C}");
                            isValid = true;
                            break;

                        case 6:
                            Console.WriteLine($"The difference is {CalculateGainsAndLosses(actualIncome, actualExpenseTotal):C}");
                            isValid = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }


                    Console.Write("Back to Menu Y or N: ");
                    string backToMain = Console.ReadLine().ToLower();

                    if (backToMain == "y")
                    {
                        isValid = false;
                    }
                }
            }

            Console.WriteLine("Thank you for using our application.");
            Console.WriteLine("Press Enter To Exit Application");
            Console.ReadLine();
        }

        public static double CalculateBudgetDifference(double actual, double projected)
        {
            return projected - actual;
        }

        public static double CalculateGainsAndLosses(double incomeTotal, double expensesTotal)
        {
            return incomeTotal - expensesTotal;
        }


    }
}
