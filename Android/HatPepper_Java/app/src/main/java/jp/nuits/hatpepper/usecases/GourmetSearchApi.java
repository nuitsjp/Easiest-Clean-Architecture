package jp.nuits.hatpepper.usecases;

import java.util.List;
import java.util.function.Consumer;

public interface GourmetSearchApi {
    void search(Consumer<List<Restaurant>> consumer);
}
