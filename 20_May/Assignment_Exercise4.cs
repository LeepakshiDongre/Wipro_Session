using System;

class LCS
{
    public static string GetLCS(string X, string Y)
    {
        int m = X.Length, n = Y.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 1; i <= m; i++)
            for (int j = 1; j <= n; j++)
                if (X[i - 1] == Y[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);

        int index = dp[m, n];
        char[] lcs = new char[index];
        int a = m, b = n;

        while (a > 0 && b > 0)
        {
            if (X[a
