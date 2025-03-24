#region First Chapter
//Console.WriteLine("Signed integral types:");

//Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
//Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
//Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
//Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


//Console.WriteLine("");
//Console.WriteLine("Unsigned integral types:");

//Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
//Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
//Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
//Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//Console.WriteLine("");
//Console.WriteLine("Floating point types:");
//Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
//Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
//Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
#endregion

#region Second Chapter
//decimal myDecimal = 3.14m;
//Console.WriteLine($"decimal: {myDecimal}");

//int myInt = (int)myDecimal;
//Console.WriteLine($"int: {myInt}");

//float myFloat = (float)myInt;
//Console.WriteLine($"float: {myInt}");
#endregion

#region Third Chapter
//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//decimal total = 0;
//string message = string.Empty;

//foreach (var value in values )
//{
//    bool numericValue = decimal.TryParse(value, out decimal result);
//    if (numericValue)
//    {
//        total += result;
//    } 
//    else
//    {
//        message = message + value;
//    }
//}

//Console.WriteLine($"Total: {total}");
//Console.WriteLine($"Message: {message}");

//int value1 = 11;
//decimal value2 = 6.2m;
//float value3 = 4.3f;

//// Your code here to set result1
//// Hint: You need to round the result to nearest integer (don't just truncate)

//int result1 = Convert.ToInt32(value1 / value2);
//decimal result2 = value2 / (decimal)value3;
//float result3 = value3 / value1;


//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//// Your code here to set result2
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//// Your code here to set result3
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
#endregion

#region Fourth Chapter
//string[] pallets = ["B14", "A11", "B12", "A13"];

//Console.WriteLine("Sorted...");
//Array.Sort(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

//Console.WriteLine("");
//Console.WriteLine("Reversed...");
//Array.Reverse(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"-- {pallet}");
//}

string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
#endregion

