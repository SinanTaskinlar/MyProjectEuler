//need to be faster
long number = 600851475143;
long largestPrime = 0;
for (long i = 2; i < number; i++)
{
	if (number % i == 0)
	{
		bool isPrime = true;
		for (long j = 2; j < i; j++)
		{
			if (i % j == 0)
			{
				isPrime = false;
				break;
			}
		}
		if (isPrime)
		{
			largestPrime = i;
		}
	}
}
Console.Out.WriteLine(largestPrime);