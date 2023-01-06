using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
public class Puzzle1 
{
    public int Solve()
    {
       int currentCalories = 0;
       int maxCalories = 0;

        varelvesLines = Puzzle1Input.stringInput.Split(Environment.NewLine);
       
        foreach(string calory in elvesLines){
            if(string.IsNullOrWhiteSpace(calory)){
                maxCalories = Math.Max(currentCalories, maxCalories);
                currentCalories = 0;
            }
            else {
                int caloryInt = int.Parse(calory);
                currentCalories+=caloryInt;
            }
        }

        return maxCalories;    

    }
}