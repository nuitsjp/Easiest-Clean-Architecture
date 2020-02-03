package jp.nuits.hatpepper.infrastructure.api

import jp.nuits.hatpepper.usecase.impl.GourmetSearchApi
import jp.nuits.hatpepper.usecase.impl.DeviceLocation
import jp.nuits.hatpepper.usecase.Shop
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class GourmetSearchApiImpl : GourmetSearchApi {

    private val retrofit by lazy {
        Retrofit
            .Builder()
            .baseUrl("https://webservice.recruit.co.jp/")
            .addConverterFactory(GsonConverterFactory.create())
            .build() }

    override suspend fun find(location: DeviceLocation, lunchTimeOnly : Boolean) : List<Shop> {
        val retrofitService = retrofit.create(RetrofitGourmetSearchApi::class.java)
        val response =
            retrofitService.search(
                Secrets.API_KEY,
                location.longitude,
                location.latitude,
                if(lunchTimeOnly) 1 else 0)
        return response.body()!!.results.shop
                .map {
                    Shop(
                        it.id,
                        it.name,
                        it.genre.name,
                        it.genre.catch,
                        it.photo.pc.l,
                        it.budget.average,
                        it.mobile_access)
                }.toList()
    }
}