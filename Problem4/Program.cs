int min = 100,max = 999, multiple = 0;
List<int> multiples = new List<int>();

for (int i = min; i < max; i++)
{
	for (int j = min; j < max; j++)
	{
		multiple = i * j;
		string reversed = new string(multiple.ToString().ToCharArray().Reverse().ToArray());
		if (reversed == multiple.ToString())
		{
			multiples.Add(multiple);
		}
	}
}
Console.WriteLine(multiples.Max());