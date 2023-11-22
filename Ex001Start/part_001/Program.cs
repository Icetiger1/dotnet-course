
string message = "Value1: ";
Console.Write(message);
int number1 = Convert.ToInt32(Console.ReadLine());

message = "Value2: ";
Console.Write(message);
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 + number2;
Console.Write($"Result: {number1} + {number2} = {result}");
