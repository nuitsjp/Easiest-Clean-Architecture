package jp.nuits.hatpepper.entities;

import java.io.IOException;
import java.util.List;
import java.util.function.Consumer;

public interface GourmetSearchApi {
    void search(Consumer<GourmetSearchResults> consumer);
}
