package jp.nuits.hatpepper.usecase

import jp.nuits.hatpepper.infrastructure.api.GourmetSearchApi
import jp.nuits.hatpepper.infrastructure.location.DeviceLocationProvider
import jp.nuits.hatpepper.infrastructure.time.TimeProvider
import org.threeten.bp.LocalDateTime

class FindNearbyRestaurantsImpl(
    val deviceLocationProvider: DeviceLocationProvider,
    val timeProvider: TimeProvider,
    val gourmetSearchApi: GourmetSearchApi
) : FindNearbyRestaurants {
    override suspend fun find(): List<Restaurant> {
        // 現在地を取得する
        var deviceLocation = deviceLocationProvider.getDeviceLocation()

        // 現在時刻が11時～14時の間で有った場合、ランチ営業している店舗のみを表示する
        var now = timeProvider.now()
        var lunchStart = LocalDateTime.of(now.year, now.month, now.dayOfMonth, 11, 0)
        var lunchEnd = LocalDateTime.of(now.year, now.month, now.dayOfMonth, 14, 0)
        var lunchTime = now.isAfter(lunchStart) && now.isBefore(lunchEnd)

        return gourmetSearchApi.find(deviceLocation, lunchTime).results.shop
            .map {
                Restaurant(
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