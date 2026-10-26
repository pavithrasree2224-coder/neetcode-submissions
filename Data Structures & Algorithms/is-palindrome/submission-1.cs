public class Solution {
    public bool IsPalindrome(string s) {
        int first = 0, last = s.Length-1;
        while(first < last)
        {
            if(!char.IsLetterOrDigit(s[first]))
            {
                first++;
            }
            else if(!char.IsLetterOrDigit(s[last]))
            {
                last--;
            }   
            else
            {
                if(char.ToLower(s[first]) != char.ToLower(s[last]))
                {
                    return false;
                }
                first++;
                last--;
            }           
        }
        return true;
    }
}
