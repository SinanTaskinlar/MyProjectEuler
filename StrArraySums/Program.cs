using System.Text.RegularExpressions;

string[] input = new string[] { "[1, 2, 3, 4, 5]", "[4, 3, 2, 1, 15, 21, 22]" };
Console.WriteLine(strSum(input));

string strSum(string[] input)
{
	int kucuk = 1, buyuk = 0;
	string sonuc = "";
	List<string> numbers1 = new List<string>(Regex.Split(input[0], @"\D+"));
	List<string> numbers2 = new List<string>(Regex.Split(input[1], @"\D+"));

	int[][] dimArr = new int[][] {
	Array.ConvertAll(numbers1.Where(c => !String.IsNullOrEmpty(c)).ToArray(), s => int.Parse(s)),
	Array.ConvertAll(numbers2.Where(c => !String.IsNullOrEmpty(c)).ToArray(), s => int.Parse(s))
	};

	if (dimArr[0].Count() < dimArr[1].Count())
	{
		kucuk = 0;
		buyuk = 1;
	}

	for (int i = 0; i < dimArr[buyuk].Count(); i++)
	{
		try
		{
			sonuc += (dimArr[kucuk][i] + dimArr[buyuk][i]).ToString() + "-";
		}
		catch
		{
			sonuc += (dimArr[buyuk][i] + 0).ToString() + "-";
		}
	}

	return sonuc.Remove(sonuc.Length - 1);
}