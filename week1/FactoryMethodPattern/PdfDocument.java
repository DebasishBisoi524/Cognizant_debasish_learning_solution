package week1.FactoryMethodPattern;

public class PdfDocument implements Document {
    @Override
    public void open() {
        System.out.println("PDF document opened");
    }

    @Override
    public void save() {
        System.out.println("PDF document saved");
    }
}