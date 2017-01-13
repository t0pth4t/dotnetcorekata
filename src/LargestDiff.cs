public static class LargestDiff{
    public static int Diff(int[] r){
        var diff = 0;
        for(var i = 0; i < r.Length; i++){
            for(var j = 1; j < r.Length; j++){
                if(r[i] > r[j]){
                    var d = r[i] - r[j];
                    if(d > diff){
                        diff = d;
                    }
                }
                else{
                    var d = r[j] - r[i];
                    if(d > diff){
                        diff = d;
                    }
                }
            }
        }
        return diff;
    }
}