package jp.nuits.hatpepper.infrastructures;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import javax.inject.Singleton;

import dagger.Module;
import dagger.Provides;
import jp.nuits.hatpepper.entities.GourmetSearchApi;
import okhttp3.OkHttpClient;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

@Module
public class InfrastructureModule {
    @Provides
    @Singleton
    Gson provideGson() {
        return new GsonBuilder().create();
    }

    @Provides
    @Singleton
    OkHttpClient provideOkhttpClient() {
        return new OkHttpClient.Builder().build();
    }

    @Provides
    @Singleton
    Retrofit provideRetrofit(Gson gson, OkHttpClient okHttpClient) {
        return new Retrofit.Builder()
                .addConverterFactory(GsonConverterFactory.create(gson))
                // ベースのURLの設定
                .baseUrl("https://webservice.recruit.co.jp")
                .client(okHttpClient)
                .build();
    }

    @Provides
    @Singleton
    public GourmetSearchApi provideGourmetSearchApi(Retrofit retrofit) {
        // Whenever Dagger needs to provide an instance of type LoginRetrofitService,
        // this code (the one inside the @Provides method) is run.
        return new GourmetSearchApiImpl(retrofit);
    }

}
