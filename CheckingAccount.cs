
using System;

class CheckingAccount : Account
{
   private decimal transactionFee; 

  
   public CheckingAccount( decimal initialBalance, decimal fee )
      : base( initialBalance ) 
   {
      if ( fee >= 0 )
         transactionFee = fee; 
      else
         throw new ArgumentOutOfRangeException();
   } 

  
   public override bool Credit( decimal amount )
   {
      if ( amount <= transactionFee )
      {
         Console.WriteLine("Deposit amount must exceed transaction fee ({0:C}).",transactionFee );
         return false;
      }
         
      ChargeFee();
      return base.Credit( amount );
   } 

  
   public override bool Debit( decimal amount )
   {
      if ( amount + transactionFee > Balance )
      {
         Console.WriteLine("Debit amount plus transaction fee " + "exceeded account balance." );
         return false;
      }

      ChargeFee();
      return base.Debit( amount );
   } 

   
   private void ChargeFee()
   {
      Balance -= transactionFee;
      Console.WriteLine( "{0:C} transaction fee charged.",transactionFee );
   } 
} 