using System.Collections;
public class program
{
    public static void Main(string[] args)
    {
        //ArrayList
        Console.WriteLine("ArrayList");
        ArrayList students = new ArrayList();
        students.Add("John");
        students.Add("Alice");
        Console.WriteLine("Adding :"+String.Join(",", students.ToArray()));

        students.RemoveAt(1);
        Console.WriteLine("Remove :" + String.Join(",", students.ToArray()));

        students.Add("Devang");
        students.Add("Raj");

        students.RemoveRange(0, 2);
        Console.WriteLine("Remove range :" + String.Join(",", students.ToArray()));

        students.Clear();
        Console.WriteLine("Clear all  :" + String.Join(",", students.ToArray()));
        Console.WriteLine();
        //List
        Console.WriteLine("List");
        List<string> s1 = new List<string>();
        s1.Add("Devang");
        s1.Add("Hadiyal");
        s1.Add("Raj");
        Console.WriteLine("Add List:" + String.Join(",", s1.ToArray()));

        s1.RemoveAt(0);
        Console.WriteLine("Remove :" + String.Join(",", s1.ToArray()));

        s1.RemoveRange(0, 2);
        Console.WriteLine("Remove Range :" + String.Join(",", s1.ToArray()));

        s1.Clear();
        Console.WriteLine();
        //Stack
        Console.WriteLine("Stack");
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        Console.WriteLine("After Pushing: " + string.Join(", ", stack));

        Console.WriteLine("Popped: " + stack.Pop());

        Console.WriteLine("Peek: " + stack.Peek());

        Console.WriteLine("Contains 20: " + stack.Contains(20));
        stack.Clear();
        Console.WriteLine();
        //Queue
        Console.WriteLine("Queue");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        Console.WriteLine("After Enqueuing: " + string.Join(", ", queue));

        Console.WriteLine("Dequeued: " + queue.Dequeue());
        Console.WriteLine("After Enqueuing: " + string.Join(", ", queue));

        Console.WriteLine("Peek: " + queue.Peek());
        Console.WriteLine("After Enqueuing: " + string.Join(", ", queue));

        Console.WriteLine("Contains 20: " + queue.Contains(20));

        queue.Clear();
        Console.WriteLine("Clear: " + string.Join(", ", queue));
        Console.WriteLine();
        //Dictionary
        Console.WriteLine("Dictionary");
        Dictionary<int, string> s2 = new Dictionary<int, string>();
        s2.Add(1, "Devang");
        s2.Add(2, "Smit");
        s2.Add(3, "Prince");
        Console.WriteLine("After Adding: " + string.Join(", ", s2.Select(kv => kv.Key + "=" + kv.Value)));

        s2.Remove(1);
        Console.WriteLine("After Remove: " + string.Join(", ", s2.Select(kv => kv.Key + "=" + kv.Value)));

        Console.WriteLine("Contains Key 2: " + s2.ContainsKey(2));
        Console.WriteLine("Contains Value 'Alice': " + s2.ContainsValue("Alice"));

        s2.Clear();
        Console.WriteLine("After Clrear: " + string.Join(", ", s2.Select(kv => kv.Key + "=" + kv.Value)));
        Console.WriteLine();
        //Hashtable
        Console.WriteLine("Hashtable");

        Hashtable s3 = new Hashtable();
        s3.Add(1, "Devang");
        s3.Add(2, "Smit");
        s3.Add(3, "Prince");
        Console.WriteLine("After Adding: " + string.Join(", ", s3.Keys.Cast<int>().Select(k => k + "=" + s3[k])));

        s3.Remove(1);
        Console.WriteLine("After Remove: " + string.Join(", ", s3.Keys.Cast<int>().Select(k => k + "=" + s3[k])));

        Console.WriteLine("Contains Key 2: " + s3.ContainsKey(2));
        Console.WriteLine("Contains Value 'Alice': " + s3.ContainsValue("Devang"));


        s3.Clear();
        Console.WriteLine("After Adding: " + string.Join(", ", s3.Keys.Cast<int>().Select(k => k + "=" + s3[k])));


    }
}