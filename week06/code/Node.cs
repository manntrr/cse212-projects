public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        // add else case to test greater in order to add this to the tree, otherwise it is a duplicate and do nothing
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if ((Left is null && Right is null) || Data == value)
        {
            return Data == value;
        }
        else if (Left is not null && value < Data)
        {
            // search the left
            return Left.Contains(value);
        }
        else if (Right is not null)
        {
            // search the right
            return Right.Contains(value);
        }
        else
        {
            return false;
        }
    }

    public int GetHeight()
    {
        return int.Max(Left is null ? 0 : Left.GetHeight(), Right is null ? 0 : Right.GetHeight()) + 1;
    }
}