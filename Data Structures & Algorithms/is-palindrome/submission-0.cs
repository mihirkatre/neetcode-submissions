public class Solution {
    public bool IsPalindrome(string s) {
        // two pointer
        int l = 0;
        int r = s.Length - 1;

        while (l < r){
            //if punctuation or space, skip and move ahead.
            if(!AlphaNum(s[l])){
                l++;
                continue;
            }
            //if punctuation or space, skip and move ahead.
            if(!AlphaNum(s[r])){
                r--;
                continue;
            }
            //if valid alphanumeric character, then compare in lower case
            if(char.ToLower(s[l]) != char.ToLower(s[r])){
                return false;
            }
            //move the left pointer ahead and right pointer behind.
            l++;
            r--;
        }
        return true;
    }

    // Custom function to determine if the character is alphanumeric.
    //Helps ignore punctuation and spaces.
    public bool AlphaNum(char c){
        return (c >= 'a' && c <= 'z' ||
            c >= 'A' && c <= 'Z' ||
            c >= '0' && c <= '9');
    }
}
