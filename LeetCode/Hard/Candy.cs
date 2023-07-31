namespace LeetCode.Hard;

// 135 Candy
internal class Candy
{
    public int Handle(int[] ratings)
    {
        int[] candyCounts = new int[ratings.Length];
        candyCounts[0] = 1;

        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                candyCounts[i] = candyCounts[i - 1] + 1;
            }
            else
            {
                candyCounts[i] = 1;
            }
        }

        int totalCandyCount = candyCounts[^1];

        for (int i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1] && candyCounts[i] <= candyCounts[i + 1])
            {
                candyCounts[i] = candyCounts[i + 1] + 1;
            }

            totalCandyCount += candyCounts[i];
        }

        return totalCandyCount;
    }
}
