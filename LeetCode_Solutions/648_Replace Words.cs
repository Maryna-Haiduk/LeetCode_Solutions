using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _648_Replace_Words
    {
        public static string ReplaceWords(IList<string> dictionary, string sentence)
        {
            StringBuilder newSentenceStringBuilder = new StringBuilder();
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string root = words[i];
                for (int j = 0; j < dictionary.Count; j++)
                {
                    if (words[i].StartsWith(dictionary[j]) && dictionary[j].Length < root.Length)
                    {
                        root = dictionary[j];
                    }
                }
                newSentenceStringBuilder.Append(root).Append(" ");
            }

            return newSentenceStringBuilder.ToString().TrimEnd();



            //StringBuilder newSentenceStringBuilder = new StringBuilder();
            //string[] words = sentence.Split(' ');

            //foreach (string word in words)
            //{
            //    string rootChecker = word;

            //    foreach (string root in dictionary) 
            //    {
            //        if(word.StartsWith(root) && root.Length < rootChecker.Length)
            //        {
            //            rootChecker = root;
            //        }
            //    }
            //    newSentenceStringBuilder.Append(rootChecker).Append(" ");
            //}
            //return newSentenceStringBuilder.ToString().TrimEnd();   




            //for (int i = 0; i < words.Length; i++)
            //{
            //    string temp = "";
            //    for (int j = 0; j < dictionary.Count; j++)
            //    {
            //        string temp = "";

            //        if (words[i].StartsWith(dictionary[j]) & j < dictionary.Count)
            //        {
            //            if (dictionary[j].Length < temp.Length)
            //            {
            //                temp = dictionary[j];
            //            }
            //            else
            //            {

            //            }
            //                temp = dictionary[j];


            //            newSentenceStringBuilder.Append(dictionary[j]);
            //            if (i < words.Length - 1)
            //            {
            //                newSentenceStringBuilder.Append(" ");
            //            }
            //            break;
            //        }
            //        if (j == dictionary.Count - 1)
            //        {
            //            newSentenceStringBuilder.Append(words[i]);
            //            if (i < words.Length - 1)
            //            {
            //                newSentenceStringBuilder.Append(" ");
            //            }
            //        }
            //    }
            //}

            //return newSentenceStringBuilder.ToString();

            //string newSentence = string.Empty;

            //StringBuilder stringBuilder = new StringBuilder();

            //string[] sentenceWords = sentence.Split(' ');

            //for (int i = 0; i < sentenceWords.Length; i++)
            //{
            //    for (int j = 0; j < dictionary[i].Length; j++)
            //    {
            //        if (sentenceWords[i][j] == dictionary[i][j] & j == dictionary[i].Length -1)
            //        {
            //            stringBuilder.Append(dictionary[i]);
            //            stringBuilder.Append(" ");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            //newSentence = stringBuilder.ToString();

            //return newSentence;

            //string newSentence = string.Empty;

            //StringBuilder stringBuilder = new StringBuilder();

            //string[] sentenceWords = sentence.Split(' ');

            //for (int i = 0; i < sentenceWords.Length; i++)
            //{
            //    if (sentenceWords[i].Length < dictionary[i].Length)
            //    {
            //        break;
            //    }
            //    for (int j = 0; j < dictionary.Count; j++)
            //    {
            //        for (int k = 0; k < dictionary[j].Length; k++)
            //        {
            //            if (sentenceWords[i][j] != dictionary[j][k])
            //            {
            //                break;
            //            }

            //            if (k == dictionary[k].Length - 1)
            //            {
            //                stringBuilder.Append(dictionary[i]);
            //                stringBuilder.Append(" ");
            //            }
            //        }
            //    }
            //}
            //newSentence = stringBuilder.ToString();

            //return newSentence;
        }
    }
    
}
