using System;

public static class TwoSum {
    public static int[] Sum(int target, int[] nums){
        var result = new int[2];
        for(var i = 0; i < nums.Length; i++){
            for(var j = 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    return new int[]{i,j};
                }        
            }   
        }
        
        return new int[0];
    }
}