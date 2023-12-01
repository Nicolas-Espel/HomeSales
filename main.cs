//Nicolas Espel
using System;

class Program {
  public static void Main (string[] args) {
    int runningTotal = 0;
    int highestSale = 0;
    int danielleHighestSale = 0;
    int edwardHighestSale = 0;
    int francisHighestSale = 0;
    
    Console.WriteLine("Please enter the first name initial of who you'd like to work with! Either D, E or F, or enter Z to stop: ");
    char salesPerson = Convert.ToChar(Console.ReadLine());
    salesPerson = char.ToLower(salesPerson);

    while (salesPerson != 'z') {
      if (salesPerson != 'd' && salesPerson != 'e' && salesPerson != 'f') {
        Console.WriteLine("Error, invalid salesperson selected, please try again");
        salesPerson = Convert.ToChar(Console.ReadLine());
        salesPerson = char.ToLower(salesPerson);
      } else {
        Console.WriteLine("Please enter the sales price: ");
        int salesPrice = Convert.ToInt32(Console.ReadLine());
        
        runningTotal += salesPrice;
        if (salesPrice > highestSale) {
          highestSale = salesPrice;
        }
      
        switch(salesPerson) {
        case 'd':
          if (salesPrice > danielleHighestSale) {
            danielleHighestSale = salesPrice;
          }
          break;
        case 'e':
          if (salesPrice > edwardHighestSale) {
            edwardHighestSale = salesPrice;
          }
          break;
        case 'f':
          if (salesPrice > francisHighestSale) {
            francisHighestSale = salesPrice;
          }
          break;
        default:
          Console.WriteLine ("Error, invalid salesperson selected, please try again");
          break;
        }

      
        Console.WriteLine("Enter another salesperson, or Z to finish: ");
        salesPerson = Convert.ToChar(Console.ReadLine());
        salesPerson = char.ToLower(salesPerson);
        }
    }
    
    
    Console.WriteLine("Grand total: ${0}", runningTotal);
    if (danielleHighestSale == highestSale) {
      Console.WriteLine("Highest Sale: D");
    } else if (edwardHighestSale == highestSale) {
      Console.WriteLine("Highest Sale: E");
    } else {
      Console.WriteLine("Highest Sale: F");
    }
    
  }
}