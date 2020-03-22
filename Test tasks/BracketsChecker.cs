using System.Collections.Generic;


public class CustomStack 
{
    public List<char> _stack;

    public CustomStack() 
    {
        _stack = new List<char>();
    }
    
    public char Pop()
    {
        char x = _stack[_stack.Count - 1];
        _stack.RemoveAt(_stack.Count - 1);
        return x;
    }

    public void Push(char bracket)
    {
        _stack.Add(bracket);
    }
}


public class BracketsChecker
{
    public bool IsValid(string input)
    {
        CustomStack leftBrackets = new CustomStack(); 
        CustomStack rightBrackets = new CustomStack(); 

        foreach(var item in input)
        {
            if ('('.Equals(item) || '{'.Equals(item) || '['.Equals(item))
            {
                leftBrackets.Push(item);
            }
        }
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (')'.Equals(input[i]) || '}'.Equals(input[i]) || ']'.Equals(input[i]))
            {
                rightBrackets.Push(input[i]);
            }
        }
        if (leftBrackets._stack.Count != rightBrackets._stack.Count)
        {
            return false;
        }
        for(int i = 0; i < leftBrackets._stack.Count; i++)
        {
            char left = leftBrackets.Pop();
            char right = rightBrackets.Pop();
            switch (left)
            {
                case '(':
                    if (!')'.Equals(right))
                    {
                        return false;
                    }
                    continue;
                case '{':
                    if (!'}'.Equals(right))
                    {
                        return false;
                    }
                    continue;
                default:
                    if (!']'.Equals(right))
                    {
                        return false;
                    }
                    continue;
            }
        }
        return true;
    }
}
