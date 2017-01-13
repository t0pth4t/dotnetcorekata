public static class Reverser{
    public static string Reverse(string s){
        var r = s.ToCharArray();
        var result = "";
        for(var i = r.Length -1; i > -1; i--){
            result += r[i];
        }
        return result;
    }
}