package jp.nuits.hatpepper.infrastructures;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Query;

public interface GourmetRetrofitService {
    @GET("/hotpepper/gourmet/v1/?large_area=Z011&format=json")
    Call<GourmetSearchResults> Search(@Query("key") String apiKey);
}
