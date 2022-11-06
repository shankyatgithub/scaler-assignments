// See https://aka.ms/new-console-template for more information
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
string? input = "4"; //Console.ReadLine();
Console.WriteLine($"Perfect Number  {perfectNumber(Convert.ToInt32(input))}");
Console.WriteLine($"EvenPallindrome  {evenPallindrome(Convert.ToInt32(input))}");

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
                string tempString2 = x.Substring((x.Length / 2), x.Length-(x.Length/2));
                q1.Dequeue();
                q1.Enqueue(tempString1 + s1 + tempString2);
                q1.Enqueue(tempString1 + s2 + tempString2);
            }
        }
    }

    return q1.First();
}

#endregion