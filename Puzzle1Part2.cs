using System.Collections.Generic;

public class Puzzle1Part2 {
    public int Solve() {
        var hash = new SortedSet<int>();

        var elvesLines = Puzzle1Input.stringInput.Split(Environment.NewLine);

        int currentCalories = 0;

        foreach(string calory in elvesLines){
            if(string.IsNullOrWhiteSpace(calory)){
                hash.Add(currentCalories);
                currentCalories = 0;
            }
            else {
                int caloryInt = int.Parse(calory);
                currentCalories+=caloryInt;
            }
        }

        int top3Calories = hash.OrderDescending().Take(3).Sum();
        
        return top3Calories;
    }
}