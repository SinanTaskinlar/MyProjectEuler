long number1 = 1, number2 = 1, result = 0, total = 0;

while (result < 4000000)
{
	total += result % 2 == 0 ? result : 0;
	result = number1 + number2;
	number2 = number1;
	number1 = result;
}

Console.Out.WriteLine(total);