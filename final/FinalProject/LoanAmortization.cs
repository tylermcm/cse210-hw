using System;

class LoanAmortization : AllPrograms
{
    private double loanAmount, interestRate, mpr, monthlyPayment, interestPayment, principalPayment;
    private int loanTerm;
    string table;

    public double getLoanAmount()
    {
        return loanAmount;
    }
    public double getInterestRate()
    {
        return interestRate;
    }
    public int getLoanTerm()
    {
        return loanTerm;
    }
    public void DisplayTable()
    {
        Console.Write("Enter the loan amount: ");
        loanAmount = double.Parse(Console.ReadLine());
        Console.Write("Enter the interest rate: ");
        interestRate = double.Parse(Console.ReadLine());
        Console.Write("Enter the loan term in months: ");
        loanTerm = int.Parse(Console.ReadLine());

        Console.Write(MakeTable(loanAmount, interestRate, loanTerm));
        clearConsole();
    }
    private string MakeTable(double _principal, double _interestRate, int _loanTerm)
    {
        mpr = (interestRate / 100) / 12;
        monthlyPayment = (loanAmount * mpr) / (1 - Math.Pow((1 + mpr), -loanTerm));
        table = string.Format(("Month  Balance      Interest  Payment\n"));
        for (var count = 0; count < _loanTerm; count++)
        {
            interestPayment = Math.Round((loanAmount * mpr), 2);
            principalPayment = Math.Round((monthlyPayment - interestPayment), 2);
            loanAmount -= principalPayment;

            table += string.Format("{0,-5} | {1, -10:0.00} | {2, -7:0.00} | {3, 5:0.00}\n", (count + 1), Math.Round((loanAmount), 2), interestPayment, principalPayment);
        }
        return table;
    }


}
