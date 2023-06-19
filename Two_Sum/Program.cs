public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int index1 = 0;
        int index2 = 0;
        for (int x = 0; x < nums.Length; x++)
        {
            for (int y = 0; y < nums.Length; y++)
            {
                if (x == y)
                { continue; }
                if (nums[x] + nums[y] == target)
                {
                    index1 = x;
                    index2 = y;
                    int[] returnArray = new int[] { index1, index2 };
                    return returnArray;
                }
            }
        }
        return null;
    }
}