public class Solution
{
    public bool IsPalindrome(int x)
    {
        bool isPal = false;

        char[] charsX = x.ToString().ToCharArray();
        char[] revX = new char[charsX.Length];

        int j = 0;

        for (int i = charsX.Length - 1; i >= 0; i--)
        {
            revX[j] = charsX[i];
            j++;
        }
        for (int i = 0; i < charsX.Length; i++)
        {
            if (revX[i] == charsX[i])
            {
                isPal = true;
            }
            else { isPal = false; break; }
        }

        return isPal;
    }
}