package jp.nuits.hatpepper.infrastructure.location

import android.location.Location

interface DeviceLocationProvider {
    suspend fun getDeviceLocation() : Location
}