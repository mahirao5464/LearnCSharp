
using LearnCSharp;

Console.Write("How Many elements you want to enter:  ");
var isValidNumber = Int32.TryParse( Console.ReadLine(),out int length);
if (!isValidNumber) {
    Console.WriteLine("Wrong Input. Exiting..........");
    return;
} 
var arr = ArrayOps.EnterArrayElements(length);
var max = ArrayOps.FindMax(arr);
var min = ArrayOps.FindMin(arr);
var sum = ArrayOps.GetSum(arr);

Console.WriteLine($"Max: {max};  min: {min}; sum: {sum}");