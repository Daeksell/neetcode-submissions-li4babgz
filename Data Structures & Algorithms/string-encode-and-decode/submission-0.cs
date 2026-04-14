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
            var sb = new StringBuilder();

            while(s[pos] != '#')
            {
                sb.Append(s[pos]);
                pos++;
            }
            pos++;
            return int.Parse(sb.ToString());
        }
        string ReadString(int count)
        {
            var sb = new StringBuilder();
            for(var i = pos; i < pos + count; i++)
            {
                sb.Append(s[i]);
            }
            pos += count;
            return sb.ToString();
        }
   }
}
