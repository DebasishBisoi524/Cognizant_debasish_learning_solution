package week1.EcomPlatformSearch;

public class Main {
    public static void main(String[] args) {
        // Get instances from different calls
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        // Use the log method
        logger1.log("This is the first log message.");
        logger2.log("This is the second log message.");

        // Test if both references point to the same object
        if (logger1 == logger2) {
            System.out.println("Both logger instances are the same. Singleton works.");
        } else {
            System.out.println("Different instances found. Singleton failed.");
        }
    }
}
