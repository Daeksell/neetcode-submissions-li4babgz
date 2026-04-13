public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        return strs
        .ToLookup(x => GetAnagramKey(x))
        .Select(x => x.ToList())
        .ToList();
    }


    private string GetAnagramKey(string value)
    {
        Span<int> array = stackalloc int[26];
        foreach(var ch in value)
        {
            array[ch - 'a'] += 1;
        }

        var sb = new StringBuilder();
        for(var i = 0; i < array.Length; i++)
        {
            var frequency = array[i];
            var ch = i + 'a';
            sb.Append($"{frequency}{ch}");
        }
        return sb.ToString();
    }
}
