package jp.nuits.hatpepper.presentation

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import jp.nuits.hatpepper.usecase.FindNearbyShops
import jp.nuits.hatpepper.usecase.Shop
import kotlinx.coroutines.launch

class NearbyShopsViewModel(
    val findNearbyShops: FindNearbyShops
) : ViewModel() {

    var shops: MutableLiveData<List<Shop>> = MutableLiveData()

    fun findShops() {
        viewModelScope.launch {
            shops.postValue(findNearbyShops.find())
        }
    }
}
