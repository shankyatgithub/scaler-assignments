// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Nearest smaller element - index less than i
List<int> ans = NearestSmallerElement(new List<int> { 4, 5, 2, 10, 8 });
List<int> ans = NearestSmallerElementOptimized(new List<int> { 3, 2, 1 });
foreach (int a in ans)
{
    Console.WriteLine(a);
}

// O(n2) solution
List<int> NearestSmallerElement(List<int> A)
{
    List<int> returnList = new List<int>();
    returnList.Add(-1);

    for (int i = 0; i < A.Count; i++)
    {
        for (int j = i - 1; j >= 0; j--)
        {
            bool checkValue = false;
            if (A[j] < A[i])
            {
                checkValue = true;
                returnList.Add(A[j]);
                break;
            }
            if (!checkValue && j == 0)
            {
                returnList.Add(-1);
                break;
            }
        }
    }

    return returnList;
}

// O(logN) solution
List<int> NearestSmallerElementOptimized(List<int> A)
{
    List<int> returnValue = new List<int>();
    
    Stack<int> stk = new Stack<int>();

    for (int i = 0; i < A.Count; i++)
    {
        while(stk.Count > 0 && stk.Peek() >= A[i])
        {
            stk.Pop();
        }
        if(stk.Count > 0)
        {
            returnValue.Add(stk.Peek());
        }
        else
        {
            returnValue.Add(-1);
        }
        stk.Push(A[i]);
    }

    return returnValue;
}