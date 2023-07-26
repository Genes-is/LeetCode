namespace LeetCode.Medium;

internal class LengthOfLongestSubstringSolution
{
    public int LengthOfLongestSubstring(string s)
    {
        var usedLetters = new Dictionary<char, int>();
        int maxSequenceCount = 0;
        int sequenceStartIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char letters = s[i];
            if (usedLetters.ContainsKey(letters))
            {
                sequenceStartIndex = Math.Max(sequenceStartIndex, usedLetters[letters] + 1);
            }

            usedLetters[letters] = i;
            maxSequenceCount = Math.Max(maxSequenceCount, i - sequenceStartIndex + 1);
        }

        return maxSequenceCount;
    }
}
