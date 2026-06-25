using System;

class Task
{
    public int TaskId;
    public string TaskName;
    public string Status;

    public Task(int taskId,
                string taskName,
                string status)
    {
        TaskId = taskId;
        TaskName = taskName;
        Status = status;
    }

    public override string ToString()
    {
        return $"Task ID: {TaskId}, Task Name: {TaskName}, Status: {Status}";
    }
}

class Node
{
    public Task Task;
    public Node Next;

    public Node(Task task)
    {
        Task = task;
        Next = null;
    }
}

class TaskManagementSystem
{
    private Node head;

    public void AddTask(Task task)
    {
        Node newNode = new Node(task);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }

        Console.WriteLine(
            "Task Added Successfully");
    }

    public Task SearchTask(int taskId)
    {
        Node temp = head;

        while (temp != null)
        {
            if (temp.Task.TaskId == taskId)
            {
                return temp.Task;
            }

            temp = temp.Next;
        }

        return null;
    }

    public void DeleteTask(int taskId)
    {
        if (head == null)
            return;

        if (head.Task.TaskId == taskId)
        {
            head = head.Next;

            Console.WriteLine(
                "Task Deleted Successfully");

            return;
        }

        Node temp = head;

        while (temp.Next != null &&
               temp.Next.Task.TaskId != taskId)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;

            Console.WriteLine(
                "Task Deleted Successfully");
        }
    }

    public void DisplayTasks()
    {
        Node temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.Task);

            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        TaskManagementSystem taskSystem =
            new TaskManagementSystem();

        Console.WriteLine(
            "===== ADD TASKS =====\n");

        taskSystem.AddTask(
            new Task(
                101,
                "Design UI",
                "Pending"));

        taskSystem.AddTask(
            new Task(
                102,
                "Develop Backend",
                "In Progress"));

        Console.WriteLine(
            "\n===== TASK LIST =====\n");

        taskSystem.DisplayTasks();

        Console.WriteLine(
            "\n===== SEARCH TASK =====\n");

        Console.WriteLine(
            taskSystem.SearchTask(102));

        Console.WriteLine(
            "\n===== DELETE TASK =====\n");

        taskSystem.DeleteTask(101);

        Console.WriteLine(
            "\n===== FINAL TASK LIST =====\n");

        taskSystem.DisplayTasks();

        Console.WriteLine(
            "\n===== TIME COMPLEXITY =====");

        Console.WriteLine(
            "Add      : O(n)");

        Console.WriteLine(
            "Search   : O(n)");

        Console.WriteLine(
            "Traverse : O(n)");

        Console.WriteLine(
            "Delete   : O(n)");
    }
}