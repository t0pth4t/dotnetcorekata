public static class TomString {
    public static int Hash(string[] values){
        var stuff = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var hash = 0;
        foreach(var s in values){
            
            for(var i = 0; i < s.Length;i++){
                hash+= i;
                hash += stuff.IndexOf(s[i]);
            }
        }
        return hash * values.Length;
    }
}