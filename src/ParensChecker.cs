using System.Collections.Generic;
using System.Linq;

public static class ParensChecker {
    public static bool IsBalanced(string s){
        // var open = "{([";
        // var close = "})]";
        if(string.IsNullOrEmpty(s))
            return true;
        
        if(s.Length % 2 != 0)
            return false;

        // var indexOfOpeningParen = open.IndexOf(s[0]);
        // if(indexOfOpeningParen == -1)
        //     return false;
            
        // if(close.IndexOf(s[1]) != indexOfOpeningParen)
        //     return false;
        var st = new Stack<int>();
        for(var i = 0; i < s.Length; i++){
            if(s[i] == '('){
                st.Push(i);
            }
            if(s[i] == ')'){
                if(st.Count > 0)
                    st.Pop();
                else
                    return false;
            }
                
        }


        // if(s[0] == '(' && s[1] == ')')
        //     return true;
        
        return true;
    }
}