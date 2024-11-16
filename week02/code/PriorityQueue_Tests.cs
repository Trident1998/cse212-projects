using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Verify the behavior of a PriorityQueue when multiple items with different priorities are enqueued. 
    //           Items with the same priority should maintain the order they were added (FIFO for same-priority items). 
    //           The item with the highest priority (largest priority value) should be dequeued first, followed by items 
    //           in descending priority order.
    // Expected Result: The 'priorityQueue' should match with 'expectedResult'
    // Defect(s) Found: wrong start index and condition to stop in for loop
    //                  incorrect Dequeue for items with the same priority. Not followed FIFO
    //                  not removed Items in Dequeue() method
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item0", 0);
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item1-2", 1);
        priorityQueue.Enqueue("Item2", 2);

        String[] expectedResult = ["Item2", "Item1", "Item1-2", "Item0"];

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], item);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException), "The queue is empty.")]
    // Scenario:  empty priorityQueue should throw an exception when it is empty
    // Expected Result: Should be InvalidOperationException thrown with "The queue is empty." message 
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }

    // Add more test cases as needed below.
}