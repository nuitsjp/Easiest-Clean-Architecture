package jp.nuits.hatpepper.infrastructures.services;

import java.util.ArrayList;
import java.util.List;
import java.util.function.Consumer;

import jp.nuits.hatpepper.usecases.GourmetSearchApi;
import jp.nuits.hatpepper.usecases.Restaurant;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Retrofit;

public class GourmetSearchApiImpl implements GourmetSearchApi {

    private final Retrofit retrofit;

    public GourmetSearchApiImpl(Retrofit retrofit) {
        this.retrofit = retrofit;
    }

    @Override
    public void search(Consumer<List<Restaurant>> consumer) {
        GourmetRetrofitService retrofitService = retrofit.create(GourmetRetrofitService.class);
        Call<GourmetSearchResults> call = retrofitService.Search(Secrets.API_KEY);
        call.enqueue(new Callback<GourmetSearchResults>() {
            @Override
            public void onResponse(Call<GourmetSearchResults> call, retrofit2.Response<GourmetSearchResults> response) {
                ArrayList<Restaurant> restaurants = new ArrayList<>();

                GourmetSearchResults gourmetSearchResults = response.body();
                for (Shop shop : gourmetSearchResults.getResults().getShop())
                {
                    restaurants.add(new Restaurant(shop.getName()));
                }
                consumer.accept(restaurants);
            }

            @Override
            public void onFailure(Call<GourmetSearchResults> call, Throwable t) {
                // 本来は例外処理を行うべきだが、本題から外れるため省略
            }
        });
    }
}
