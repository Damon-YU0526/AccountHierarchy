
using System;

class SavingsAccount : Account
{

   private decimal interestRate;

   
   public SavingsAccount( decimal initialBalance, decimal rate )
      : base( initialBalance ) 
   {
      if ( rate >= 0 )
         interestRate = rate; 
      else
         throw new ArgumentOutOfRangeException();
   } 

  
   public decimal CalculateInterest()
   {
      return Balance * interestRate;
   } 
} 
