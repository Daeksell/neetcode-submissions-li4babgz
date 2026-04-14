public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var str in strs)
        {
            sb.Append($"{str.Length}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        
        var result = new List<string>();
        var pos = 0;
        while(pos != s.Length)
        {
            var count = ReadCount();
            var str = ReadString(count);
            result.Add(str);
        }

        return result;

        int ReadCount()
        {
            int count = 0;
            while (s[pos] != '#')
            {
                count = count * 10 + (s[pos] - '0');
                pos++;
            }
            pos++;
            return count;
        }

        string ReadString(int count)
        {
            var str = s.Substring(pos, count);
            pos += count;
            return str;
        }
   }
}
