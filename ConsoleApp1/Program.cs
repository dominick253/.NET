
// // // // // // // Random dice = new Random();

// // // // // // // for (int i = 0; i < 100; i++) {
// // // // // // // int roll1 = dice.Next(1, 7);
// // // // // // // int roll2 = dice.Next(1, 7);
// // // // // // // int roll3 = dice.Next(1, 7);

// // // // // // // int total = roll1 + roll2 + roll3;

// // // // // // // Console.WriteLine($"\nDice roll:\n{roll1} + {roll2} + {roll3} = {total}\n");

// // // // // // // if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)) {
// // // // // // //     if ((roll1 == roll2) && (roll2 == roll3)) {
// // // // // // //     Console.WriteLine("You rolled triples! +6 bonus to total!");
// // // // // // //     total += 6;
// // // // // // // } else {
// // // // // // //     Console.WriteLine("You rolled Doubles! +2 bonus to total!");
// // // // // // //     total += 2;
// // // // // // // }
// // // // // // // }


// // // // // // // if (total >= 16) {
// // // // // // //     Console.WriteLine("You win a new car!");
// // // // // // // } else if (total >= 10) {
// // // // // // //     Console.WriteLine("You win a new laptop!");
// // // // // // // } else if (total == 7) {
// // // // // // //     Console.WriteLine("You win a trip for two!");
// // // // // // // } else {
// // // // // // //     Console.WriteLine("You win a kitten!");
// // // // // // // }
// // // // // // // }









// // // // // // Random rnd = new Random();
// // // // // // for (int i = 0; i < 10; i++) {
// // // // // // int dayToExpiration = rnd.Next(12);

// // // // // // int discountPercent = 0;

// // // // // // Console.WriteLine(dayToExpiration);

// // // // // // if (dayToExpiration <= 10 && dayToExpiration > 5) {
// // // // // //     Console.WriteLine("Your subscription will expire soon. Renew now!");

// // // // // // } else if (dayToExpiration <= 5 && dayToExpiration > 1) {
// // // // // //     Console.WriteLine($"Your subscription expires in {dayToExpiration} days.\nRenew now and save 10%!");
// // // // // //     discountPercent = 10;
// // // // // // } else if (dayToExpiration == 1) {
// // // // // //     Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%");
// // // // // //     discountPercent = 20;
// // // // // // } else if (dayToExpiration == 0) {
// // // // // //     Console.WriteLine("Your subscrition has expired.");
// // // // // // }
// // // // // // }






// // // // // string[] fradulentOrderIDs = {"A123", "B456", "C789"};

// // // // // // fradulentOrderIDs[0] = "A123";
// // // // // // fradulentOrderIDs[1] = "B456";
// // // // // // fradulentOrderIDs[2] = "C789";
// // // // // // fradulentOrderIDs[0] = "D101";

// // // // // for (int i = 0; i < fradulentOrderIDs.Length; i++) {
// // // // //     Console.WriteLine(fradulentOrderIDs[i]);
// // // // // }
// // // // // Console.WriteLine($"There are {fradulentOrderIDs.Length} fradulent orders to process.");



// // // // string[] names = {"Mwansa", "Lahana", "Dominick"};

// // // // foreach (string name in names) {
// // // //     Console.WriteLine(name);
// // // // }



// // // int[] inventory = [200, 400, 600, 100, 200];

// // // int sum = 0;

// // // int bin = 0;

// // // foreach (int i in inventory) {
// // //     sum += i;
// // //     bin++;
// // // Console.WriteLine($"Bin {bin} = {i} items (Running total: {sum})");
// // // }

// // // Console.WriteLine($"We have {sum} items in inventory.");




// // string[] fraud = {
// // "B123",
// // "C234",
// // "A345",
// // "C15",
// // "B177",
// // "G3003",
// // "C235",
// // "B179",
// // };

// // // string[] fraudB = [];
// // foreach (string i in fraud) {
// //     if (i.StartsWith("B")) {
// //         Console.WriteLine($"The name {i} starts with a 'B'!");
// //         // fraudB.insert() i;
// //     }
// // }
// // public return_type function_name(parameters) {
// //   // function body
// //   return value;
// // }

// //comment





// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;


// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {

//     if ((roll1 == roll2) && (roll2 == roll3)) {

//         Console.WriteLine("You rolled triples!  +6 bonus to total!");

//         total += 6; 

//     } else {

//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");

//         total += 2;

//     }

// }


// string str = "The quick brown fox jumps over the lazy dog.";

// char[] charMessage = str.ToCharArray();

// Array.Reverse(charMessage);

// int x = 0;

// // count the o's
// foreach (char i in charMessage) {

//      if (i == 'o') { x++; } 

// }

// // convert it back to a string
// string new_message = new String(charMessage);

// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {x} times.");







//student grades
int[] student1 = { 90, 86, 87, 98, 100, 94, 90 };
int[] student2 = { 92, 89, 81, 96, 90, 89 };
int[] student3 = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] student4 = { 90, 95, 87, 88, 96, 96 };

string[] names = { "Sophia", "Andrew", "Emma", "Logan" };
string name = "";
string letter = "";


//make a nested array of all the students grades
int[][] grades = new int[][] { student1, student2, student3, student4 };

Console.WriteLine("Student\t\tGrade");

//call the function with each array as input.
for (int i = 0; i < grades.Length; i++)
{
    name = names[i];
    var (Average, OverallGrade, ExtraCreditGrade) = getAverageGrade(grades[i]);
   
    if (Average >= 97)
    {
        letter = "A+";
    }
    else if (Average >= 93)
    {
        letter = "A";
    }
    else if (Average >= 90)
    {
        letter = "A-";
    }
    else if (Average >= 87)
    {
        letter = "B+";
    }
    else if (Average >= 83)
    {
        letter = "B";
    }
    else if (Average >= 80)
    {
        letter = "B-";
    }
    else if (Average >= 77)
    {
        letter = "C+";
    }
    else if (Average >= 73)
    {
        letter = "C";
    }
    else if (Average >= 70)
    {
        letter = "C-";
    }
    else if (Average >= 67)
    {
        letter = "D+";
    }
    else if (Average >= 63)
    {
        letter = "D";
    }
    else if (Average >= 60)
    {
        letter = "D-";
    }
    else if (Average < 60)
    {
        letter = "F";
    }
    Console.WriteLine($"{name}:\t\t{Average}\t{letter}\t{OverallGrade}\t{ExtraCreditGrade}");

}

Console.WriteLine("Press Enter to continue");
// Console.ReadLine();

static (double Average, double OverallGrade, double ExtraCreditGrade) getAverageGrade(int[] grades)
{
    int numOfExtraAssignments = 0;
    int regularGrade = 0;
    int extraCreditGrade = 0; 
    int counter = 0;
    double sumOfRegAndExtraCredit = 0;
    //if over 5 grades grade at 10% value.
    foreach (int grade in grades)
    {
        if (counter < 5)
        {
            sumOfRegAndExtraCredit += grade;
            regularGrade += grade;
        }
        else
        {
            sumOfRegAndExtraCredit += grade / 10;
            extraCreditGrade += grade;
            numOfExtraAssignments++;
        }
        counter++;
    }

    double OverallGrade = sumOfRegAndExtraCredit / 5;
    double Average = regularGrade / 5;
    double ExtraCreditGrade = extraCreditGrade / numOfExtraAssignments;
    return (Average, OverallGrade, ExtraCreditGrade);
}

