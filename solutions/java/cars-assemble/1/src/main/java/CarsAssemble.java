public class CarsAssemble {

    public static double productionRatePerHour(int speed) {
        double rate = 0;
        if (speed >= 1 && speed <= 4) {
            rate = 1.0;
        } else if (speed >= 5 && speed <= 8) {
            rate = 0.9;
        } else if (speed == 9) {
            rate = 0.8;
        } else if (speed == 10) {
            rate = 0.77;
        } else {
            rate = 0.0;
        }

        return speed * rate * 221;
    }

    public static int workingItemsPerMinute(int speed) {
        return (int) (productionRatePerHour(speed) / 60);
    }
}
