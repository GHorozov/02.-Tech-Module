using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {

            // ne e reshena
        
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;
            int maxCount = 0;
            List<int> result = new List<int>();
            List<int> finalResilt = new List<int>();
            // 1 2 5 3 5 2 4 1
            for (int i = 1; i < input.Count; i++)
            {
                
                if (input[i] - input[i-1] == 1 )
                {
                    count++;
                    result.Add(input[i-1]);
                    if (count > maxCount)
                    {
                        maxCount = count;
                        result.Add(input[i]);
                        foreach (var num in result)
                        {
                            finalResilt.Add(num);
                        }
                    }
                }
                else if(input[i] - input[i - 1] > 1 && CheckNextNumbers(input, i,input[i-1] ) > 0)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        result.Add(CheckNextNumbers(input, i,input[i - 1]));
                        finalResilt.Add(CheckNextNumbers(input, i, input[i - 1]));
                    }
                }
                else
                {
                    result.Clear();
                    count = 0;
                }
            }

            foreach (var item in finalResilt)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }

        private static int CheckNextNumbers(List<int> numbers,  int num, int chekedNumber )
        {
            //1 2 5 3 5 2 4 1
            int result = 0;
            int index = num;
           
            List<int> currentList = new List<int>();
            
            while(index < numbers.Count)
            {
                currentList.Add(numbers[index]);
                index++;
            }

            int minValue = 0;
            int minIndex = 0;
            int maxInt = int.MaxValue;
            int maxIndex = int.MaxValue;
            int currentIndex = 0;
            int saveIndex = 0;
            for (int i = 0; i < currentList.Count; i++)
            {
                saveIndex = i;
                minValue = 0;
                minIndex = 0;
                if(currentList[i] - numbers[num-1] > 0)
                {
                    minIndex = i;
                    minValue = currentList[i] - numbers[num - 1];
                    if(minValue < maxInt || saveIndex <= maxIndex)
                    {
                        maxInt = minValue;
                        currentIndex = i;
                        maxIndex = saveIndex;
                    }               
                }
             }

            if(currentList[currentIndex] - chekedNumber >= 1)
            {
                result = currentList[currentIndex];
            }
            else
            {
                result = 0;
            }
            
            return result;
            
        }
    }
}
