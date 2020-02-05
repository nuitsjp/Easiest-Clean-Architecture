package jp.nuits.hatpepper.infrastructure.location

import android.content.Context
import android.location.Location
import com.google.android.gms.location.LocationServices
import com.google.android.gms.tasks.Task
import kotlinx.coroutines.CancellationException
import kotlin.coroutines.resume
import kotlin.coroutines.resumeWithException
import kotlin.coroutines.suspendCoroutine

public class DeviceLocationProviderImpl(context: Context) :
    DeviceLocationProvider {

    private val fusedLocationProviderClient = LocationServices.getFusedLocationProviderClient(context)

    override suspend fun getDeviceLocation(): Location {
        return fusedLocationProviderClient.lastLocation.toSuspendable()
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