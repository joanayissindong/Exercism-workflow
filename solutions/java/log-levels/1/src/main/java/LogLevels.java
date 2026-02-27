public class LogLevels {
    
    public static String message(String logLine) {
        return logLine.substring(logLine.indexOf(']') + 3).trim();
    }

    public static String logLevel(String logLine) {
        int firstIndex = logLine.indexOf('[');
        int lastIndex = logLine.indexOf(']');
        return logLine.substring(firstIndex + 1, lastIndex).trim().toLowerCase();
        
    }

    public static String reformat(String logLine) {
        return message(logLine) + " (" + logLevel(logLine) + ")"; 
    }
}
