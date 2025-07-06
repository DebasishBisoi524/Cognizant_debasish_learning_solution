package week1.EcomPlatformSearch;

public class Logger {
    // Step 2: Private static instance of the same class
    private static Logger instance;

    // Step 2: Private constructor to prevent instantiation
    private Logger() {
        System.out.println("Logger instance created.");
    }

    // Step 2 & 3: Public static method to provide access to the instance
    public static Logger getInstance() {
        if (instance == null) {
            instance = new Logger();
        }
        return instance;
    }

    // Logging method for demonstration
    public void log(String message) {
        System.out.println("[LOG]: " + message);
    }
}
