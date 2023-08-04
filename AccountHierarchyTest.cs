//
using System;

class AccountHierarchyTest
{
   public static void Main( string[] args )
   {
      Account account1 = new Account( 50.0M );

      SavingsAccount account2 = new SavingsAccount( 25.0M, .03M );
      CheckingAccount account3 = new CheckingAccount( 80.0M, 1.0M );

      // display initial balance of each object
      Console.WriteLine( "account1 balance: {0:C}", account1.Balance );
      Console.WriteLine( "account2 balance: {0:C}", account2.Balance );
      Console.WriteLine( "account3 balance: {0:C}", account3.Balance );

      // debit each account and show new balance
      Console.WriteLine( "\nAttempting to debit account1 by {0:C}.", 25 );
      account1.Debit( 25.0M );
      Console.WriteLine( "account1 balance: {0:C}", account1.Balance );

      Console.WriteLine( "\nAttempting to debit account2 by {0:C}.", 30 );
      account2.Debit( 30.0M );
      Console.WriteLine( "account2 balance: {0:C}", account2.Balance );

      Console.WriteLine( "\nAttempting to debit account3 by {0:C}.", 40 );
      account3.Debit( 40.0M );
      Console.WriteLine( "account3 balance: {0:C}", account3.Balance );

      // credit each account and show new balance
      Console.WriteLine( "\nCrediting {0:C} to account1.", 40 );
      account1.Credit( 40.0M );
      Console.WriteLine( "account1 balance: {0:C}", account1.Balance );

      Console.WriteLine( "\nCrediting {0:C} to account2.", 65 );
      account2.Credit( 65.0M );
      Console.WriteLine( "account2 balance: {0:C}", account2.Balance );

      Console.WriteLine( "\nCrediting {0:C} to account3.", 20 );
      account3.Credit( 20.0M );
      Console.WriteLine( "account3 balance: {0:C}", account3.Balance );

      // add interest to SavingsAccount object account2
      decimal interestEarned = account2.CalculateInterest();
      Console.WriteLine( "\nAdding {0:C} interest to account2.", interestEarned );
      account2.Credit( interestEarned );
      Console.WriteLine( "New account2 balance: {0:C}",account2.Balance );

      Console.WriteLine("\n\n\t\t-- Press any key to exit!");
       Console.ReadKey();

    } // end Main
} 
