using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            const double rate = 3.42;  // set the exchange rate

            string workername = "Joe"; // set the name of the store worker

            Console.WriteLine($"Welcome to {workername}'s Store.\n"); // welcome the user to the store

            Console.Write("Please enter your name: "); // ask the user for their name
            string custname = Console.ReadLine();

            Console.Write($"Hello {custname}, What is the amount of dollars you would like to recieve? "); // ask the user for the amount of dollars they want to exchange
            double amount = double.Parse(Console.ReadLine());

            // calculate the amount in shekels, the fee, the total price, and the fee payment
            double amountInShekels = amount * rate;
            double fee = amountInShekels * (15.0 / 1000);
            double total = amountInShekels + fee;
            double feePayment = fee / 3;

            // print the final invoice to the user
            Console.WriteLine($"Here's your final invoice, {custname}:\n\t#Amount of dollars: {amount}\n\t#Price in shekels: {amountInShekels}\n\t#Fee in one payment: {fee}\n\t#Fee in three payments: {feePayment}\n\t#Total price: {total}");
        }
    }
}
