public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
        {
            return false;
        }
        
        var map = new Dictionary<char, int>(s.Length);
        for(int i = 0; i < s.Length; i++)
        {
            var charA = s[i];
            var charB = t[i];

            if(charA == charB)
            {
                continue;
            }

            IncreaseCount(charA);
            DecreaseCount(charB);
        }

        return map.All(x => x.Value == 0);

        void IncreaseCount(char key)
        {
           map[key] = map.GetValueOrDefault(key) + 1;
        }
         void DecreaseCount(char key)
        {
           map[key] = map.GetValueOrDefault(key) - 1;
        }
    }
}
