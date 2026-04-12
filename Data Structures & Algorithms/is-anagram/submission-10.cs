public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
        {
            return false;
        }
        
        int[] map = new int[26];
        var spanS = s.AsSpan();
        var spanT = t.AsSpan();
        var nonZeroCount = 0;
        for(int i = 0; i < s.Length; i++)
        {
            var charA = spanS[i];
            var charB = spanT[i];

            if(charA == charB)
            {
                continue;
            }

            IncreaseCount(charA);
            DecreaseCount(charB);
        }

        return nonZeroCount == 0;

        void IncreaseCount(char value)
        {
            var key = (int)(value - 'a');
            var countBefore = map[key];
            map[key]++;
            if(countBefore == 0)
            {
                nonZeroCount++;
                return;
            }

            if(map[key] == 0)
            {
                nonZeroCount--;
            }
        
        }
         void DecreaseCount(char value)
        {
            var key = (int)(value - 'a');
            var countBefore = map[key];
            map[key]--;
            if(countBefore == 0)
            {
                nonZeroCount++;
                return;
            }

            if(map[key] == 0)
            {
                nonZeroCount--;
            }
        }
    }
}
