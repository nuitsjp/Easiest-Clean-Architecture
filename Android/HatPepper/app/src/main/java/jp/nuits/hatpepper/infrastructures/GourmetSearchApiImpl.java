package jp.nuits.hatpepper.infrastructures;

import java.util.function.Consumer;

import jp.nuits.hatpepper.entities.GourmetSearchApi;
import jp.nuits.hatpepper.entities.GourmetSearchResults;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class GourmetSearchApiImpl implements GourmetSearchApi {

    private final Retrofit retrofit;

    public GourmetSearchApiImpl(Retrofit retrofit) {
        this.retrofit = retrofit;
    }

    @Override
    public void search(Consumer<GourmetSearchResults> consumer) {
        GourmetRetrofitService retrofitService = retrofit.create(GourmetRetrofitService.class);
        Call<GourmetSearchResults> call = retrofitService.Search(Secrets.API_KEY);
        call.enqueue(new Callback<GourmetSearchResults>() {
            @Override
            public void onResponse(Call<GourmetSearchResults> call, retrofit2.Response<GourmetSearchResults> response) {
                GourmetSearchResults gourmetSearchResults = response.body();
                consumer.accept(gourmetSearchResults);
            }

            @Override
            public void onFailure(Call<GourmetSearchResults> call, Throwable t) {
                // 本来は例外処理を行うべきだが、本題から外れるため省略
            }
        });
    }
}
