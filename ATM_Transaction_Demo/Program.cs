using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Transaction_Demo
{
    class Program
    {
        int Validate_Pin(int UserEnteredPin)
        {
            int Actual_Pin = 5544;
            if (Actual_Pin == UserEnteredPin)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        int Withdraw_Amt(int UserEnteredAmt)
        {
            int Actual_Amt = 20000;
            if (Actual_Amt > UserEnteredAmt)
            {
                Actual_Amt = Actual_Amt - UserEnteredAmt;
                return Actual_Amt;

            }
            else
            {
                return -1;
            }
        }

        int Withdraw_Amt(int UserEnteredAmt, int Actual_Amt)
        {

            if (Actual_Amt > UserEnteredAmt)
            {
                Actual_Amt = Actual_Amt - UserEnteredAmt;
                return Actual_Amt;

            }
            else
            {
                return -1;
            }
        }



        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.Write("Please Enter Pin: ");
            int UserEnteredPin = Convert.ToInt32(Console.ReadLine());

            int Val_Pin = obj.Validate_Pin(UserEnteredPin);

            if (Val_Pin > 0)
            {

                Console.WriteLine("-----Proceed for Cash Withdrawal-----");
                Console.Write("Enter the Amount you want to Withdraw: ");
                int UserEnteredAmt = Convert.ToInt32(Console.ReadLine());

                int Val_Withdraw = obj.Withdraw_Amt(UserEnteredAmt);
                if (Val_Withdraw > 0)
                {
                    Console.WriteLine("Transaction Successfull and your Balance Amount: " + Val_Withdraw);
                    Console.WriteLine("Do u wish to continue");
                    Console.WriteLine("Press Y for Yes");
                    Console.WriteLine("Prees N for No");

                    string UserTransChoice = Console.ReadLine();

                    if (UserTransChoice == "Y")
                    {
                        Console.WriteLine("Enter the Amount you want to withdraw");
                        int UserEnteredAmt2 = Convert.ToInt32(Console.ReadLine());

                        int Val_Withdraw2 = obj.Withdraw_Amt(UserEnteredAmt2, Val_Withdraw);
                        if (Val_Withdraw2 > 0)
                        {
                            Console.WriteLine("Transaction Successfull and your Balance Amount: " + Val_Withdraw2);
                        }

                        else
                        {
                            Console.WriteLine("Insufficient Amount!!!");
                        }
                    }
                    else if (UserTransChoice == "N")
                    {
                        Console.WriteLine("Have a good day :) !!!");
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient Amount!!!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Pin!!!");
            }


            Console.ReadLine();
        }
    }
}