public class TestMVC {

    public static void main(String[] args) {

        System.out.println("========== MVC PATTERN ==========\n");

        Student student =
                new Student(
                        "Shreyansh",
                        101,
                        "A");

        StudentView view =
                new StudentView();

        StudentController controller =
                new StudentController(
                        student,
                        view);

        System.out.println("Student Details:");

        controller.updateView();

        System.out.println(
                "\nUpdating Grade...\n");

        controller.updateGrade("A+");

        System.out.println(
                "Updated Student Details:");

        controller.updateView();

        System.out.println(
                "\n=================================");
    }
}