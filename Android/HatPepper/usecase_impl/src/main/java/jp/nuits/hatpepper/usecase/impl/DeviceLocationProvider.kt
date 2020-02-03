package jp.nuits.hatpepper.usecase.impl

interface DeviceLocationProvider {
    suspend fun getDeviceLocation() : DeviceLocation
}