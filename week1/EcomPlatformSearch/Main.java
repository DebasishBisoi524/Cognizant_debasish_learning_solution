package week1.EcomPlatformSearch;

import java.util.Arrays;

public class Main {
    public static Product linearSearch(Product[] products, String targetName) {
        for (Product p : products) {
            if (p.productName.equalsIgnoreCase(targetName)) {
                return p;
            }
        }
        return null;
    }

    public static Product binarySearch(Product[] products, String targetName) {
        int low = 0;
        int high = products.length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;
            int cmp = products[mid].productName.compareToIgnoreCase(targetName);

            if (cmp == 0) {
                return products[mid];
            } else if (cmp < 0) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return null;
    }

    public static void main(String[] args) {
        Product[] products = {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Mouse", "Accersories"),
                new Product(3, "Keyboard", "Accessories"),
                new Product(4, "Phone", "Electronics"),
                new Product(5, "Watch", "Wearables")
        };

        Product[] sortedProducts = Arrays.copyOf(products, products.length);
        Arrays.sort(sortedProducts);

        String target = "keyboard";

        Product linearResult = linearSearch(products, target);
        System.out.println("Linear Search Result: " + (linearResult != null ? linearResult : "Not Found"));

        Product binaryResult = binarySearch(sortedProducts, target);
        System.out.println("Binary Search Result: " + (binaryResult != null ? binaryResult : "Not Found"));
    }
}
