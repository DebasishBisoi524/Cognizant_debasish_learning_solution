package week1.FactoryMethodPattern;

public class ExcelDocument implements Document {
    @Override
    public void open() {
        System.out.println("Excel Document Opened");
    }

    @Override
    public void save() {
        System.out.println("Excel Document Saved");
    }
}
