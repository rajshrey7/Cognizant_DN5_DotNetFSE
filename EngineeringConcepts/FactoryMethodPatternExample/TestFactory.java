public class TestFactory {

    public static void main(String[] args) {

        System.out.println("========== FACTORY METHOD PATTERN ==========\n");

        DocumentFactory wordFactory =
                new WordDocumentFactory();

        DocumentFactory pdfFactory =
                new PdfDocumentFactory();

        DocumentFactory excelFactory =
                new ExcelDocumentFactory();

        System.out.println("Creating Documents...\n");

        wordFactory.createDocument().open();
        pdfFactory.createDocument().open();
        excelFactory.createDocument().open();

        System.out.println("\nAll documents created successfully.");

        System.out.println("\n============================================");
    }
}