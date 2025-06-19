package week1.EcomPlatformSearch;

public class Product implements Comparable<Product> {
    int productId;
    String productName;
    String category;

    Product(int productId, String productName, String category) {
        this.productId = productId;
        this.productName = productName;
        this.category = category;
    }

    @Override
    public int compareTo(Product other) {
        return this.productName.compareToIgnoreCase(other.productName);
    }

    @Override
    public String toString() {
        return "Product{" + "id=" + productId + ", name='" + productName + "', category='" + category + "'}";
    }
}
