using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
             if (numbers == null)
             {
                return 0;
             }
                int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
                    return sum;

        }           
     

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           if ( str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
           {
                return str1.Length;
           }
            if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            {
                return str2.Length;
            }
            if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length) 
            {
                return str3.Length;
            }
             else
             {
                return str4.Length;
             }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2  && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            if ((number2 <= number1 && number2 <= number3 && number2 <= number4))
            {
                return number2;
            }   
            if ((number3 <= number1 && number3 <= number2 && number3 <= number4))
            {
                return number3;
            }
             else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name ="TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public bool IsStringANumber(string input)
        {
            decimal result;
            bool isNum = decimal.TryParse(input, out result);

                if (isNum)
                {
                 return true;
                }
                else
                {
                return false;
                }
                

        }                    
        

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count1 = 0;
            int count2 = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            if (count1 > count2)
                {
                    return true;

                }
            else
                {
                    return false;
                }
            
        }

        public double AverageEvens(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0 )
            {
                return 0;
            }
            
            double counter = 0;    
            double even = 0;
             for (int i = 0; i < numbers.Length; i++)
             {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];
                    counter++;
                }
            
             }
             if (even == 0)
             {
                return 0;
             } 
            return even / counter;
                 
                
            
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

        
            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }  
                return result;
            





        }

    }
}
