using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double rate = 3.42;
            string workername = "Joe";
            Console.WriteLine($"Welcome to {workername}'s Store.\n");
            Console.Write("Please enter your name: ");
            string custname = Console.ReadLine();
            Console.Write($"Hello {custname}, What is the amount of dollars you would like to recieve? ");
            double amount = double.Parse(Console.ReadLine());
            double amountInShekels = amount * rate;
            double fee = amountInShekels * (15.0 / 1000);
            double total = amountInShekels + fee;
            double feePayment = fee / 3;
            Console.WriteLine($"Here's your final invoice, {custname}:\n\t#Amount of dollars: {amount}\n\t#Price in shekels: {amountInShekels}\n\t#Fee in one payment: {fee}\n\t#Fee in three payments: {feePayment}\n\t#Total price: {total}");
        }
    }
}
