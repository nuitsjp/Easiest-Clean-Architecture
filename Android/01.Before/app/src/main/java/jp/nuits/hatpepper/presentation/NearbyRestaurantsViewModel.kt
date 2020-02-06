package jp.nuits.hatpepper.presentation

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import jp.nuits.hatpepper.usecase.FindNearbyRestaurants
import jp.nuits.hatpepper.usecase.Restaurant
import kotlinx.coroutines.launch

class NearbyRestaurantsViewModel(
    val findNearbyRestaurants: FindNearbyRestaurants
) : ViewModel() {

    var shops: MutableLiveData<List<Restaurant>> = MutableLiveData()

    fun findShops() {
        viewModelScope.launch {
            shops.postValue(findNearbyRestaurants.find())
        }
    }
}
