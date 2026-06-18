public class EmployeeManagementSystem {

    static Employee[] employees =
            new Employee[10];

    static int count = 0;

    public static void addEmployee(
            Employee employee) {

        employees[count++] = employee;

        System.out.println(
                "Employee Added Successfully");
    }

    public static Employee searchEmployee(
            int employeeId) {

        for(int i = 0; i < count; i++) {

            if(employees[i].employeeId ==
                    employeeId) {

                return employees[i];
            }
        }

        return null;
    }

    public static void deleteEmployee(
            int employeeId) {

        for(int i = 0; i < count; i++) {

            if(employees[i].employeeId ==
                    employeeId) {

                for(int j = i;
                    j < count - 1;
                    j++) {

                    employees[j] =
                            employees[j + 1];
                }

                count--;

                System.out.println(
                        "Employee Deleted Successfully");

                return;
            }
        }
    }

    public static void displayEmployees() {

        for(int i = 0; i < count; i++) {

            System.out.println(
                    employees[i]);
        }
    }

    public static void main(String[] args) {

        System.out.println(
                "===== ADD EMPLOYEES =====");

        addEmployee(
                new Employee(
                        101,
                        "Rahul",
                        "Developer",
                        50000));

        addEmployee(
                new Employee(
                        102,
                        "Shreyansh",
                        "Tester",
                        40000));

        System.out.println(
                "\n===== EMPLOYEE LIST =====");

        displayEmployees();

        System.out.println(
                "\n===== SEARCH EMPLOYEE =====");

        System.out.println(
                searchEmployee(102));

        System.out.println(
                "\n===== DELETE EMPLOYEE =====");

        deleteEmployee(101);

        System.out.println(
                "\n===== FINAL EMPLOYEE LIST =====");

        displayEmployees();

        System.out.println(
                "\n===== TIME COMPLEXITY =====");

        System.out.println(
                "Add      : O(1)");

        System.out.println(
                "Search   : O(n)");

        System.out.println(
                "Traverse : O(n)");

        System.out.println(
                "Delete   : O(n)");
    }
}