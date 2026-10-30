public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            char[] charArr = s.ToCharArray();
            Array.Sort(charArr);
            string sortedStr = new string(charArr);

            if(!dict.ContainsKey(sortedStr))
            {
                dict[sortedStr] = new List<string>();
            }

            dict[sortedStr].Add(s);
        }

        return dict.Values.ToList<List<string>>();
    }
}
