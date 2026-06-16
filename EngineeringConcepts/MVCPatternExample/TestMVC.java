public class TestMVC {

    public static void main(String[] args) {

        Student student =
                new Student("Shreyansh", 101, "A");

        StudentView view = new StudentView();

        StudentController controller =
                new StudentController(student, view);

        controller.updateView();

        System.out.println("\nAfter Grade Update\n");

        controller.updateGrade("A+");

        controller.updateView();
    }
}