package week1.FactoryMethodPattern;

public class Main {
    public static void main(String[] args) {
        // Create factories
        DocumentFactory wordFactory = new WordDocumentFactory();
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        DocumentFactory excelFactory = new ExcelDocumentFactory();

        // Produce documents
        Document wordDoc = wordFactory.createDocument();
        Document pdfDoc = pdfFactory.createDocument();
        Document excelDoc = excelFactory.createDocument();

        // Use documents
        System.out.println("Working with Word document:");
        wordDoc.open();
        wordDoc.save();

        System.out.println("\nWorking with PDF document:");
        pdfDoc.open();
        pdfDoc.save();

        System.out.println("\nWorking with Excel document:");
        excelDoc.open();
        excelDoc.save();

        // Using the template method
        System.out.println("\nCreating new document via template method:");
        excelFactory.newDocument();
    }
}