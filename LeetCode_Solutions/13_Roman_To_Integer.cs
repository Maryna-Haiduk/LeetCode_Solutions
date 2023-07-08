namespace Roman_To_Integer_13
{
    public class Solution
    {
        public int RomanToInt(string inputRoman)
        {
            char[] inputRomanChars = inputRoman.ToCharArray();
            char[] roman = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int sum = 0;
            bool temp1 = false;
            bool temp2 = false;
            bool temp3 = false;

            for (int i = 0; i < inputRomanChars.Length; i++)
            {
                for (int j = 0; j < roman.Length; j++)
                {
                    if (inputRomanChars[i] == roman[j])
                    {
                        switch (inputRomanChars[i])
                        {
                            case 'I':
                                temp1 = true;
                                sum += 1;
                                break;
                            case 'V':
                                if (temp1 ==
                                true)
                                {
                                    sum += 3;
                                }
                                else
                                {
                                    sum += 5;
                                }
                                break;
                            case 'X':
                                temp2 = true;
                                if (temp1 == true)
                                {
                                    sum += 8;
                                }
                                else
                                {
                                    sum += 10;
                                }
                                break;

                            case 'L':
                                if (temp2 == true)
                                {
                                    sum += 30;
                                }
                                else
                                {
                                    sum += 50;
                                }
                                break;
                            case 'C':
                                temp3 = true;
                                if (temp2 == true)
                                {
                                    sum += 80;
                                }
                                else
                                {
                                    sum += 100;
                                }
                                break;
                            case 'D':
                                if (temp3 == true)
                                {
                                    sum += 300;
                                }
                                else
                                {
                                    sum += 500;
                                }
                                break;
                            case 'M':
                                if (temp3 == true)
                                {
                                    sum += 800;
                                }
                                else
                                {
                                    sum += 1000;
                                }
                                break;
                        }
                    }
                }
            }
            return sum;
        }
    }
}