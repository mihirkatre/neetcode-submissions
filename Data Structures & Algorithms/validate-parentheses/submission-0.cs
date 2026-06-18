public class Solution {
    public bool IsValid(string s) {
        //stack to find out bracket on top
        Stack<char> stack = new Stack<char>();
        //keys holding closing brackets, mapped with values holding open brackets
        Dictionary<char, char> closeToOpen = new Dictionary<char, char> {
            {'}', '{'},
            {')', '('},
            {']', '['}
        };

        foreach (char c in s){
            //If char c is a closing bracket
            if(closeToOpen.ContainsKey(c)){
                //If stack has a value and it is equal to value of the key in dictionary (proper closing bracket)
                if(stack.Count > 0 && stack.Peek() == closeToOpen[c]){
                    //empty the stack and keep count 0
                    stack.Pop();
                }
                else{
                    //value mismatch, not valid
                    return false;
                }
            }
            //It is an opening bracket, push it to the stack
            else{
                stack.Push(c);
            }
        }
        //If by the end of all iterations, stack is empty, everything matched and is valid.
        return stack.Count == 0;
    }
}
