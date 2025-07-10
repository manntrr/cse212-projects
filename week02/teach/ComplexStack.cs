public static class ComplexStack
{
    public static bool DoSomethingComplicated(string line)
    {
        // hypotesis:  test for valid pairs of (), [], and {}'s

        // input #1
        // line = "(a == 3 or (b == 5 and c == 6))"
        // result = true
        // input #2
        // line = "(students]i].Grade > 80 and students[i].Grade < 90)"
        // result = false
        // input #3
        // line = "(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"
        // result = false
        var stack = new Stack<char>();
        foreach (var item in line)
        {
            if (item is '(' or '[' or '{')
            {
                stack.Push(item);
            }
            else if (item is ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']')
            {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}