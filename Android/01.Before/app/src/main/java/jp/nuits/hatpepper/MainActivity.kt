package jp.nuits.hatpepper

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import jp.nuits.hatpepper.presentation.NearbyRestaurantsFragment


class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.main_activity)
        if (savedInstanceState == null) {
            supportFragmentManager.beginTransaction()
                .replace(R.id.container, NearbyRestaurantsFragment.newInstance())
                .commitNow()
        }
    }
}
