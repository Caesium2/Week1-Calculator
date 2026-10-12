int firstNumber = 5;
int secondNumber = 20;

int result = firstNumber + secondNumber;
Console.WriteLine("The addition of both numbers is {0}", result); //{0} is a placeholder for the value of the variable 'result'

Console.WriteLine("Type in the first number followed by the enter key");
//int firstNumber = Console.ReadLine(); will not work as Console.ReadLine() returns string
firstNumber = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32() converts the string to a 32 bit integer
secondNumber = Convert.ToInt32(Console.ReadLine()); 
result = firstNumber + secondNumber;
Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);