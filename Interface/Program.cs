using Interface.Entities;
using Interface.Services;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter contract data\nNumber: ");
            var number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            var totalvalue = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalvalue);

            Console.Write("Enter number of installments: ");
            var months = int.Parse(Console.ReadLine());

            ContractInvoice contractInvoice = new ContractInvoice(new InstallmentPayment());

            contractInvoice.ContractCalculating(contract, months);

            Console.WriteLine("Installments: ");

            foreach (Installment eachcontract in contract.installment)
            {
                Console.WriteLine(eachcontract);
            }
        }
    }
}