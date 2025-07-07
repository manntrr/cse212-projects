using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    /*
        Requirements

        The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        The Dequeue function shall remove the item with the highest priority and return its value.
        If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        If the queue is empty, then an error exception shall be thrown.
    */
    [TestMethod]
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    // Expected Result: the item can be dequeued back off the queue becuase it was in the queue.
    // Defect(s) Found: 
    public void TestPriorityQueue_Enqueue()
    {
        var priorityQueue = new PriorityQueue();
        string test_item = "test data";
        int test_item_pri = 0;
        priorityQueue.Enqueue(test_item, test_item_pri);
        string result = priorityQueue.Dequeue();
        Assert.AreEqual(test_item, result);
    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value and
    //      If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    //          given values of ["a", "b", "c", "d", "e"] and priorities of [0, 0, 0, 0, 0]
    // Expected Result: ["a", "b", "c", "d", "e"]
    // Defect(s) Found: 
    //   not searching from the beggining of the list to find the highest priority
    //   not keeping the first instance index of the highest priority
    //   not removing the dequeued item from the list
    public void TestPriorityQueue_Dequeue_Equal_Pri()
    {
        var priorityQueue = new PriorityQueue();
        string[] test_items = ["a", "b", "c", "d", "e"];
        int[] test_item_priorities = [0, 0, 0, 0, 0];
        string[] exected_results = ["a", "b", "c", "d", "e"];
        for (int index = 0; index < test_items.Length; index++)
        {
            priorityQueue.Enqueue(test_items[index], test_item_priorities[index]);
        }
        for (int index = 0; index < test_items.Length; index++)
        {
            Assert.AreEqual(priorityQueue.Dequeue(), exected_results[index]);
        }
    }
    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value and
    //      If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    //          given values of ["a", "b", "c", "d", "e"] and priorities of [0, 1, 0, 1, 2]
    // Expected Result: ["e", "b", "d", "a", "c"]
    // Defect(s) Found: 
    //   not searching to the end of the list to find the highest priority
    public void TestPriorityQueue_Dequeue_Mixed_Pri()
    {
        var priorityQueue = new PriorityQueue();
        string[] test_items = ["a", "b", "c", "d", "e"];
        int[] test_item_priorities = [0, 1, 0, 1, 2];
        string[] exected_results = ["e", "b", "d", "a", "c"];
        for (int index = 0; index < test_items.Length; index++)
        {
            priorityQueue.Enqueue(test_items[index], test_item_priorities[index]);
        }
        for (int index = 0; index < test_items.Length; index++)
        {
            Assert.AreEqual(priorityQueue.Dequeue(), exected_results[index]);
        }
    }
    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: InvalidOperationException exception shall be thrown
    // Defect(s) Found: 
    public void TestPriorityQueue_Dequeue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        string test_item = "test data";
        int test_item_pri = 0;
        priorityQueue.Enqueue(test_item, test_item_pri);
        priorityQueue.Dequeue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}