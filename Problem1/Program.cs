var total = 0;
for (int i = 1; i < 1000; i++)
	total += (i % 3 == 0 || i % 5 == 0) ? i : 0;
Console.Out.WriteLine(total);