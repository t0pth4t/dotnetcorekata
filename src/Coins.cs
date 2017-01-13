
using System.Collections.Generic;

public static class Coins
{
    public static IEnumerable<int> Change(int amount)
    {
        var change = new List<int>();
        
        foreach(var coin in new []{25, 10, 5, 1}){
            while(amount >= coin){
                change.Add(coin);
                amount-= coin;
            }
        }
        
        return change;
    }

}