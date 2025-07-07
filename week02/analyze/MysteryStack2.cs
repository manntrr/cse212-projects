public static class MysteryStack2
{

    // this is a postfix basic mathematics expression evaluation routine
    // #2 results
    //      5 3 7 + * ==> 5 10 * ==> 50
    //      6 2 + 5 3 - / ==> 8 5 3 - / ==> 8 2 / ==> 4
    // #3 inputs for errors:
    //      "invalid case 1" ==> 1 + 2
    //      "invalid case 2" ==> 1 0 /
    //      "invalid case 3" ==> 1 ^ 2
    //      "invalid case 4" ==> 0 1 1 -
    private static bool IsFloat(string text)
    {
        return float.TryParse(text, out _);
    }

    public static float Run(string text)
    {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' '))
        {
            if (item == "+" || item == "-" || item == "*" || item == "/")
            {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+")
                {
                    res = op1 + op2;
                }
                else if (item == "-")
                {
                    res = op1 - op2;
                }
                else if (item == "*")
                {
                    res = op1 * op2;
                }
                else
                {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item))
            {
                stack.Push(float.Parse(item));
            }
            else if (item == "")
            {
            }
            else
            {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}