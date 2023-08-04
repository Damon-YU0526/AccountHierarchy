
using System;

class Account
{
   private decimal balance; 

   
   public Account( decimal initialBalance )
   {
      Balance = initialBalance; 
   } 

   // credit the account balance by amount
   public virtual bool Credit( decimal amount )
   {
      Balance += amount; 
      return true;
   } 


   public virtual bool Debit( decimal amount )
   {
      if ( amount > Balance ) 
      {
         Console.WriteLine( "Debit amount exceeded account balance." );
         return false;
      } 
      else 
      {
         Balance -= amount;
         return true;
      } 
   } 

   
   public decimal Balance
   {
      get
      {
         return balance;
      } 
      set
      {
         if ( value >= 0.0M )
            balance = value;
         else 
            throw new ArgumentOutOfRangeException();
      } 
   } 
} 

