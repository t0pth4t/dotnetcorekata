public static class Reverser{
    public static string Reverse(string s){
        var r = s.ToCharArray();
        char swap;
        for(var i = 0; i < r.Length / 2; i++){
            swap = r[i];
            r[i] = r[r.Length -1 -i];
            r[r.Length -1 -i] = swap;
        }
        return new string(r);
    }
}