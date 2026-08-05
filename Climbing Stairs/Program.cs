/*You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?



Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
*/
Solution s = new Solution();
Console.WriteLine(s.S(2));
Console.WriteLine(s.S(3));
Console.WriteLine(s.S(4));



public class Solution
{
    public int S(int n)
    {
        //Same as Fibonacci sequence, but validating the input to be greater than 2,
        //since the first two numbers are 1 and 2.
        if (n <= 2)
        {
            return n;
        }
        //Same as Fibonacci sequence, but starting with 1 and 2 instead of 0 and 1
        int fib1 = 1;
        int fib2 = 2;
        //Same as Fibonacci sequence, but starting 3 instead of 2
        for (int i = 3; i <= n; i++)
        {
            int temp = fib1 + fib2;
            fib1 = fib2;
            fib2 = temp;
        }

        return fib2;

    }
}