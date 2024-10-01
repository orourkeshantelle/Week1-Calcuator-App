// variable names should be short yet meaningful.
// the choice of a variable name should be mnemonic- that is,
// designed to indicate to the casual observer the intent of its use.

// this integer varibale stores he first numer 
// ask the user to input the first numer 
Console.WriteLine("Type in the first number followed by the Enter key");
int firstNUmber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by the Enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// perform the calculation 
int result = firstNUmber + secondNumber;

// Output the answer to the console 
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNUmber, secondNumber, result);
