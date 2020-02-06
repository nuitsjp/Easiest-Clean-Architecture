package jp.nuits.hatpepper.usecase

/**
 * ユースケース「最寄りの店舗を探す」
 */
interface FindNearbyRestaurants {
    /**
     * 店舗を探す
     */
    suspend fun find() : List<Restaurant>
}