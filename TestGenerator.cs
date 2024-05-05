using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinRepresentation
{
    class TestGenerator
    {
        static public int Count()
        {
            return 63;
        }
        public static long Generate(int k, out long arg)
        {
            long result = -1; arg = 0;
            switch (k)
            {
                case 0: arg = 1; result = 1; break;
                case 1: arg = 6; result = 3; break;
                case 2: arg = 47; result = 2; break;
                case 3: arg = 256; result = 9; break;
                case 4: arg = 8489289; result = 6853; break;
                case 5: arg = 1000000000; result = 73411; break;
                case 6: arg = 100; result = 19; break;
                case 7: arg = 128; result = 8; break;
                case 8: arg = 1073741824; result = 31; break;
                case 9: arg = 6370; result = 175; break;
                case 10: arg = 10; result = 5; break;
                case 11: arg = 2; result = 2; break;
                case 12: arg = 3; result = 1; break;
                case 13: arg = 4; result = 3; break;
                case 14: arg = 2000000000; result = 81034; break;
                case 15: arg = 999999999; result = 7623; break;
                case 16: arg = 1000000000000000000; result = 554817437; break;
                case 17: arg = 576460752303423488; result = 60; break;
                case 18: arg = 640; result = 23; break;
                case 19: arg = 785; result = 34; break;
                case 20: arg = 1022; result = 10; break;
                case 21: arg = 962; result = 38; break;
                case 22: arg = 640; result = 23; break;
                case 23: arg = 1099510542205; result = 17863; break;
                case 24: arg = 944875173846; result = 1243789; break;
                case 25: arg = 672031828383; result = 500073; break;
                case 26: arg = 893915235088; result = 243779; break;
                case 27: arg = 1088385987371; result = 4634234; break;
                case 28: arg = 347905064087584832; result = 5150282; break;
                case 29: arg = 309341003709448449; result = 19102955; break;
                case 30: arg = 263810380166378775; result = 4693345949; break;
                case 31: arg = 361431780114432130; result = 94727263; break;
                case 32: arg = 378311177695920400; result = 20702253; break;
                case 33: arg = 290553370434404484; result = 146293655; break;
                case 34: arg = 423901414250789313; result = 292614203; break;
                case 35: arg = 438190581230404958; result = 6012372582; break;
                case 36: arg = 293666568548731467; result = 3648043185; break;
                case 37: arg = 392393882169705920; result = 3341296806; break;
                case 38: arg = 376370659955075108; result = 3279511256; break;
                case 39: arg = 412658913555584867; result = 3498747798; break;
                case 40: arg = 999999999999999999; result = 29665503; break;
                case 41: arg = 410054521552536292; result = 26030230909; break;
                case 42: arg = 416860608518791589; result = 8015276820; break;
                case 43: arg = 393014244375683364; result = 16905456859; break;
                case 44: arg = 518010418436963490; result = 15340957057; break;
                case 45: arg = 576460730781662959; result = 794365; break;
                case 46: arg = 565764701561028461; result = 2186952; break;
                case 47: arg = 571954850028252927; result = 7287457; break;
                case 48: arg = 558161296277634687; result = 1416255; break;
                case 49: arg = 504314853196816127; result = 6183662; break;
                case 50: arg = 123456789; result = 51639; break;
                case 51: arg = 768614336404564650; result = 2504730781961; break;
                case 52: arg = 384307168202282325; result = 956722026041; break;
                case 53: arg = 384307168202282324; result = 1548008755920; break;
                case 54: arg = 192153584101141162; result = 956722026041; break;
                case 55: arg = 196657183728511722; result = 502131822759; break;
                case 56: arg = 193349852752161450; result = 484936992181; break;
                case 57: arg = 196731950519200426; result = 350312970581; break;
                case 58: arg = 192153584101141166; result = 644603021052; break;
                case 59: arg = 10000000000000000; result = 17165857; break;
                case 60: arg = 200; result = 26; break;
                case 61: arg = 93459834598323452; result = 317400926; break;
                case 62: arg = 1717161617181871; result = 69493195; break;
            }
            return result;

        }
    }
}

/*static List<List<long>> representations = new List<List<long>>();*/
/* public static long Find(long z, List<long> currentStack)
 {
     long closest_log2_value = (long)Math.Pow(2, Math.Floor(Math.Log(z, 2)));
     long child = (long)Math.Pow(2, Math.Floor(Math.Log(z, 2)) - 1);
     if (closest_log2_value == 1)
     {
         return 1;
     }

     if (closest_log2_value + child <= z)
     {
         currentStack.Add(closest_log2_value);
         if (closest_log2_value + child == z)
         {
             representations.Add(currentStack);
             *//*Find(child, new List<long>());*//*
         }
         else
         {
             *//*Find(child, currentStack);*//*
         }

     }
     long current_sum = closest_log2_value;
     for (int i = 0; i < currentStack.Count; i++)
     {
         long item = currentStack[i];
         if (current_sum + item <= z)
         {
             if (current_sum + item + closest_log2_value == z)
             {
                 currentStack.Add(item);
                 representations.Add(currentStack);
             }
             current_sum += item + closest_log2_value;
         }
     }


     Find(child, currentStack);



     return closest_log2_value;
 }
*/



/*Working Version 1.0*/

/*using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinRepresentation
{
    public class CoinRepresentation
    {
     public static int calls = 0;
        public static List<List<long>> CalculateCombinations(List<long> list, long z)
        {
            var combinations = new HashSet<List<long>>(); // Use HashSet for efficient duplicate checking
            Combine(list, 0, new List<long>(), z, combinations);
            return combinations.ToList();
        }

        private static void Combine(List<long> list, int index, List<long> current, long remaining, HashSet<List<long>> combinations)
        {
            calls++;
            if (remaining == 0)
            {
                if (!combinations.Any(list => list.SequenceEqual(current)))
                {
                    combinations.Add(new List<long>(current));
                }
                return;
            }

            if (index >= list.Count || remaining < 0)
            {
                return;
            }

            // Include the current element
            current.Add(list[index]);
            Combine(list, index + 1, current, remaining - list[index], combinations);
            current.RemoveAt(current.Count - 1); // Backtrack

            // Exclude the current element
            Combine(list, index + 1, current, remaining, combinations);
        }

        public static long Solve(long sum)
        {
            List<long> all2Variations = new List<long>();
            int closest_log2_index = (int)Math.Floor(Math.Log(sum, 2));
            for (int i = closest_log2_index; i >= 0; i--)
            {
                all2Variations.Add((long)Math.Pow(2, i));
                all2Variations.Add((long)Math.Pow(2, i));
            }

            Console.WriteLine($"[{string.Join(", ", all2Variations)}]");


            List<List<long>> combos = CalculateCombinations(all2Variations, sum);
            foreach (var item in combos)
            {
                Console.WriteLine(string.Join(", ", item));
            }

            Console.WriteLine("Calls: " + calls);

            return combos.Count;
        }

    }
    }
}
*/

/* Working 1.1.0 */
/*public static int calls = 0;
private static Dictionary<string, HashSet<List<long>>> memo = new Dictionary<string, HashSet<List<long>>>();

public static List<List<long>> CalculateCombinations(List<long> list, long z)
{
    var combinations = new HashSet<List<long>>();
    Combine(list, 0, new List<long>(), z, combinations);
    return combinations.ToList();
}

private static void Combine(List<long> list, int index, List<long> current, long remaining, HashSet<List<long>> combinations)
{
    calls++;
    string key = $"{index},{remaining},{string.Join(",", current)}";

    if (memo.ContainsKey(key))
    {
        combinations.UnionWith(memo[key]);
        return;
    }

    if (remaining == 0)
    {
        if (!combinations.Any(list => list.SequenceEqual(current)))
        {
            combinations.Add(new List<long>(current));
        }
        memo[key] = new HashSet<List<long>>(combinations);
        return;
    }

    if (index >= list.Count || remaining < 0)
    {
        memo[key] = new HashSet<List<long>>(combinations);
        return;
    }

    // Include the current element
    current.Add(list[index]);
    Combine(list, index + 1, current, remaining - list[index], combinations);
    current.RemoveAt(current.Count - 1); // Backtrack

    // Exclude the current element
    Combine(list, index + 1, current, remaining, combinations);

    memo[key] = new HashSet<List<long>>(combinations);
}

public static long Solve(long sum)
{
    List<long> all2Variations = new List<long>();
    int closest_log2_index = (int)Math.Floor(Math.Log(sum, 2));

    for (int i = closest_log2_index; i >= 0; i--)
    {
        all2Variations.Add((long)Math.Pow(2, i));
        all2Variations.Add((long)Math.Pow(2, i));
    }

    Console.WriteLine($"[{string.Join(", ", all2Variations)}]");
    List<List<long>> combos = CalculateCombinations(all2Variations, sum);

    foreach (var item in combos)
    {
        Console.WriteLine(string.Join(", ", item));
    }

    Console.WriteLine("Calls: " + calls);
    return combos.Count;
}
    }*/

/* Working 1.0.1 */
/*using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinRepresentation
{
    public class CoinRepresentation
    {
        public static List<List<long>> CalculateCombinations(List<long> list, long z)
        {
            var combinations = new HashSet<List<long>>(); // Use HashSet for efficient duplicate checking

            Combine(list, 0, new List<long>(), z, combinations);
            return combinations.ToList();
        }

        private static void Combine(List<long> list, int index, List<long> current, long remaining, HashSet<List<long>> combinations)
        {
            if (remaining == 0)
            {
                if (!combinations.Any(list => list.SequenceEqual(current)))
                {
                    combinations.Add(new List<long>(current));
                }
                return;
            }

            if (index >= list.Count || remaining < 0)
            {
                return;
            }

            // Include the current element
            current.Add(list[index]);
            Combine(list, index + 1, current, remaining - list[index], combinations);
            current.RemoveAt(current.Count - 1); // Backtrack
            Combine(list, index + 1, current, remaining, combinations);

        }

        public static long Solve(long sum)
        {
            List<long> all2Variations = new List<long>();
            int closest_log2_index = (int)Math.Floor(Math.Log(sum, 2));
            *//*            for (int i = closest_log2_index; i >= 0; i--)
                        {
                            all2Variations.Add((long)Math.Pow(2, i));
                            all2Variations.Add((long)Math.Pow(2, i));
                        }*//*

            for (int i = 0; i < closest_log2_index; i++)
            {
                all2Variations.Add((long)Math.Pow(2, i));
                all2Variations.Add((long)Math.Pow(2, i));
            }


            List<List<long>> combos = CalculateCombinations(all2Variations, sum);
            foreach (var item in combos)
            {
                Console.WriteLine(string.Join(", ", item));
            }

            return combos.Count;
        }

    }
}*/

/*Not Working 1.2*/

/*using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinRepresentation
{

    public class CoinRepresentation
    {
        private static Hashtable _cache = new Hashtable();

        static Dictionary<long, List<long>> memo = new Dictionary<long, List<long>>();
        public static List<List<long>> CalculateCombinations(List<long> list, long z)
        {
            var combinations = new HashSet<List<long>>(); // Use HashSet for efficient duplicate checking

            Combine(list, 0, new List<long>(), z, combinations);
            return combinations.ToList();
        }

        private static void Combine(List<long> list, int index, List<long> current, long remaining, HashSet<List<long>> combinations)
        {
            if (index < list.Count && memo.ContainsKey(list[index]))
            {
                current = new List<long>(memo[list[index]]);
            }
            if (combinations.Count == 700)
            {
                int a;
            }
            if (remaining == 0)
            {
                if (!combinations.Any(list => list.SequenceEqual(current)))
                {
                    combinations.Add(new List<long>(current));
                }
                return;
            }

            if (index >= list.Count || remaining < 0)
            {
                return;
            }

            // Include the current element
            current.Add(list[index]);
            Combine(list, index + 1, current, remaining - list[index], combinations);
            current.RemoveAt(current.Count - 1); // Backtrack
            Combine(list, index + 1, current, remaining, combinations);

            memo[list[index]] = current;

            // Exclude the current element
            *//*f (index > 0   )
            {
                
                if (list[index] != list[index - 1])
                {
                    current.RemoveAt(current.Count - 1); // Backtrack
                    Combine(list, index + 1, current, remaining, combinations);
                }
            }
            else
            {
                current.RemoveAt(current.Count - 1); // Backtrack
                Combine(list, index + 1, current, remaining, combinations);
            }*//*

        }

        public static long Solve(long sum)
        {
            long ans = sum;
            if (sum < 0) return 0; // No coins and no sum possible
            if (sum is 0) return 1; // Complete combination found

            if (sum % 2 is 0)
            {
                ans = Solve(sum / 2) + Solve(sum / 2 - 1);
            }
            else
            {
                ans = Solve((sum - 1) / 2);
            }
            return ans;
        }

    }
}
*/

/* Not Working 1.2 */
/*private static long Solving(int index, long remaining, List<long> current)
{
    if (remaining == 0)
    {
        if (!combinations.Any(list => list.SequenceEqual(current)))
        {
            combinations.Add(new List<long>(current));
        }
        return 1;
    }

    if (index >= lis.Count || remaining < 0)
    {
        return 0;
    }

    current.Add(lis[index]);
    long temp = Solving(index + 1, remaining - lis[index], current);
    current.RemoveAt(current.Count - 1);
    long temp1 = Solving(index + 1, remaining, current);
    *//*            Console.WriteLine(temp + " T");
                Console.WriteLine(temp1 + " T1");*/
/*ans = Math.Max(temp1, temp);*//*

ans = temp + temp1;
return temp;


}


public static long Solve(long sum)
{
lis = new List<long>();
int closest_log2_index = (int)Math.Floor(Math.Log(sum, 2));
for (int i = 0; i <= closest_log2_index; i++)
{
    lis.Add((long)Math.Pow(2, i));
    lis.Add((long)Math.Pow(2, i));
}

combinations = new List<List<long>>();
long a = Solving(0, sum, new List<long>());
return combinations.Count();
}
private static long Solving(int index, long remaining, List<long> current)
{
if (remaining == 0)
{
    if (!combinations.Any(list => list.SequenceEqual(current)))
    {
        combinations.Add(new List<long>(current));
    }
    return 1;
}

if (index >= lis.Count || remaining < 0)
{
    return 0;
}

current.Add(lis[index]);
long temp = Solving(index + 1, remaining - lis[index], current);
current.RemoveAt(current.Count - 1);
long temp1 = Solving(index + 1, remaining, current);
*//*            Console.WriteLine(temp + " T");
            Console.WriteLine(temp1 + " T1");*/
/*ans = Math.Max(temp1, temp);*//*

ans = temp + temp1;
return temp;


}


public static long Solve(long sum)
{
lis = new List<long>();
int closest_log2_index = (int)Math.Floor(Math.Log(sum, 2));
for (int i = 0; i <= closest_log2_index; i++)
{
    lis.Add((long)Math.Pow(2, i));
    lis.Add((long)Math.Pow(2, i));
}

combinations = new List<List<long>>();
long a = Solving(0, sum, new List<long>());
return combinations.Count();
}*/

/* Working 2.0 */
/*public static int Solve(long Z)
{
    int count = 0;
    long power = 1;

    while (Z > 0)
    {
        if (Z >= power)
        {
            Z -= power;
            count++;
        }
        power <<= 1;
    }

    return count;
}*/

/* Working 2.1 */
/*public static long Solve(long sum)
{
    long ans = sum;
    if (sum < 0) return 0; // No coins and no sum possible
    if (sum is 0) return 1; // Complete combination found

    if (sum % 2 is 0)
    {
        ans = Solve(sum / 2) + Solve(sum / 2 - 1); // We split the problem into 2 parts, one where we include the current coin and one where we don't include the current coin. We find all possibilites for both and combine those possibilites to find the total number of possibilites with and without the coin
    }
    else
    {
        ans = Solve((sum - 1) / 2); // We use ((sum -1) / 2) becuase that's the only way to obtain a valid coin value. Since the coins are all made with powers of 2, to find the sum of Z, the biggest coin we can use is sum/2 which gives the biggest coin we can use to find the sum. We do sum -1 because we can't find the coin for an odd number coin since we only have 1 odd coin, this basically makes it even and allows the next recursion block to handle it properly
    }
    return ans;
}*/

/* Bridging 1.4 */
/*static long CountWays(long Z, int exponent)
{
    if (Z == 0)
        return 1; // Base case: found a valid combination

    if (Z < 0 || exponent < 0)
        return 0; // Base case: no valid combination

    // Choose not to include coin with 2^exponent value
    long withoutCoin = CountWays(Z, exponent - 1);

    // Choose to include coin with 2^exponent value
    long withCoin = CountWays(Z - (long)Math.Pow(2, exponent), exponent - 1);

    return withoutCoin + withCoin;
}

public static long Solve(long sum)
{
    int maxExponent = (int)Math.Floor(Math.Log(sum, 2));
    return CountWays(sum, maxExponent);
}*/