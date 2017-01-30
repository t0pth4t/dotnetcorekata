using System.Collections.Generic;
using System.Linq;

public static class ParensChecker {
    public static bool IsBalanced(string s){
        
        if(string.IsNullOrEmpty(s)){
            return true;
        }
        
        if(s.Length % 2 != 0){
            return false;
        }

        var open = "{([";
        var close = "})]";            
        
        var st = new Stack<int>();

        for(var i = 0; i < s.Length; i++){
            var indexOfOpenParens = open.IndexOf(s[i]);
        
            if(indexOfOpenParens != -1){
                st.Push(indexOfOpenParens);
            }

            var indexOfCloseParens = close.IndexOf(s[i]);
            if(indexOfCloseParens != -1){
                if(st.Count > 0){
                    var top = st.Pop();
                    if(top != indexOfCloseParens)
                        return false;
                }
                else{
                    return false;
                }
            }

            if(indexOfOpenParens == -1 && indexOfCloseParens == -1)
                return false;
                
        }

        return true;
    }
}