using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet("[action]/{number}")]
        public int[] GetNumbers(double number)
        {
            var cal = new Calc();
            var numbers = cal.calc(number);
            return numbers;
        }
    }
    
    public class Calc
    {
        public int[] calc(double n)
        {
            double middle;
            int[] numbers;
            int round;

            if (n % 2 == 1)
            {
                numbers = new int[2];
                numbers[0] = (int)((n - 1) / 2);
                numbers[1] = (int)((n + 1) / 2);
                
                return numbers;
            }
            
            else
            {
                for (int i = 3; i <= n / 2; i++)
                {
                    if (i % 2 == 1)
                    {
                        if (n % i == 0)
                        {
                            numbers = new int[i];
                            middle = n / i;
                            round = numbers.Length / 2;

                            numbers[round] = (int)(middle);

                            for (int j = 1; j <= round; j++)
                            {
                                numbers[round - j] = numbers[round] - j;
                                numbers[round + j] = numbers[round] + j;
                            }

                            return numbers;
                        }
                        else if (i == n / 2)
                        {
                            numbers = new int[0];
                            return numbers;
                        }
                        else {
                            continue;
                        }
                    }
                    else
                    {
                        if (n % i == i / 2)
                        {
                            numbers = new int[i];
                            middle = n / i;
                            round = numbers.Length / 2;

                            numbers[i / 2 - 1] = (int)(Math.Floor(middle));
                            numbers[i / 2] = (int)(Math.Ceiling(middle));

                            for (int j = 1; j < round; j++)
                            {
                                numbers[(i / 2 - 1) - j] = numbers[i / 2 - 1] - j;
                                numbers[(i / 2) + j] = numbers[i / 2] + j;
                            }

                            return numbers;
                        }
                        else if (i == n / 2)
                        {
                            numbers = new int[0];
                            return numbers;
                        }
                        else {
                            continue;
                        }
                    }
                }
                numbers = new int[0];
                return numbers;
            }
        }
    }
}
