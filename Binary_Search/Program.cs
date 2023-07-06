public class Solution
{
    public int Search(int[] nums, int target)
    {
        Array.Sort(nums);

        int left = 0;
        int right = nums.Length - 1;


        if (nums[left] == target)
        { return left; }
        else if (nums[right] == target)
        { return right; }

        while (left <= right)
        {
            int midle = (left + right) / 2;

            if (nums[midle] == target)
            { return midle; }

            else if (target < nums[midle])
            {
                right = midle - 1;
            }
            else if (target > nums[midle])
            {
                left = midle + 1;
            }
        }

        return -1;
    }

}