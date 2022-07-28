//Problem at LeetCode
//
//1523 . Count Odd Numbers in an Interval Range .
//Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).


//Solution

public class Solution {
    public int CountOdds(int low, int high) {
        int count = 0;
        for(int i = low; i <=high ; i++){

            if(i%2!=0){
                count = count+1;
            }
        }
        return count;
    }
}
