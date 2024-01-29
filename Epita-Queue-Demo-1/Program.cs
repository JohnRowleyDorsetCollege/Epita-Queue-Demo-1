// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Queue Demonstration");
Queue<int> callerids = new Queue<int>();

callerids.Enqueue(1); //adding to q
callerids.Enqueue(2);
callerids.Enqueue(3);
callerids.Enqueue(4);
callerids.Enqueue(5);

Console.WriteLine($"Q has {callerids.Count} items");

if (callerids.Count > 0)
{
    Console.WriteLine($"First Item is {callerids.Peek}");

}

foreach (int id in callerids)
{
    Console.WriteLine($"Queue item is: [{id}]");
}

while (callerids.Count > 0)
{

    var queueItem = callerids.Dequeue();
    Console.WriteLine($"Processing [{queueItem}]");
    if (callerids.Contains(3))
    {
        Console.WriteLine($"Queue contains 3");
    }
}


try
{
   
    callerids.Dequeue();
}
catch (InvalidOperationException ex)
{

    Console.WriteLine("InvalidOperationException thrown...."); // code to be finished

}
catch (Exception e) 
{

    Console.WriteLine($"Exception thrown....{e.Message}"); // code to be finished

}




Console.WriteLine($"Queue is processed: {callerids.Count} items remaining.");
