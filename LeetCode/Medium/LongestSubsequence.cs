namespace LeetCode.Medium;

// 1218 Longest Arithmetic Subsequence of Given Difference
internal class LongestSubsequence
{
    public int Handle(int[] arr, int difference)
    {
        var dictionary = new Dictionary<int, int>();
        int maxSequenceLength = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            int previous = arr[i] - difference;
            if (dictionary.ContainsKey(previous))
            {
                int sequenceLength = dictionary[previous] + 1;
                dictionary[arr[i]] = sequenceLength;
                maxSequenceLength = Math.Max(maxSequenceLength, sequenceLength);
            }
            else
            {
                dictionary[arr[i]] = 1;
            }
        }

        return maxSequenceLength;
    }
}
