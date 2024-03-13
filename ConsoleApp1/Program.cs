// // // // // // // // // // // Random dice = new Random();

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






