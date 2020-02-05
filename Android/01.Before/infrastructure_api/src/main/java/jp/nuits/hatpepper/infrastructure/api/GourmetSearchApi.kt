package jp.nuits.hatpepper.infrastructure.api

import android.location.Location

interface GourmetSearchApi {
    suspend fun find(location: Location, lunchTimeOnly : Boolean) : GourmetSearchResults
}