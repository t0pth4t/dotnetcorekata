public static class Diag {
    public static int Sum(int size, int[][] r){
        var sumOne = 0;
        for(var i = 0; i < size; i++){
            sumOne += r[i][i];
        }
        var sumTwo = 0;
        for(var i = size; i >= 0; i--){
            sumTwo += r[i][i];
        }
        return 0;
    }
}