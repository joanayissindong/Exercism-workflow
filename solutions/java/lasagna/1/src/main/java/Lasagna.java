public class Lasagna {
    // TODO: define the 'expectedMinutesInOven()' method
    public int expectedMinutesInOven() {
        int expectedMinutes = 0;
        expectedMinutes = 40;
        return expectedMinutes;
    }

    // TODO: define the 'remainingMinutesInOven()' method
    public int remainingMinutesInOven(int actualMinutes) {
        int remainingMinutes = 0;
        remainingMinutes = expectedMinutesInOven() - actualMinutes;
        return remainingMinutes;
    }

    // TODO: define the 'preparationTimeInMinutes()' method
    public int preparationTimeInMinutes(int layers) {
        int preparationTime = 0;
        preparationTime = layers * 2;
        return preparationTime;
    }

    // TODO: define the 'totalTimeInMinutes()' method
    public int totalTimeInMinutes(int layers, int actualMinutes) {
        int totalTime = 0;
        totalTime = preparationTimeInMinutes(layers) + actualMinutes;
        return totalTime;
    }
}
