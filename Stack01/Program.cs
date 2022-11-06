// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
//Console.WriteLine(BalancedParanthesis(""));
//Console.WriteLine(DoubleCharacterTrouble("abccbac"));
//Console.WriteLine(EvaluateExpression(new List<string>() { "2", "1", "+", "3", "*" }));
//Console.WriteLine(EvaluateExpression(new List<string>() { "4", "13", "5", "/", "+" }));




int BalancedParanthesis(string A)
{
    Stack<char> s = new Stack<char>();
    char[] a = A.ToCharArray();
    foreach (char t in a)
    {
        if (t == '(' || t == '{' || t == '[')
        {
            s.Push(t);
        }
        else
        {
            if (t == ')')
            {
                if (s.Count == 0 || !(s.Peek().Equals('(')))
                {
                    return 0;
                }
                else
                {
                    s.Pop();
                }
            }
            else if (t == '}')
            {

                if (s.Count == 0 || !(s.Peek().Equals('{')))
                {
                    return 0;
                }
                else
                {
                    s.Pop();
                }
            }
            else if (t == ']')
            {
                if (s.Count == 0 || !(s.Peek().Equals('[')))
                {
                    return 0;
                }
                else
                {
                    s.Pop();
                }
            }
        }
    }

    if (s.Count == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }

}

string DoubleCharacterTrouble(string A)
{
    Stack<char> stk = new Stack<char>();
    char[] a = A.ToCharArray();
    foreach (char t in a)
    {
        if (stk.Count == 0)
        {
            stk.Push(t);
        }
        else
        {
            if (stk.Peek().Equals(t))
            {
                stk.Pop();
            }
            else
            {
                stk.Push(t);
            }
        }
    }
    if (stk.Count > 0)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in stk.Reverse())
        {
            sb.Append(item);
        }
        return sb.ToString();
    }
    else
        return string.Empty;
}

int EvaluateExpression(List<string> A)
{
    Stack<int> stk = new Stack<int>();

    foreach (var item in A)
    {
        if (item.Equals("+") || item.Equals("-") || item.Equals("/") || item.Equals("*"))
        {
            int temp1 = stk.Pop();
            int temp2 = stk.Pop();
            if (item.Equals("+"))
            {
                stk.Push(temp2 + temp1);
            }

            if (item.Equals("-"))
            {
                stk.Push(temp2 - temp1);
            }

            if (item.Equals("/"))
            {
                stk.Push(temp2 / temp1);
            }

            if (item.Equals("*"))
            {
                stk.Push(temp2 * temp1);
            }
        }
        else
        {
            stk.Push(Convert.ToInt32(item));
        }
    }
    return stk.Pop();
}

//#5 Simplify Directory Path
//Console.WriteLine(SimplifyDirectoryPath("/a/b/c"));
//Console.WriteLine(SimplifyDirectoryPath("/../"));
//Console.WriteLine(SimplifyDirectoryPath("/./.././ykt/aaa"));

string SimplifyDirectoryPath(string A)
{
    StringBuilder returnValue = new StringBuilder();
    string tempA = A.Replace("//", "/");
    string[] tempArray = A.Split('/');
    Stack<string> stk = new Stack<string>();
    foreach (var a in tempArray)
    {
        if (a != "." && a != ".." && a != "")
        {
            stk.Push(a);
        }
        else if (a == "..")
        {
            if (stk.Count > 0)
                stk.Pop();
        }
    }

    if (stk.Count > 0)
    {
        foreach (var b in stk.Reverse())
        {
            returnValue.Append("/" + b);
        }
    }
    else
    {
        returnValue.Append("/");
    }



    return returnValue.ToString();
}

//#4 Sort stack using another stack
List<int> SortStackUsingAnotherStack(List<int> A)
{
    List<int> returnValue = new List<int>();

        

    return returnValue;
}

