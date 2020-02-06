package jp.nuits.hatpepper

import android.app.Application
import com.jakewharton.threetenabp.AndroidThreeTen
import jp.nuits.hatpepper.infrastructure.location.DeviceLocationProviderImpl
import jp.nuits.hatpepper.infrastructure.api.GourmetSearchApiImpl
import jp.nuits.hatpepper.infrastructure.time.TimeProviderImpl
import jp.nuits.hatpepper.presentation.NearbyShopsViewModel
import jp.nuits.hatpepper.usecase.FindNearbyRestaurants
import jp.nuits.hatpepper.usecase.impl.DeviceLocationProvider
import jp.nuits.hatpepper.usecase.impl.FindNearbyRestaurantsImpl
import jp.nuits.hatpepper.usecase.impl.GourmetSearchApi
import jp.nuits.hatpepper.usecase.impl.TimeProvider
import org.koin.android.ext.koin.androidContext
import org.koin.android.ext.koin.androidLogger
import org.koin.androidx.viewmodel.dsl.viewModel
import org.koin.core.context.startKoin
import org.koin.dsl.module

val appModule = module {
    // Infrastructure
    single<DeviceLocationProvider> { DeviceLocationProviderImpl(get()) }
    single<TimeProvider> { TimeProviderImpl() }
    single<GourmetSearchApi> { GourmetSearchApiImpl() }

    // UseCase
    single<FindNearbyRestaurants> { FindNearbyRestaurantsImpl(get(), get(), get()) }

    // ViewModel
    viewModel { NearbyShopsViewModel(get()) }
}

class HatPepperApplication : Application() {
    override fun onCreate() {
        super.onCreate()
        // LocalDateTimeを利用するためのバックポートライブラリを有効化する
        AndroidThreeTen.init(this);

        // DIコンテナを初期化する
        startKoin{
            androidLogger()
            androidContext(this@HatPepperApplication)
            modules(appModule)
        }
    }
}