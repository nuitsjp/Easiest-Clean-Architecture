package jp.nuits.hatpepper.usecases;

public class Restaurant {
    public String getName() {
        return name;
    }

    private final String name;

    public Restaurant(String name) {
        this.name = name;
    }
}
