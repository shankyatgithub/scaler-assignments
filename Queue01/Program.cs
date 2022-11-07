// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

#region "assignment #1 PerfectNumbers"
/*
Given an integer A, you have to find the Ath Perfect Number.
A Perfect Number has the following properties:
It comprises only 1 and 2.
The number of digits in a Perfect number is even.
It is a palindrome number.
For example, 11, 22, 112211 are Perfect numbers, where 123, 121, 782, 1 are not.
*/

//string? input = "4"; //Console.ReadLine();
//Console.WriteLine($"Perfect Number  {perfectNumber(Convert.ToInt32(input))}");
//Console.WriteLine($"EvenPallindrome  {evenPallindrome(Convert.ToInt32(input))}");

string perfectNumber(int A)
{
    Queue<string> q1 = new Queue<string>();
    q1.Enqueue("1");
    q1.Enqueue("2");

    for (int i = 1; i < A; i++)
    {
        string x = q1.First();
        q1.Dequeue();
        q1.Enqueue(x + "1");
        q1.Enqueue(x + "2");
    }

    return q1.First();
}

string evenPallindrome(int A)
{
    Queue<string> q1 = new Queue<string>();
    q1.Enqueue("11");
    q1.Enqueue("22");

    string s1 = "11";
    string s2 = "22";

    for (int i = 1; i < A; i++)
    {
        string x = q1.First();
        {
            if (x.Length == 1)
            {
                q1.Dequeue();
                q1.Enqueue(x + x);
                Console.WriteLine($"q1.First() - {q1.First()}");
            }
            else
            {
                Console.WriteLine($"length of {x} is {x.Length}");
                string tempString1 = x.Substring(0, (x.Length / 2));
                string tempString2 = x.Substring((x.Length / 2), x.Length - (x.Length / 2));
                q1.Dequeue();
                q1.Enqueue(tempString1 + s1 + tempString2);
                q1.Enqueue(tempString1 + s2 + tempString2);
            }
        }
    }

    return q1.First();
}

#endregion

#region "assignment #2 Task Schedulling"
/*
A CPU has N tasks to be performed. 
It is to be noted that the tasks have to be completed in a specific order to avoid deadlock. 
In every clock cycle, the CPU can either perform a task or move it to the back of the queue. 
You are given the current state of the scheduler queue in array A and the required order of the tasks in array B.
*/
//Console.WriteLine(TaskScheduling(new List<int>{2},new List<int>{2}).ToString());

int TaskScheduling(List<int> A, List<int> B)
{
    int returnValue = 0;
    Queue<int> q1 = new Queue<int>();

    foreach (int item in A)
    {
        q1.Enqueue(item);
    }

    foreach (int item in B)
    {
        while (q1.First() != item)
        {
            int tempVar = q1.First();
            q1.Dequeue();
            q1.Enqueue(tempVar);
            returnValue++;
        }
        q1.Dequeue();
        returnValue++;
    }

    return returnValue;
}

#endregion

#region "assignment #3 first non-repeating character"
Console.WriteLine(FirstNonRepeatingCharacter("abadbc"));
string FirstNonRepeatingCharacter(string A)
{
    Queue<char> q1 = new Queue<char>();
    Dictionary<char, int> d = new Dictionary<char, int>();
    StringBuilder sb = new StringBuilder();

    foreach (char a in A)
    {
        q1.Enqueue(a);

        if (!d.ContainsKey(a))
        {
            d.Add(a, 1);
        }
        else
        {
            int i = d[a];
            d[a] = i + 1;
        }

        while (q1.Count > 0 && d[q1.First()] > 1)
        {
            q1.Dequeue();
        }

        if (q1.Count == 0)
        {
            sb.Append("#");
        }
        else
        {
            sb.Append(q1.First());
        }
    }

    return sb.ToString();
}
#endregion