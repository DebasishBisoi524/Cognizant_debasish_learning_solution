package week1.FactoryMethodPattern;

public class WordDocument implements Document {

    @Override
    public void open() {
        System.out.println("Word Document Open");
    }

    @Override
    public void save() {
        System.out.println("Word document saved");
    }
}
