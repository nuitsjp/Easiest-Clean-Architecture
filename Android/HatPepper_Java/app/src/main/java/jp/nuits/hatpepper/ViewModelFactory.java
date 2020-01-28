package jp.nuits.hatpepper;

import android.app.Activity;
import android.content.Context;
import android.location.LocationManager;

import androidx.annotation.NonNull;
import androidx.lifecycle.ViewModel;
import androidx.lifecycle.ViewModelProvider;

import com.google.gson.GsonBuilder;

import jp.nuits.hatpepper.infrastructures.services.GourmetSearchApiImpl;
import jp.nuits.hatpepper.presentations.RestaurantsViewModel;
import jp.nuits.hatpepper.usecases.ReferRestaurantsImpl;
import okhttp3.OkHttpClient;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class ViewModelFactory implements ViewModelProvider.Factory {

    private final Context context;

    public ViewModelFactory(Context context) {
        this.context = context;
    }

    @NonNull
    @Override
    public <T extends ViewModel> T create(@NonNull Class<T> modelClass) {
        // 実プロダクトではDIコンテナを利用するべきだが、サンプルとしては
        // オブジェクトグラフが見にくくなるため、DIパターンの利用に留める。

        LocationManager mLocationManager = (LocationManager)context.getSystemService(Activity.LOCATION_SERVICE);

        Retrofit retrofit = new Retrofit.Builder()
                .addConverterFactory(GsonConverterFactory.create(new GsonBuilder().create()))
                // ベースのURLの設定
                .baseUrl("https://webservice.recruit.co.jp")
                .client(new OkHttpClient.Builder().build())
                .build();
        return (T)new RestaurantsViewModel(
                new ReferRestaurantsImpl(
                        new GourmetSearchApiImpl(retrofit)
                )
        ) ;
    }
}
