package jp.nuits.hatpepper.usecase.impl

import jp.nuits.hatpepper.usecase.FindNearbyShops
import jp.nuits.hatpepper.usecase.Shop
import org.threeten.bp.LocalDateTime

class FindNearbyShopsImpl(
    val deviceLocationProvider: DeviceLocationProvider,
    val timeProvider: TimeProvider,
    val gourmetSearchApi: GourmetSearchApi
) : FindNearbyShops {
    override suspend fun find(): List<Shop> {
        // 現在地を取得する
        var deviceLocation = deviceLocationProvider.getDeviceLocation()

        // 現在時刻が11時～14時の間で有った場合、ランチ営業している店舗のみを表示する
        var now = timeProvider.now()
        var lunchStart = LocalDateTime.of(now.year, now.month, now.dayOfMonth, 11, 0)
        var lunchEnd = LocalDateTime.of(now.year, now.month, now.dayOfMonth, 14, 0)
        var lunchTime = now.isAfter(lunchStart) && now.isBefore(lunchEnd)

        return gourmetSearchApi.find(deviceLocation, lunchTime)
    }
}