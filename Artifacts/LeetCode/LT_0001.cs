using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LT_0001
    {
        public static void TestCases()
        {
            var arr = new int[] { 2, 7, 11, 15 };
            Assert.AreEqual(TwoSum(arr, 9), new int[] { 0, 1 });

            arr = new int[] { 3, 2, 4 };
            Assert.AreEqual(TwoSum(arr, 6), new int[] { 1, 2 });

            arr = new int[] { 3, 3 };
            Assert.AreEqual(TwoSum(arr, 6), new int[] { 0, 1 });
        }
        private static int[] TwoSum(int[] nums, int target)
        {
            var store = new Dictionary<int, int>();
            for (int i = 0, l = nums.Length; i < l; i++)
            {
                var reminder = target - nums[i];
                if (store.ContainsKey(reminder))
                {
                    return new int[2] { store[reminder], i };
                }
                store[nums[i]] = i;
            }
            return new int[2] { -1, -1 };
        }
    }
}
