package week1.FactoryMethodPattern;

public abstract class DocumentFactory {
    public abstract Document createDocument();

    public void newDocument() {
        Document doc = createDocument();
        doc.save();
    }
}