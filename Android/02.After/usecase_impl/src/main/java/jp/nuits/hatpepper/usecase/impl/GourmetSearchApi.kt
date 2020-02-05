package jp.nuits.hatpepper.usecase.impl

import jp.nuits.hatpepper.usecase.Shop

interface GourmetSearchApi {
    suspend fun find(location: DeviceLocation, lunchTimeOnly : Boolean) : List<Shop>
}