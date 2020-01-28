package jp.nuits.hatpepper.usecases;

import java.io.IOException;
import java.util.List;
import java.util.function.Consumer;

public interface ReferRestaurants {
    void Find(Consumer<List<Restaurant>> consumer);
}
