public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> store1 = new Dictionary<char, int>();
        Dictionary<char, int> store2 = new Dictionary<char, int>();

        foreach(char val in s)
        {
            if (store1.TryGetValue(val, out var res))
            {
                store1[val] = res + 1;
            }
            else
            {
                store1[val] = 1;
            }
        }

        foreach(char val in t)
        {
            if (store2.TryGetValue(val, out var res))
            {
                store2[val] = res + 1;
            }
            else
            {
                store2[val] = 1;
            }        
        }

        foreach(char val in s)
        {
            store1.TryGetValue(val, out var s1);
            store2.TryGetValue(val, out var s2);

            if(s1 != s2)
            {
                //Console.WriteLine($"s1: {s1}, s2: {s2}");
                return false;
            }

            //Console.WriteLine($"s1: {s1}, s2: {s2}");
        }

        return true;
    }
}
