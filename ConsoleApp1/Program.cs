﻿// // // // // // // // // // // Random dice = new Random();

// // // // // // // // // // // for (int i = 0; i < 100; i++) {
// // // // // // // // // // // int roll1 = dice.Next(1, 7);
// // // // // // // // // // // int roll2 = dice.Next(1, 7);
// // // // // // // // // // // int roll3 = dice.Next(1, 7);

// // // // // // // // // // // int total = roll1 + roll2 + roll3;

// // // // // // // // // // // Console.WriteLine($"\nDice roll:\n{roll1} + {roll2} + {roll3} = {total}\n");

// // // // // // // // // // // if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)) {
// // // // // // // // // // //     if ((roll1 == roll2) && (roll2 == roll3)) {
// // // // // // // // // // //     Console.WriteLine("You rolled triples! +6 bonus to total!");
// // // // // // // // // // //     total += 6;
// // // // // // // // // // // } else {
// // // // // // // // // // //     Console.WriteLine("You rolled Doubles! +2 bonus to total!");
// // // // // // // // // // //     total += 2;
// // // // // // // // // // // }
// // // // // // // // // // // }


// // // // // // // // // // // if (total >= 16) {
// // // // // // // // // // //     Console.WriteLine("You win a new car!");
// // // // // // // // // // // } else if (total >= 10) {
// // // // // // // // // // //     Console.WriteLine("You win a new laptop!");
// // // // // // // // // // // } else if (total == 7) {
// // // // // // // // // // //     Console.WriteLine("You win a trip for two!");
// // // // // // // // // // // } else {
// // // // // // // // // // //     Console.WriteLine("You win a kitten!");
// // // // // // // // // // // }
// // // // // // // // // // // }









// // // // // // // // // // Random rnd = new Random();
// // // // // // // // // // for (int i = 0; i < 10; i++) {
// // // // // // // // // // int dayToExpiration = rnd.Next(12);

// // // // // // // // // // int discountPercent = 0;

// // // // // // // // // // Console.WriteLine(dayToExpiration);

// // // // // // // // // // if (dayToExpiration <= 10 && dayToExpiration > 5) {
// // // // // // // // // //     Console.WriteLine("Your subscription will expire soon. Renew now!");

// // // // // // // // // // } else if (dayToExpiration <= 5 && dayToExpiration > 1) {
// // // // // // // // // //     Console.WriteLine($"Your subscription expires in {dayToExpiration} days.\nRenew now and save 10%!");
// // // // // // // // // //     discountPercent = 10;
// // // // // // // // // // } else if (dayToExpiration == 1) {
// // // // // // // // // //     Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%");
// // // // // // // // // //     discountPercent = 20;
// // // // // // // // // // } else if (dayToExpiration == 0) {
// // // // // // // // // //     Console.WriteLine("Your subscrition has expired.");
// // // // // // // // // // }
// // // // // // // // // // }






// // // // // // // // // string[] fradulentOrderIDs = {"A123", "B456", "C789"};

// // // // // // // // // // fradulentOrderIDs[0] = "A123";
// // // // // // // // // // fradulentOrderIDs[1] = "B456";
// // // // // // // // // // fradulentOrderIDs[2] = "C789";
// // // // // // // // // // fradulentOrderIDs[0] = "D101";

// // // // // // // // // for (int i = 0; i < fradulentOrderIDs.Length; i++) {
// // // // // // // // //     Console.WriteLine(fradulentOrderIDs[i]);
// // // // // // // // // }
// // // // // // // // // Console.WriteLine($"There are {fradulentOrderIDs.Length} fradulent orders to process.");



// // // // // // // // string[] names = {"Mwansa", "Lahana", "Dominick"};

// // // // // // // // foreach (string name in names) {
// // // // // // // //     Console.WriteLine(name);
// // // // // // // // }



// // // // // // // int[] inventory = [200, 400, 600, 100, 200];

// // // // // // // int sum = 0;

// // // // // // // int bin = 0;

// // // // // // // foreach (int i in inventory) {
// // // // // // //     sum += i;
// // // // // // //     bin++;
// // // // // // // Console.WriteLine($"Bin {bin} = {i} items (Running total: {sum})");
// // // // // // // }

// // // // // // // Console.WriteLine($"We have {sum} items in inventory.");




// // // // // // string[] fraud = {
// // // // // // "B123",
// // // // // // "C234",
// // // // // // "A345",
// // // // // // "C15",
// // // // // // "B177",
// // // // // // "G3003",
// // // // // // "C235",
// // // // // // "B179",
// // // // // // };

// // // // // // // string[] fraudB = [];
// // // // // // foreach (string i in fraud) {
// // // // // //     if (i.StartsWith("B")) {
// // // // // //         Console.WriteLine($"The name {i} starts with a 'B'!");
// // // // // //         // fraudB.insert() i;
// // // // // //     }
// // // // // // }
// // // // // // public return_type function_name(parameters) {
// // // // // //   // function body
// // // // // //   return value;
// // // // // // }

// // // // // //comment





// // // // // Random dice = new Random();
// // // // // int roll1 = dice.Next(1, 7);
// // // // // int roll2 = dice.Next(1, 7);
// // // // // int roll3 = dice.Next(1, 7);
// // // // // int total = roll1 + roll2 + roll3;


// // // // // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // // // // if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {

// // // // //     if ((roll1 == roll2) && (roll2 == roll3)) {

// // // // //         Console.WriteLine("You rolled triples!  +6 bonus to total!");

// // // // //         total += 6;

// // // // //     } else {

// // // // //         Console.WriteLine("You rolled doubles!  +2 bonus to total!");

// // // // //         total += 2;

// // // // //     }

// // // // // }


// // // // // string str = "The quick brown fox jumps over the lazy dog.";

// // // // // char[] charMessage = str.ToCharArray();

// // // // // Array.Reverse(charMessage);

// // // // // int x = 0;

// // // // // // count the o's
// // // // // foreach (char i in charMessage) {

// // // // //      if (i == 'o') { x++; }

// // // // // }

// // // // // // convert it back to a string
// // // // // string new_message = new String(charMessage);

// // // // // Console.WriteLine(new_message);
// // // // // Console.WriteLine($"'o' appears {x} times.");







// // // // //student grades
// // // // int[] student1 = { 90, 86, 87, 98, 100, 94, 90 };
// // // // int[] student2 = { 92, 89, 81, 96, 90, 89 };
// // // // int[] student3 = { 90, 85, 87, 98, 68, 89, 89, 89 };
// // // // int[] student4 = { 90, 95, 87, 88, 96, 96 };

// // // // string[] names = { "Sophia", "Andrew", "Emma", "Logan" };
// // // // string letter = "";


// // // // //make a nested array of all the students grades
// // // // int[][] grades = new int[][] { student1, student2, student3, student4 };

// // // // Console.WriteLine("Student\t\tOverall Grade\tExam Grade\tExtra Credit Grade");

// // // // //call the function with each array as input.
// // // // for (int i = 0; i < grades.Length; i++)
// // // // {
// // // //     string name = names[i];
// // // //     var (Average, OverallGrade, ExtraCreditGrade) = getAverageGrade(grades[i]);

// // // //     if (Average >= 97)
// // // //     {
// // // //         letter = "A+";
// // // //     }
// // // //     else if (Average >= 93)
// // // //     {
// // // //         letter = "A";
// // // //     }
// // // //     else if (Average >= 90)
// // // //     {
// // // //         letter = "A-";
// // // //     }
// // // //     else if (Average >= 87)
// // // //     {
// // // //         letter = "B+";
// // // //     }
// // // //     else if (Average >= 83)
// // // //     {
// // // //         letter = "B";
// // // //     }
// // // //     else if (Average >= 80)
// // // //     {
// // // //         letter = "B-";
// // // //     }
// // // //     else if (Average >= 77)
// // // //     {
// // // //         letter = "C+";
// // // //     }
// // // //     else if (Average >= 73)
// // // //     {
// // // //         letter = "C";
// // // //     }
// // // //     else if (Average >= 70)
// // // //     {
// // // //         letter = "C-";
// // // //     }
// // // //     else if (Average >= 67)
// // // //     {
// // // //         letter = "D+";
// // // //     }
// // // //     else if (Average >= 63)
// // // //     {
// // // //         letter = "D";
// // // //     }
// // // //     else if (Average >= 60)
// // // //     {
// // // //         letter = "D-";
// // // //     }
// // // //     else if (Average < 60)
// // // //     {
// // // //         letter = "F";
// // // //     }
// // // //     Console.WriteLine($"{name}:\t\t{OverallGrade}\t{letter}\t{Average}\t\t{ExtraCreditGrade}");

// // // // }

// // // // Console.WriteLine("Press Enter to continue");
// // // // // Console.ReadLine();

// // // // static (double Average, double OverallGrade, double ExtraCreditGrade) getAverageGrade(int[] grades)
// // // // {
// // // //     int numOfExtraAssignments = 0;
// // // //     int regularGrade = 0;
// // // //     int extraCreditGrade = 0;
// // // //     int counter = 0;
// // // //     double sumOfRegAndExtraCredit = 0;

// // // //     foreach (int grade in grades)
// // // //     {
// // // //         if (counter < 5)
// // // //         {
// // // //             sumOfRegAndExtraCredit += grade;
// // // //             regularGrade += grade;
// // // //         }
// // // //         else
// // // //         {
// // // //             sumOfRegAndExtraCredit += grade / 10;
// // // //             extraCreditGrade += grade;
// // // //             numOfExtraAssignments++;
// // // //         }
// // // //         counter++;
// // // //     }

// // // //     double OverallGrade = sumOfRegAndExtraCredit / 5;
// // // //     double Average = regularGrade / 5;
// // // //     double ExtraCreditGrade = extraCreditGrade / numOfExtraAssignments;
// // // //     return (Average, OverallGrade, ExtraCreditGrade);
// // // // }




























// // // Console.WriteLine("a" == "a");
// // // Console.WriteLine("a" == "A");
// // // Console.WriteLine(1 == 2);

// // // string myValue = "a";
// // // Console.WriteLine(myValue == "a");







// // using System.Diagnostics;



// // Stopwatch watch = Stopwatch.StartNew();

// // Random rnd = new Random();
// // for (int j = 0; j < 1000000; j++)
// // {

// //     int headsCount = 0;
// //     int tailsCount = 0;
// //     for (int i = 0; i < 1000; i++)
// //     {
// //         int flip = rnd.Next(2);
// //         if (flip == 1)
// //         {
// //             headsCount++;
// //         }
// //         else
// //         {
// //             tailsCount++;
// //         }
// //     }

// //     Console.WriteLine($"Heads Count: {headsCount}.\nTails Count: {tailsCount}");
// //     Console.WriteLine($"Time: {watch.ElapsedMilliseconds}");
// // }










// string permission = "Admin|Manager";
// int level = 55;

// if (level > 55 && permission.Contains("Admin"))
// {
//     Console.WriteLine("Welcome, Super Admin user.");
// }
// else if (level <= 55 && permission.Contains("Admin"))
// {
//     Console.WriteLine("Welcome, Admin user.");
// }
// else if (level >= 20 && permission.Contains("Manager"))
// {
//     Console.WriteLine("Contact an Admin for access");
// }
// else if (level < 20 && permission.Contains("Manager"))
// {
//     Console.WriteLine("You do not have sufficent privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficent priveleges.");
// }




// if (true)
// {
//     int value = 10;
//     Console.WriteLine(value);
// }

// Console.WriteLine(value);




// bool flag = true;
// if (flag) Console.WriteLine(flag);



// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {

//     total += number;

//     if (number == 42)
//     {
//         found = true;

//     }

// }

// if (found)
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");

// string str = "apple";


// switch (str)
// {
//     case "apple":
//         Console.WriteLine($"App will display information for apple.");
//         break;
//     case "banana":
//         Console.WriteLine($"App will display information on banana.");
//         break;
//     case "cherry":
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }


// int employeeLevel = 100;
// string employeeName = "John Smith";
// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         // title = "Junior Associate";
//         // break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manger";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");



// SKU = Stock Keeping Unit.
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// type = product[0] switch
// {
//     "01" => "Sweat shirt",
//     "02" => "T=Shirt",
//     "03" => "Sweat pants",
//     _ => "Other",
// };

// color = product[1] switch
// {
//     "BL" => "Black",
//     "MN" => "Maroon",
//     _ => "White",
// };

// size = product[2] switch
// {
//     "S" => "Small",
//     "M" => "Medium",
//     "L" => "Large",
//     _ => "One Size Fits All",
// };

// Console.WriteLine($"Product: {size} {color} {type}");



// for (int i = 10; i > 0; i -= 3)
// {
//     Console.WriteLine(i);
//     if (i == 4) break;
// }



// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }


// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }




// using System.Formats.Asn1;

// int val = 0;

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }

// }



// do
// {
//     Console.WriteLine("Hello");
// } while (Console.ReadKey(true).Key != ConsoleKey.Q);


// Random rnd = new Random();

// int current = rnd.Next(1,11);

// // do
// // {
// //     current = rnd.Next(1,11);
// //     Console.WriteLine(current);

// // }  while (current < 11) ;


// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = rnd.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");


// Random rnd = new Random();

// int current = rnd.Next(1,11);

// do{
//     current = rnd.Next(1,11);

//     if (current >= 3 ) continue;

//     Console.WriteLine(current);

// } while (current != 7);



// int heroScore = 10;

// int badGuyScore = 10;

// Random rnd = new Random();

// do
// {
//     int heroDamage = rnd.Next(1, 11);
//     int badGuyDamage = rnd.Next(1, 11);

//     Console.WriteLine($"Hero Health: {heroScore}\nBadguy Health: {badGuyScore}");

//     heroScore -= heroDamage;
//     badGuyScore -= badGuyDamage;

//     Console.WriteLine($"Hero Damage taken: {heroDamage}");
//     Console.WriteLine($"Badguy Damage taken: {badGuyDamage}");

// } while (heroScore > 0 && badGuyScore > 0);

// if (heroScore <= 0)
// {
//     Console.WriteLine($"BadGuy Won!\nBadGuy Health: {badGuyScore}\nGoodGuy Health: {heroScore}");

// }
// else
// {
//     Console.WriteLine($"GoodGuy Won!\nGoodGuy Health: {heroScore}\nBadGuy Health: {badGuyScore}");
// }


// List<string> petsNameArray = new List<string> { "Shadow", "Trixie", "Kiba", "Morty" };
// bool qPressed = false;
// string answer = "";
// string addoptedPet = "";
// string newPet = "";


// while (qPressed == false)
// {
// Console.WriteLine("\nWelcome to Dominick's Pet Application\n1: List pets\n2: Adopt a pet\n3: Add a pet\nPress Q to quit.");
// answer = Console.ReadLine();

// if (answer.ToLower() == "q")
// {
//     Console.WriteLine("Quitting...");
//     qPressed = true;
//     break;

// } else if (answer == "1")
// {
//     Console.WriteLine("\nPets available for adoption:");

//     foreach( string pet in petsNameArray)
//     {
//         Console.WriteLine(pet);

//     }
// } else if (answer == "2")
// {
//    Console.WriteLine("Which Pet would you like to addpot?");

//         foreach (string pet in petsNameArray)
//         {
//             Console.WriteLine(pet);

//         }

//     Console.WriteLine("Enter the name of the pet you'd like to adopt.");

//     string petToAdopt = Console.ReadLine().ToLower();

//     for (int i = 0; i < petsNameArray.Count; i++)
//         {
//             if (petToAdopt == petsNameArray[i].ToLower()){
//                     Console.WriteLine($"You choose to adopt {petToAdopt}!\nCongratulations and thank you!");
//                     petsNameArray.RemoveAt(i);
//                     break;
//             } else
//             {
//                 Console.WriteLine("Please enter a valid pet name.");
//                 break;
//             }
//         }
// } else if (answer == "3")
// {
//     Console.WriteLine("Enter the name of a pet you'd like to list for adoption");
//     newPet = Console.ReadLine();

//     foreach (string pet in petsNameArray)
//     {
//         if (pet == newPet)
//         {
//             newPet = newPet + " 1";
//         }
//     }

//         petsNameArray.Add(newPet);

//     Console.WriteLine($"You have added {newPet} to the adoption list.");

// }else
// {
//     Console.WriteLine("Please enter a valid option.");
// }
// }






// // the ourAnimals array will store the following:
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";
// int animalCount = 0;

// // variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";
// string? animalNameToAdd;
// string? catOrDog;
// string? descriptionOfPetToAdd;
// string? personalityOfPetToAdd;
// string? age;
// string anotherPet = "y";

// // array used to store runtime data, there is no persisted data
// string[,] ourAnimals = new string[maxPets, 6];

// // TODO: Convert the if-elseif-else construct to a switch statement

// // create some initial ourAnimals array entries
// for (int i = 0; i < maxPets; i++)
// {
//     switch (i)
//     {
//         case 0:
//             animalSpecies = "dog";
//             animalID = "d1";
//             animalAge = "2";
//             animalPhysicalDescription =
//                 "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
//             animalPersonalityDescription =
//                 "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//             animalNickname = "lola";
//             break;

//         case 1:
//             animalSpecies = "dog";
//             animalID = "d2";
//             animalAge = "9";
//             animalPhysicalDescription =
//                 "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//             animalPersonalityDescription =
//                 "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//             animalNickname = "loki";
//             break;

//         case 2:
//             animalSpecies = "cat";
//             animalID = "c3";
//             animalAge = "1";
//             animalPhysicalDescription =
//                 "small white female weighing about 8 pounds. litter box trained.";
//             animalPersonalityDescription = "friendly";
//             animalNickname = "Puss";
//             break;

//         case 3:
//             animalSpecies = "cat";
//             animalID = "c4";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             break;

//         default:
//             animalSpecies = "";
//             animalID = "";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             break;
//     }

//     ourAnimals[i, 0] = "ID #: " + animalID;
//     ourAnimals[i, 1] = "Species: " + animalSpecies;
//     ourAnimals[i, 2] = "Age: " + animalAge;
//     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
// }

// // display the top-level menu options
// do
// {
//     Console.Clear();

//     anotherPet = "y";

//     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//     Console.WriteLine(" 1. List all of our current pet information");
//     Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
//     Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
//     Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
//     Console.WriteLine(" 5. Edit an animal’s age");
//     Console.WriteLine(" 6. Edit an animal’s personality description");
//     Console.WriteLine(" 7. Display all cats with a specified characteristic");
//     Console.WriteLine(" 8. Display all dogs with a specified characteristic\n");
//     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         menuSelection = readResult.ToLower();
//     }

//     switch (menuSelection)
//     {
//         case "1":
//             for (int i = 0; i < maxPets; i++)
//             {
//                 Console.WriteLine();
//                 for (int j = 0; j < 6; j++)
//                 {
//                     //filter empty entries
//                     if (ourAnimals[i, 0] != "ID #: ")
//                         Console.WriteLine(ourAnimals[i, j]);
//                 }
//             }
//             break;

//         case "2":

//             animalCount = 0;

//             //count how many animals are currently up for adoption.
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     animalCount++;
//                 }
//             }

//             while (anotherPet == "y")
//             {
//                 if (animalCount >= maxPets)
//                 {
//                     Console.WriteLine("\nSorry we don't have any more spots available.\n");
//                     break;
//                 }
//                 int animalSpacesLeft = maxPets - animalCount;

//                 Console.WriteLine(
//                     $"\nThere are {animalCount} pets up for adoption.\nWe have {animalSpacesLeft} spots left.\n"
//                 );

//                 Console.WriteLine("Enter name of pet to add.");
//                 animalNameToAdd = Console.ReadLine();

//                 Console.WriteLine("Enter dog or cat.");
//                 catOrDog = Console.ReadLine();

//                 Console.WriteLine("Enter age.");
//                 age = Console.ReadLine();

//                 Console.WriteLine("Write a phsical description for the pet.");
//                 descriptionOfPetToAdd = Console.ReadLine();

//                 Console.WriteLine("Enter the personality of the pet.");
//                 personalityOfPetToAdd = Console.ReadLine();

//                 // add one to animalCount so we can add the next pet to the next availavle position.
//                 animalCount++;
//                 int index = animalCount - 1;

//                 if (index <= maxPets)
//                 {
//                     if (catOrDog.ToLower() == "dog" || catOrDog.ToLower() == "d")
//                     {
//                         ourAnimals[index, 0] = "ID #: " + "d" + (animalCount);
//                     }
//                     else if (catOrDog.ToLower() == "cat")
//                     {
//                         ourAnimals[index, 0] = "ID #: " + "c" + (animalCount);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Input not valid. Please enter either cat or dog.");
//                     }

//                     ourAnimals[index, 1] = "Species: " + catOrDog;
//                     ourAnimals[index, 2] = "Age: " + age;
//                     ourAnimals[index, 3] = "Nickname: " + animalNameToAdd;
//                     ourAnimals[index, 4] = "Physical description: " + descriptionOfPetToAdd;
//                     ourAnimals[index, 5] = "Personality: " + personalityOfPetToAdd;

//                     Console.WriteLine("Would you like to add another pet? y or n");
//                     anotherPet = Console.ReadLine();
//                 }
//             }
//             break;

//         case "3":
//             for (int i = 0; i < maxPets; i++)
//             {
//                 //filter empty entries
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     if (ourAnimals[i, 2] == "Age: " || ourAnimals[i, 4] == "Physical description: ")
//                     {
//                         Console.WriteLine(
//                             $"Animal {ourAnimals[i, 0]} has incomplete age or physical description."
//                         );
//                     }
//                 }
//             }
//             Console.WriteLine("Scan Complete.");
//             break;

//         case "4":
//             for (int i = 0; i < maxPets; i++)
//             {
//                 //filter empty entries
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     if (ourAnimals[i, 3] == "Nickname: " || ourAnimals[i, 5] == "Personality: ")
//                     {
//                         Console.WriteLine(
//                             $"Animal {ourAnimals[i, 0]} has incomplete name or personality description."
//                         );
//                     }
//                 }
//             }
//             Console.WriteLine("Scan Complete.");
//             break;

//         case "5":
//             Console.WriteLine("Enter the animal id to edit the age.");
//             string? animalIdToEditAge = Console.ReadLine();
//             Console.WriteLine("Enter new age.");
//             string? newAge = Console.ReadLine();

//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] == "ID #: " + animalIdToEditAge)
//                 {
//                     ourAnimals[i, 2] = "Age: " + newAge;
//                 }
//             }

//             break;

//         case "6":
//             Console.WriteLine("Enter the animal id to edit personality.");
//             animalIdToEditAge = Console.ReadLine();
//             Console.WriteLine("Enter new personality description.");
//             string? newPersonality = Console.ReadLine();

//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] == "ID #: " + animalIdToEditAge)
//                 {
//                     ourAnimals[i, 5] = "Personality: " + newPersonality;
//                 }
//             }

//             break;

//         case "7":
//             Console.WriteLine("Listing of all cats");
//             for (int i = 0; i < maxPets; i++)
//             {
//                 for (int j = 0; j < 6; j++)
//                 {
//                     if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 1] == "Species: cat")
//                     {
//                         Console.WriteLine(ourAnimals[i, j]);
//                     }
//                 }
//             }
//             break;

//         case "8":
//             Console.WriteLine("Listing of all dogs");
//             for (int i = 0; i < maxPets; i++)
//             {
//                 for (int j = 0; j < 6; j++)
//                 {
//                     if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 1] == "Species: dog")
//                     {
//                         Console.WriteLine(ourAnimals[i, j]);
//                     }
//                 }
//             }
//             break;

//         default:
//             break;
//     }

//     Console.WriteLine($"\nYou selected menu option {menuSelection}.");
//     Console.WriteLine("Press the Enter key to continue");

//     // pause code execution
//     readResult = Console.ReadLine();
// } while (menuSelection != "exit");










// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}\n");


// Console.WriteLine($"Unsigned integral types");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


// Console.WriteLine($"");
// Console.WriteLine($"Floating point types: ");

// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue}");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");














// int[] data = new int[3];

// string str = "Hi!";

// Console.WriteLine(str);














// string? menuSelection;

// string dateTime;
// int age;
// int height;
// int weight;
// int pulse;
// int bloodPressure;



// do
// {
//     Console.WriteLine(
//         "\nWelcome to Dominick's Medical Input System!\nHope you are ready to kick ass and heal patients!!! Let's go!!!!\n"
//     );
//     Console.WriteLine("1: View all patient");
//     Console.WriteLine("2: Start new patient intake process");
//     Console.WriteLine("3: See patientis with incomplete data");
//     Console.WriteLine("4: Edit Patient data\n");

//     menuSelection = Console.ReadLine();
// } while (!menuSelection.Equals("exit", StringComparison.CurrentCultureIgnoreCase));

// Console.WriteLine("\nGoodbye :)\nThank you for using Dominick's Medical Input System!!!\n");






// string first = "second 2";
// string second = "4";

// int result = int.TryParse(first) + int.TryParse(second);
// Console.WriteLine(result);



// decimal myDecimal = 3.14m;
// Console.WriteLine($"My decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");





// string val1 = "5";
// string val2 = "7";

// int result = Convert.ToInt32(val1) * Convert.ToInt32(val2);

// Console.WriteLine(result);





// int value = (int)1.5m;
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m);
// Console.WriteLine(value2);








// string name = "bob";
// int nameToInt = 0;
// if (int.TryParse(name, out nameToInt))
// {
//     Console.WriteLine($"Measurement: {nameToInt}");
// } else
// {
//     Console.WriteLine($"Unable to report the measurement.");
// }

// if (nameToInt > 0)
// {
// Console.WriteLine($"Measurment of (w/ offset): {50 + nameToInt}");
// }









// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string outString = "";
// decimal resultDecimal = 0.0m;

// for (int i = 0; i < values.Length; i++)
// {
//     decimal outDecimal;

//     if (decimal.TryParse(values[i], out outDecimal))
//     {
//         resultDecimal += outDecimal;
//     }
//     else
//     {
//         outString += values[i];
//     }
// }

// Console.WriteLine($"Message : {outString}");
// Console.WriteLine($"Decimal : {resultDecimal}");










// int value2 = Convert.ToInt32(1.5m);

// int val1 = 12;
// decimal val2 = 6.2m;
// float val3 = 4.3f;


// decimal val1Decimal = (decimal)val1;
// decimal val3Decimal = (decimal)val3;

// decimal result1Decimal = val1Decimal /val2;
// int result1Int = Convert.ToInt32(result1Decimal);

// decimal result2 = val2 /val3Decimal;

// decimal result3 = val3Decimal /val1Decimal;
// float result3Float = (float)result3;


// Console.WriteLine($"Divide val1 by val2, result: {result1Int}");

// Console.WriteLine($"Divide val2 by val3, result: {result2}");

// Console.WriteLine($"Divide val3 by val1, result: {result3Float}");





// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");

// Array.Sort(pallets);

// for (int i = 0; i < pallets.Length; i++)
// {
//     Console.WriteLine($"-- {pallets[i]}");
// }

// Console.WriteLine("Reversed...");

// Array.Reverse(pallets);

// foreach (string pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }




// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//     Console.WriteLine($"after: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }












// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");

// Array.Resize(ref pallets, 6);

// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");

// Array.Resize(ref pallets, 3);

// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }











// string val = "abc123";
// Console.WriteLine("");

// Console.WriteLine($"Original string: {val}");
// Console.WriteLine("");

// char[] valArr = val.ToCharArray();

// foreach (char value in valArr)
//     Console.WriteLine($"ValArr character array: {value}");
// Console.WriteLine("");

// Array.Reverse(valArr);

// foreach (char value in valArr)
//     Console.WriteLine($"ValArr character array Reversed: {value}");

// string result = String.Join("", valArr);
// Console.WriteLine("");

// Console.WriteLine($"Reversed and joined: {result}");
// Console.WriteLine("");











// string pangram = "The quick brown fox jumps over the lazy dog";

// //split words up into elements in an array
// string[] pangramStrArr = pangram.Split(" ");

// //initialize jagged char array to store str arr elements into
// char[][] pangramCharArr = new char[pangramStrArr.Length][];

// string[] result = new string[pangramCharArr.Length];

// //loop through string array and add each word into a char array
// //then reverse the char arrays
// for (int i = 0; i < pangramCharArr.Length; i++)
// {
//     pangramCharArr[i] = pangramStrArr[i].ToCharArray();
//     Array.Reverse(pangramCharArr[i]);
//     result[i] = string.Join("", pangramCharArr[i]);
// }

// string answer = string.Join(" ", result);

// Console.WriteLine(answer);





















// using System.ComponentModel;

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderStreamArr = orderStream.Split(",");

// Array.Sort(orderStreamArr);

// for (int i = 0; i < orderStreamArr.Length; i++)
// {
//     if (orderStreamArr[i].Length != 4)
//     {
//         orderStreamArr[i] += "\t- Error";
//     }
//     Console.WriteLine(orderStreamArr[i]);
// }












// decimal price = 123.45m;
// int discount = 50;

// Console.WriteLine($"Price: {price:C} (Save {discount:C})");



// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");



// decimal tax = .36785m;

// Console.WriteLine($"Tax rate: {tax:P2}");







// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);


// yourDiscount += $" A discount of {((price -salePrice)/price):P2}";
// Console.WriteLine(yourDiscount);


















// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"\tShares: {productShares:N3} Product");
// Console.WriteLine($"\tSub Total: {subtotal:C}");
// Console.WriteLine($"\tTax: {taxPercentage:P2}");
// Console.WriteLine($"\tTotal Billed: {total:C}");




// string input = "Pad This";
// Console.WriteLine(input.PadRight(12, '-'));








// string paymentID = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentID.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);





// string name = "Ms. Barros";
// string currentProduct = "Magic Yield";
// string newProduct = "Glorious Future";
// int amountOwnedShares = 2975000;
// decimal returnPercentage = 0.1275m;
// decimal newReturnPercentage = 0.13125m;
// decimal newProfit = 63000000m;
// decimal profit = 55000000m;

// Console.WriteLine($"Dear {name},");
// Console.WriteLine(
//     $"As a customer of our {currentProduct} we are excited to tell you about a new financial product that would dramatically increase your return."
// );
// Console.WriteLine("");
// Console.WriteLine(
//     $"Currently, you own {amountOwnedShares:N2} shares at a return of {returnPercentage:P2}"
// );
// Console.WriteLine("");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturnPercentage:P2}. Given your current volume, your potential profit would be {newProfit:C2}");
// Console.WriteLine("");
// Console.WriteLine("Here's a quick comparison:");
// Console.WriteLine("");
// Console.WriteLine($"{currentProduct}\t\t{returnPercentage:P2}\t{profit:C2}");
// Console.WriteLine($"{newProduct}\t\t{newReturnPercentage:P2}\t{newProfit:C2}");
















// string message = "Find what is (inside of the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition + 1, length - 1));


// string openSpan = "<span>";
// string closeSpan = "</span>";

// string message = "what i sthe value of <span>between the tags</span>";

// int openPosition = message.IndexOf(openSpan);
// int closePosition = message.IndexOf(closeSpan);

// openPosition += openSpan.Length;
// int length = closePosition - openPosition;

// Console.WriteLine(message.Substring(openPosition, length));





// string message = "(What if) I am (only interested) in the last (set of parentheses)?";

// while (true)
// {
//     int openPosition = message.IndexOf('(');
//     if (openPosition == -1)
//         break;

//     openPosition++;
//     int closePosition = message.IndexOf(')');
//     int length = closePosition - openPosition;

//     Console.WriteLine(message.Substring(openPosition, length));

//     message = message.Substring(closePosition + 1);
// }










// string message = "Help (find) the {opening symbols}";

// Console.WriteLine($"Searching This Message: {message}");

// char[] openSymbols = {'[', '{', '('};

// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);

// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {startPosition}: {message.Substring(openingPosition)}");












// string data = "12345John Smith          5000  3  ";

// string updatedData = data.Remove(5, 20);

// Console.WriteLine(updatedData);


// string message = "This--is--ex-amp-le--da-ta";

// message = message.Replace("--", " ");
// message = message.Replace("-", "");

// Console.WriteLine(message);









// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// //find quantity inside of span
// int spanIndexStart = input.IndexOf("<span>");
// spanIndexStart += 6;
// int spanIndexEnd = input.IndexOf("</span>");
// int spanIndexLength = spanIndexEnd - spanIndexStart;

// quantity = input.Substring(spanIndexStart, spanIndexLength);

// //remove div's
// int divStartIndex = input.IndexOf("<div>");

// output = input.Remove(divStartIndex, 5);

// int divEndIndex = output.IndexOf("</div>");

// output = output.Remove(divEndIndex, 6);

// //replace trade with reg... obviouslys......
// output = output.Replace("&trade;", "&reg;");

// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine($"Output: {output}");






// #1 the ourAnimals array will store the following:
// using System.Runtime.Intrinsics.Arm;

// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";
// string suggestedDonation = "";

// decimal decimalDonation = 0.00m;
// bool containsSearchTermBool = false;

// // #2 variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";

// string personalityAndDescrition = "";

// string[] searchIcons = {".", ",", "..", "..."};

// // #3 array used to store runtime data, there is no persisted data
// string[,] ourAnimals = new string[maxPets, 7];

// // #4 create sample data ourAnimals array entries
// for (int i = 0; i < maxPets; i++)
// {
//     switch (i)
//     {
//         case 0:
//             animalSpecies = "dog";
//             animalID = "d1";
//             animalAge = "2";
//             animalPhysicalDescription =
//                 "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
//             animalPersonalityDescription =
//                 "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
//             animalNickname = "lola";
//             suggestedDonation = "100";
//             break;

//         case 1:
//             animalSpecies = "dog";
//             animalID = "d2";
//             animalAge = "9";
//             animalPhysicalDescription =
//                 "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
//             animalPersonalityDescription =
//                 "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
//             animalNickname = "gus";
//             suggestedDonation = "100";

//             break;

//         case 2:
//             animalSpecies = "cat";
//             animalID = "c3";
//             animalAge = "1";
//             animalPhysicalDescription =
//                 "small white female weighing about 8 pounds. litter box trained.";
//             animalPersonalityDescription = "friendly";
//             animalNickname = "snow";
//             suggestedDonation = "100";

//             break;

//         case 3:
//             animalSpecies = "cat";
//             animalID = "c4";
//             animalAge = "3";
//             animalPhysicalDescription =
//                 "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
//             animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
//             animalNickname = "Lion";
//             suggestedDonation = "100";

//             break;

//         default:
//             animalSpecies = "";
//             animalID = "";
//             animalAge = "";
//             animalPhysicalDescription = "";
//             animalPersonalityDescription = "";
//             animalNickname = "";
//             suggestedDonation = "";
//             break;
//     }

//     if (!decimal.TryParse(suggestedDonation, out decimalDonation))
//         decimalDonation = 45.00m;

//     ourAnimals[i, 0] = "ID #: " + animalID;
//     ourAnimals[i, 1] = "Species: " + animalSpecies;
//     ourAnimals[i, 2] = "Age: " + animalAge;
//     ourAnimals[i, 3] = "Nickname: " + animalNickname;
//     ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
//     ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
//     ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
// }

// // #5 display the top-level menu options
// do
// {
//     // NOTE: the Console.Clear method is throwing an exception in debug sessions
//     Console.Clear();

//     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
//     Console.WriteLine(" 1. List all of our current pet information");
//     Console.WriteLine(" 2. Display all dogs with a specified characteristic");
//     Console.WriteLine();
//     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

//     readResult = Console.ReadLine();
//     if (readResult != null)
//         menuSelection = readResult.ToLower();

//     // use switch-case to process the selected menu option
//     switch (menuSelection)
//     {
//         case "1":
//             // list all pet info
//             for (int i = 0; i < maxPets; i++)
//             {
//                 if (ourAnimals[i, 0] != "ID #: ")
//                 {
//                     Console.WriteLine();
//                     for (int j = 0; j < 7; j++)
//                     {
//                         Console.WriteLine(ourAnimals[i, j]);
//                     }
//                 }
//             }
//             Console.WriteLine("\n\rPress the Enter key to continue");
//             readResult = Console.ReadLine();

//             break;

//         case "2":

//             string[] searchTermSplit;

//             // Display all dogs with a specified characteristic
//             Console.WriteLine("Enter search term(s) for pet. seperate by \",\"");
//             string searchTerm = Console.ReadLine();

//             //reset contains search term to false every time you reenter the #2 option menu
//             containsSearchTermBool = false;
//             if (searchTerm.Trim() != "")
//             {
//                 for (int i = 0; i < ourAnimals.GetLength(0); i++)
//                 {
//                     if (ourAnimals[i, 0] != "ID #: ")
//                     {
//                         personalityAndDescrition =
//                             ourAnimals[i, 4].Substring(21) + " " + ourAnimals[i, 5].Substring(12);

//                         string species = ourAnimals[i, 1].Substring(9);
//                         string name = ourAnimals[i, 3].Substring(10);

//                         //split up the search term into an array of search terms.
//                         searchTermSplit = searchTerm.Split(",");
//                         Array.Sort(searchTermSplit);

//                         foreach (var term in searchTermSplit)
//                         {
//                             if (personalityAndDescrition.ToLower().Contains(term.ToLower()))
//                             {
//                                 Console.WriteLine(
//                                     $"\nOur {species} {name} is a match for your search for {term}!"
//                                 );
//                                 Console.WriteLine($"{ourAnimals[i, 3]} ({ourAnimals[i, 0]})");
//                                 Console.WriteLine(ourAnimals[i, 4]);
//                                 Console.WriteLine(ourAnimals[i, 5]);

//                                 containsSearchTermBool = true;
//                             }
//                         }
//                     }
//                 }
//                 if (containsSearchTermBool == false)
//                     Console.WriteLine($"\nNo pets match the search term(s) {searchTerm}.");
//             }
//             else if (searchTerm.Trim() == "")
//                 Console.WriteLine("No input, Please enter a valid search term.");

//             Console.WriteLine("\rPress the Enter key to continue");
//             readResult = Console.ReadLine();
//             break;

//         default:
//             break;
//     }
// } while (menuSelection != "exit");













// void SayHello()
// {
//     Console.WriteLine("Hello");
// }

// SayHello();



// int[] a = {1,2,3,4,5};

// Console.WriteLine("Contents of Array:");
// PrintArray();

// void PrintArray()
// {
//     foreach (int x in a)
//         Console.WriteLine($"{x} ");

//     Console.WriteLine();
// }



// void DisplayRandomNumber(string n)
// {
//     int newN = int.Parse(n);
//     Console.WriteLine("Generating Random Numbers between 0 and n.");
//     for (int i = 0; i < 10; i++)
//     {
//         // int rnd = Random.Shared.Next(n);
//         Console.WriteLine(Random.Shared.Next(newN));
//     }
// }

// Console.WriteLine("Enter a integer number to generate a random number between 0 and n.");
// string n = Console.ReadLine();
// DisplayRandomNumber(n);







// using System;

// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// DisplayMedicineTimes();
// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// TimeDiff(newGMT, currentGMT);
// Console.WriteLine("New Medicine Schedule:");

// DisplayMedicineTimes();
// Console.WriteLine();

// void TimeDiff(int newGMT, int currentGMT)
// {
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//         /* Adjust the times by adding the difference, keeping the value within 24 hours */
//         for (int i = 0; i < times.Length; i++)
//         {
//             times[i] = ((times[i] + diff)) % 2400;
//         }
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//         /* Adjust the times by adding the difference, keeping the value within 24 hours */
//         for (int i = 0; i < times.Length; i++)
//         {
//             times[i] = ((times[i] + diff)) % 2400;
//         }
//     }
// }

// void DisplayMedicineTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
// }





// Console.WriteLine("Enter ip address: ");
// string ipAddress = Console.ReadLine();
// int dotCount = 0;
// string[] ipAddressArray = ipAddress.Split(".");
// int[] resultArray = new int[4];

// for (int i = 0, j = 0; i < ipAddressArray.Length && j < resultArray.Length; i++)
// {
//     {
//         if (ipAddressArray[i] == ".")
//         {
//             dotCount++;
//         }
//         else
//         {
//             int result;
//             if (int.TryParse(ipAddressArray[i], out result))
//             {
//                 resultArray[j] = result;
//                 j++;
//             }
//         }
//     }
// }

// for (int k = 0; k < resultArray.Length; k++)
// {
//     if (resultArray[0] < 1 || resultArray[0] > 255)
//     {
//         Console.WriteLine("First number has to be between 1 and 255");
//         break;
//     }
//     else if (resultArray[k] < 0 || resultArray[k] > 255)
//     {
//         Console.WriteLine($"Number index {k} has to be between 0 and 255");
//         break;
//     } else
//     {
//         Console.WriteLine($"The ip address {ipAddress} entered is in the correct format");
//         break;
//     }
// }

// Random random = new Random();
// int luck = random.Next(100);

// void TellFortune(int l)
// {
//     string[] text =
//     {
//         "You have much to",
//         "Today is a day to",
//         "Whatever work you do",
//         "This is an ideal time to"
//     };
//     string[] good =
//     {
//         "look forward to.",
//         "try new things!",
//         "is likely to succeed.",
//         "accomplish your dreams!"
//     };
//     string[] bad =
//     {
//         "fear.",
//         "avoid major decisions.",
//         "may have unexpected outcomes.",
//         "re-evaluate your life."
//     };
//     string[] neutral =
//     {
//         "appreciate.",
//         "enjoy time with friends.",
//         "should align with your values.",
//         "get in tune with nature."
//     };

//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (l > 75 ? good : (l < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

// TellFortune(luck);










// CountTo(5);

// void CountTo(int max)
// {
//     for (int i =0; i < max; i++)
//     {
//         Console.WriteLine($"${i}, ");
//     }
// }




// int[] schedule = { 800, 1200, 1600, 2000 };

// void DisplayTimeAdjusted(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;

//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     } else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }
//         for ( int i = 0; i < times.Length; i++)
//         {
//             int newTime = ((times[i] + diff)) % 2400;
//                 Console.WriteLine($"{times[i]} -> {newTime}");

//         }
// }

// DisplayTimeAdjusted(schedule, 8, 6);






// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);

// DisplayStudents(new string[] {"Robert", "Vanya"});

// void DisplayStudents(string[] students)
// {
//     foreach (string student in students)
//     {
//         Console.WriteLine($"{student}, ");
//     }
//     Console.WriteLine();
// }



// double pi = 3.14159;

// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area:N2}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference:N2}");
// }

// void PrintCircleInfo(int radius)
// {
//     Console.WriteLine($"Circile with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }










// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"Global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
// }





// using System.Runtime.InteropServices;

// int[] array = { 1, 2, 3, 4, 5 };

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//     foreach (int n in array)
//     {
//         Console.WriteLine(n);
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }










// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");

// void SetHealth(string status, bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }


// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte", "Dominick" };
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP(name: "Linh",partySize: 2,allergies: "none",inviteOnly: false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// RSVP("Dominick");

// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies ="none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool invited = false;
//         foreach (string guest in guestList)
//         {
//             if (guestList.Contains(name))
//             {
//                 Console.WriteLine($"\nHello {name}, we are glad to have you!");
//                 invited = true;
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine($"\n{name} is not invited. Goodriddance!!!");
//                 return;
//             }
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }






// string[,] corporate =
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {

// }

// for (int i = 0; i < external.GetLength(0); i++)
// {

// }



//employee  first 2 characters of employee first name + last name
// Robert Bavin = RoBavin@contoso.com


// // string[] name = { "Dominick Pescetto", "Nick Cage", "Ariana Grande" };
// string[,] corporate =
// 	{
// 		{"Robert", "Bavin"}, {"Simon", "Bright"},
// 		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
// 		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

// 	string[,] external =
// 	{
// 		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
// 		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
// 	};

// 	string externalDomain = "hayworth.com";

// 	for (int i = 0; i < corporate.GetLength(0); i++)
// 	{
// 		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// 	}

// 	for (int i = 0; i < external.GetLength(0); i++)
// 	{
// 		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// 	}

// 	void DisplayEmail(string first, string last, string domain = "contoso.com")
// 	{
// 		string email = first.Substring(0, 2) + last;
// 		email = email.ToLower();
// 		Console.WriteLine($"{email}@{domain}");
// 	}














// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// Console.WriteLine($"Total: ${total}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }
// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// Console.WriteLine($"Total: ${total}");

// if (TotalMeetsMinimum())
// {
//     total -= 5.00;
// }

// Console.WriteLine($"Total: ${FormatDecimal(total)}");






// double usd = 23.73;
// int vnd = UsdToVnd(usd);
// double usdConverted = VndToUsd(100000.00);
// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"{usdConverted}");
// int UsdToVnd(double usd)
// {
//     return (int) (usd * 23500);
// }



// double VndToUsd(double vnd)
// {
//     return (double) (vnd / 23500);
// }









// using System.Globalization;

// string stringToReverse = "Hello I'd like you to reverse me please!";
// string secondStringToReverse ="Can you please reverse me too!???";

// string ReverseString(string str)
// {
//     char[] stringArray = str.ToCharArray();
//     char[] reversedStringArray = new char[stringArray.Length];
//     int count = 0;

//     for (int i = stringArray.Length - 1; i >= 0; i--)
//     {
//         reversedStringArray[count] = stringArray[i];
//         count++;
//     }

//    return String.Join("", reversedStringArray);
// }
// string firstString = ReverseString(stringToReverse);
// string secondString = ReverseString(secondStringToReverse);

// Console.WriteLine(firstString);
// Console.WriteLine(secondString);




// string stringToReverse = "Hello I'd like you to reverse me please!";
// string secondStringToReverse = "Can you please reverse me too!???";

// string WordReverser(string str)
// {
//     string result = "";
//     string[] splitString = str.Split(" ");

//     for (int i = splitString.Length - 1; i >= 0; i--)
//     {
//         result += splitString[i] + " ";
//     }
//     return result;
// }

// Console.WriteLine(WordReverser(stringToReverse));
// Console.WriteLine(WordReverser(secondStringToReverse));





// string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words)
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string str)
// {
//     char[] revString = str.ToCharArray();
//     string result = "";

//     for (int i = revString.Length - 1; i >= 0; i--)
//     {
//         result += revString[i];
//     }
//     if (result == str)
//     {
//         return true;
//     }
//     else
//         return false;
// }
















