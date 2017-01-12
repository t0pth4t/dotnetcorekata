using System;
public static class Ships
{
    public static int CountShips(char[,] board)
    {
        var ships = 0;
        var shipInColumn = false;
        for(var y = 0; y < board.GetLength(1); y++){
            for(var x = 0; x < board.GetLength(0); x++){

                if(board[x,y] == 'X' && !shipInColumn){
                    ships++;
                    shipInColumn = true;
                }
            }
            shipInColumn = false;
        }
        return ships;
    }
}