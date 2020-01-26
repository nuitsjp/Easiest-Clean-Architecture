package jp.nuits.hatpepper.usecases;

import androidx.core.util.Consumer;

import java.io.IOException;
import java.util.List;

public interface ReferRestaurants {
    void Find(Consumer<List<Restaurant>> consumer);
}
