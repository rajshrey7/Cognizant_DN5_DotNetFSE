public class TaskManagementSystem {

    static class Node {

        Task task;
        Node next;

        Node(Task task) {
            this.task = task;
        }
    }

    static Node head = null;

    public static void addTask(Task task) {

        Node newNode = new Node(task);

        if(head == null) {
            head = newNode;
        }
        else {

            Node temp = head;

            while(temp.next != null) {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        System.out.println(
                "Task Added Successfully");
    }

    public static Task searchTask(int taskId) {

        Node temp = head;

        while(temp != null) {

            if(temp.task.taskId == taskId)
                return temp.task;

            temp = temp.next;
        }

        return null;
    }

    public static void deleteTask(int taskId) {

        if(head == null)
            return;

        if(head.task.taskId == taskId) {

            head = head.next;

            System.out.println(
                    "Task Deleted Successfully");

            return;
        }

        Node temp = head;

        while(temp.next != null &&
              temp.next.task.taskId != taskId) {

            temp = temp.next;
        }

        if(temp.next != null) {

            temp.next = temp.next.next;

            System.out.println(
                    "Task Deleted Successfully");
        }
    }

    public static void displayTasks() {

        Node temp = head;

        while(temp != null) {

            System.out.println(
                    temp.task);

            temp = temp.next;
        }
    }

    public static void main(String[] args) {

        System.out.println(
                "===== ADD TASKS =====");

        addTask(
                new Task(
                        101,
                        "Design UI",
                        "Pending"));

        addTask(
                new Task(
                        102,
                        "Develop Backend",
                        "In Progress"));

        System.out.println(
                "\n===== TASK LIST =====");

        displayTasks();

        System.out.println(
                "\n===== SEARCH TASK =====");

        System.out.println(
                searchTask(102));

        System.out.println(
                "\n===== DELETE TASK =====");

        deleteTask(101);

        System.out.println(
                "\n===== FINAL TASK LIST =====");

        displayTasks();

        System.out.println(
                "\n===== TIME COMPLEXITY =====");

        System.out.println(
                "Add      : O(n)");

        System.out.println(
                "Search   : O(n)");

        System.out.println(
                "Traverse : O(n)");

        System.out.println(
                "Delete   : O(n)");
    }
}