// // Random dice = new();
// // int roll = dice.Next(1, 7);
// // Console.WriteLine(roll);

// // Random dice = new();
// // int roll1 = dice.Next();
// // int roll2 = dice.Next(101);
// // int roll3 = dice.Next(50, 101);

// // Console.WriteLine($"First roll: {roll1}");
// // Console.WriteLine($"Second roll: {roll2}");
// // Console.WriteLine($"Third roll: {roll3}");

// // int firstValue = 500;
// // int secondValue = 600;
// // int largerValue = Math.Max(firstValue, secondValue);

// // Console.WriteLine(largerValue);

// // Random dice = new Random();

// // int roll1 = dice.Next(1, 7);
// // int roll2 = dice.Next(1, 7);
// // int roll3 = dice.Next(1, 7);

// // int total = roll1 + roll2 + roll3;

// // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// // {
// //     if ((roll1 == roll2) && (roll2 == roll3))
// //     {
// //         Console.WriteLine("You rolled triples!  +6 bonus to total!");
// //         total += 6;
// //     }
// //     else
// //     {
// //         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
// //         total += 2;
// //     }

// //     Console.WriteLine($"Your total including the bonus: {total}");
// // }

// // if (total >= 16)
// // {
// //     Console.WriteLine("You win a new car!");
// // }
// // else if (total >= 10)
// // {
// //     Console.WriteLine("You win a new laptop!");
// // }
// // else if (total == 7)
// // {
// //     Console.WriteLine("You win a trip for two!");
// // }
// // else
// // {
// //     Console.WriteLine("You win a kitten!");
// // }

// // Random random = new();
// // int daysUntilExpiration = random.Next(12);
// // int discountPercentage = 0;

// // daysUntilExpiration = 5;
// // if (daysUntilExpiration  == 0)
// // {
// //     Console.WriteLine("Your subscription has expired.");
// // }
// // else if (daysUntilExpiration == 1)
// // {
// //     discountPercentage = 20;
// //     Console.WriteLine("Your subscription expires within a day!");
// // }
// // else if (daysUntilExpiration <= 5)
// // {
// //     discountPercentage = 10;
// //     Console.WriteLine("Your subscription expires in {daysUntilExpiration} days.");
// // }
// // else if (daysUntilExpiration <= 10)
// // {
// //     Console.WriteLine("Your subscription will expire soon. Renew now!");
// // }
// // if (discountPercentage > 0)
// // {
// //     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// // }

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// // These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b); // output: True
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2); // output: False

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
    


Random coin = new();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");