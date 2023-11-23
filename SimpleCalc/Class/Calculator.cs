using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Class
{
    public static class Calculator
    {
        public static int Calculate(string input)
        {
            
            List<string> inputList = new List<string>(input.Split(' '));
            
            for (int i = 0; i < inputList.Count; i++)
            {
                switch(inputList[i])
                {
                    case "*":
                        inputList.Insert(i - 1, Convert.ToString(Convert.ToInt32(inputList[i - 1]) * Convert.ToInt32(inputList[i + 1])));
                        inputList.RemoveAt(i);
                        inputList.RemoveAt(i);
                        inputList.RemoveAt(i);
                        break;
                    case "/":
                        inputList.Insert(i - 1, Convert.ToString(Convert.ToInt32(inputList[i - 1]) / Convert.ToInt32(inputList[i + 1]))); 
                        inputList.RemoveAt(i);
                        inputList.RemoveAt(i);
                        inputList.RemoveAt(i);
                        break;
                }
            }
            int result = Convert.ToInt32(inputList[0]);
            inputList.RemoveAt(0);
            for(int i = 0; inputList.Count > 0;)
            {
                if (inputList[i] == "+")
                {
                    result += Convert.ToInt32(inputList[i + 1]);
                    inputList.RemoveAt(i);
                    inputList.RemoveAt(i);
                }
                else
                {
                    result -= Convert.ToInt32(inputList[i + 1]);
                    inputList.RemoveAt(i);
                    inputList.RemoveAt(i);
                }
            }

            return result;
        }
    }  
}
