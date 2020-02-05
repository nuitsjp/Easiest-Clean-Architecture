package jp.nuits.hatpepper.infrastructure.api

import retrofit2.Call
import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Query

interface RetrofitGourmetSearchApi {
    @GET("/hotpepper/gourmet/v1/?large_area=Z011&format=json&range=1&card=1&count=100")
    suspend fun search(
        @Query("key") apiKey : String,
        @Query("lng") longitude : Double,
        @Query("lat") latitude : Double,
        @Query("lunch") lunch : Int)
            : Response<GourmetSearchResults>
}