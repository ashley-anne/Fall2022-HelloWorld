// What is this stuff?
// What is a 'console' application?
// What's with the fancy coloring?


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Variables and Objects
// Variable Declaration
// Variable declaration is stating that we have a variable and giving it an associated name
// if you are jus doing variable declaration, you must state the variable type first
//
// variableType variabelName;
string Instructor;

// Variable Assignment
// Variable assignement is giving a variable a value of the appropiate type for us to reference later

// variableName = value
Instructor = "Gavin";
// Variable Reassignment
Instructor = "Davis";

// var/variableType variabelName = value;
// All together now!
var Age = 24;
// this will print out to the console showing the age 24 
Console.WriteLine(Age);

//Operators
//Performs some kind of basic operation on some values
// ex. 5+ 13 -> 18
var studentCount = 5 + 13;
Console.WriteLine(studentCount);
// Aritmetic
// Addition: +
// Subtraction: -
// Multiplication: *
// Division: /
var averageClassSize = studentCount / 3;
// Exponentiation: Math.Pow()
// Modulo: %
// -- Returns the remainder after dividing by a particular number

//Booleans
//Boolean is a data type where the only values are 'true' vs 'false' - 'on' vs 'off' - 1 vs 0
var isSunny = true;

// Equality
// Checks to see if the value of instructor is the same as the value 'Davis'
var isDavis = Instructor == "Davis"; // Davis == Davis -> true


//Comparison
// Checks to see if a value is greater than, less than or GE or LE
// G: - >
// L: - <
//GE: >=
// LE: <=
var isGreaterThan = 25 >= 25; //checking is iterator greater than OR is iterator equal to?
// Boolean Operators
//We have some specific operators defined for actions between two boolean values

//OR operator ||// The OR operator returns true i the left is true OR the right is true
// true || false -> true
// false || true -> true
// true || true -> true
// false || false -> false
var willGoOutside = isSunny || isDavis; // true || true -> true
// OR statements will run both parts of the code to return true



// AND operator &&
// The AND operator returns true if the left AND the right values are true
// true && false -> true
// false && true -> true
// true && true -> true
// false && false -> false
var isRainy = true;
var isCold = true;
var willNotDrive = isRainy && isCold; // true && true  -> 

// NOT operator !
//Returns the opposite of a given boolean value
// !true -> false
// !false -> true
var willDrive = !willNotDrive;

//Not Equal !=
// Checks to see if things are not equal

// Exclusive OR (XOR) operator ^
// Only returns true when the left or right are true, false when both are true;
// we only want one side of our equation to be true both statements being true will result in the statement being false
// true ^ false -> true
// false ^ true -> true
// true ^ true -> false
// false ^ false -> false

//Increment

//Parsing
// Transforming a variable from another type (often a string) into another (often an integer)
var parsedValue = int.Parse("15"); // integer 15
Console.WriteLine(parsedValue + 5);


var isRed = false;
var isBlue = true;
var theSkyIs = isBlue; 
var isGreen = false; 


isRed && isBlue = theSkyIs