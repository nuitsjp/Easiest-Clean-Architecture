package jp.nuits.hatpepper.infrastructures;

import jp.nuits.hatpepper.entities.GourmetSearchApi;
import jp.nuits.hatpepper.entities.GourmetSearchResults;
import okhttp3.OkHttpClient;

public class GourmetSearchApiImpl implements GourmetSearchApi {

    private static final OkHttpClient client = new OkHttpClient();

    @Override
    public GourmetSearchResults Search() {
        return null;
    }
}
