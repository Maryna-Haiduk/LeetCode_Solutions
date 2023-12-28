using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _1700_StudentsSandwiches
    {
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            Stack<int> sandwichesStack = new Stack<int>(sandwiches);

            Queue<int> studentsQueue = new Queue<int>(students);


            while (sandwichesStack.Count() > 0)
            {
                    var stud = studentsQueue.Peek();
                    var sand = sandwichesStack.Peek();
                    
                    if (stud == sand)
                    {
                        sandwichesStack.Pop();
                        studentsQueue.Dequeue();
                    }
                    else
                    {                            
                        int count = 0;

                        for (int i = 0; i < studentsQueue.Count(); i++)
                        {
                            if (count == studentsQueue.Count())
                                 return studentsQueue.Count();

                            var student = studentsQueue.Dequeue();
                            studentsQueue.Enqueue(student);
                            
                            count++;
                        }
                    }
                }

            return studentsQueue.Count();
        }

    }
}
