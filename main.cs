// C# program for finding
// number of divisor
using System;

class GFG
{
// program for finding
// no. of divisors
static int divCount(int n)
{
	// sieve method for prime calculation
	bool[] hash = new bool[n + 1];
	for (int p = 2; p * p < n; p++)
		if (hash[p] == false)
			for (int i = p * 2;
					i < n; i += p)
				hash[i] = true;

	// Traversing through
	// all prime numbers
	int total = 1;
	for (int p = 2; p <= n; p++)
	{
		if (hash[p] == false)
		{

			// calculate number of divisor
			// with formula total div =
			// (p1+1) * (p2+1) *.....* (pn+1)
			// where n = (a1^p1)*(a2^p2)....
			// *(an^pn) ai being prime divisor
			// for n and pi are their respective
			// power in factorization
			int count = 0;
			if (n % p == 0)
			{
				while (n % p == 0)
				{
					n = n / p;
					count++;
				}
				total = total * (count + 1);
			}
		}
	}
	return total;
}

// Driver Code
public static void Main()
{
	int n = 24;
	Console.WriteLine(divCount(n));
}
}

// This code is contributed
// by mits
