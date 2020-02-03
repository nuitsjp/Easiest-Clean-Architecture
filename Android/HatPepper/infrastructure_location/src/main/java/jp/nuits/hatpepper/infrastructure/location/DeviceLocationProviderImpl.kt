package jp.nuits.hatpepper.infrastructure.location

import android.content.Context
import com.google.android.gms.location.LocationServices
import com.google.android.gms.tasks.Task
import jp.nuits.hatpepper.usecase.impl.DeviceLocation
import jp.nuits.hatpepper.usecase.impl.DeviceLocationProvider
import kotlinx.coroutines.CancellationException
import kotlin.coroutines.resume
import kotlin.coroutines.resumeWithException
import kotlin.coroutines.suspendCoroutine

public class DeviceLocationProviderImpl(context: Context) :
    DeviceLocationProvider {

    private val fusedLocationProviderClient = LocationServices.getFusedLocationProviderClient(context)

    override suspend fun getDeviceLocation(): DeviceLocation {
        var location = fusedLocationProviderClient.lastLocation.toSuspendable()
        return DeviceLocation(
            location.latitude,
            location.longitude
        )
    }

    suspend fun <T> Task<T>.toSuspendable(): T {
        return suspendCoroutine { cont ->
            this.addOnCompleteListener { task ->
                if (task.isSuccessful) {
                    cont.resume(task.result as T)
                } else if (task.isCanceled) {
                    cont.resumeWithException(CancellationException())
                } else {
                    cont.resumeWithException(task.exception ?: Exception("Unknown"))
                }
            }
        }
    }
}