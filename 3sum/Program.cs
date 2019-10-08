using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sum
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static Int32 ThreeSum(Int32 [] nums, Int32 target)
        {
            if (nums == null  || nums.Length < 3 )
            {
                return -1;
            }
            Array.Sort(nums);
            int closestSum = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length ; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while(left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = sum;
                    }
                    if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return closestSum;
        }
    }
}
