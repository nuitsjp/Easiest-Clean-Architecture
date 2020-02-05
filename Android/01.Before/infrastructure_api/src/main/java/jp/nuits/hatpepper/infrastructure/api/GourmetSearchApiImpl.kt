package jp.nuits.hatpepper.infrastructure.api

import android.location.Location
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class GourmetSearchApiImpl : GourmetSearchApi {

    private val retrofit by lazy {
        Retrofit
            .Builder()
            .baseUrl("https://webservice.recruit.co.jp/")
            .addConverterFactory(GsonConverterFactory.create())
            .build() }

    override suspend fun find(location: Location, lunchTimeOnly : Boolean) : GourmetSearchResults {
        val retrofitService = retrofit.create(RetrofitGourmetSearchApi::class.java)
        val response =
            retrofitService.search(
                Secrets.API_KEY,
                location.longitude,
                location.latitude,
                if(lunchTimeOnly) 1 else 0)
        return response.body()!!
    }
}