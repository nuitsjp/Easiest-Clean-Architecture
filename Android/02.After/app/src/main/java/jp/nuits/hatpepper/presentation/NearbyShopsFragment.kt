package jp.nuits.hatpepper.presentation

import android.Manifest
import android.content.pm.PackageManager
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.content.ContextCompat
import androidx.databinding.DataBindingUtil
import androidx.fragment.app.Fragment
import androidx.lifecycle.Observer
import jp.nuits.hatpepper.R
import jp.nuits.hatpepper.databinding.NearbyRestaurantsFragmentBinding
import org.koin.androidx.viewmodel.ext.android.viewModel

class NearbyShopsFragment : Fragment() {

    private val REQUEST_CODE = 1000

    private val nearbyShopsViewModel: NearbyShopsViewModel by viewModel()
    private val restaurantAdapter = RestaurantAdapter()
    private lateinit var binding: NearbyRestaurantsFragmentBinding

    companion object {
        fun newInstance() = NearbyShopsFragment()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = DataBindingUtil.inflate(inflater, R.layout.nearby_restaurants_fragment, container, false)
        binding.apply {
            restaurants.adapter = restaurantAdapter
        }

        return binding.root
    }

    override fun onActivityCreated(savedInstanceState: Bundle?) {
        super.onActivityCreated(savedInstanceState)

        observeViewModel(nearbyShopsViewModel)

        if(hasFineLocationPermission()) {
            findShops()
        } else {
            requestPermissions(arrayOf(Manifest.permission.ACCESS_FINE_LOCATION), REQUEST_CODE)
        }
    }

    //observe開始
    private fun observeViewModel(viewModel: NearbyShopsViewModel) {
        viewModel.shops.observe(viewLifecycleOwner, Observer { projects ->
            if (projects != null) {
                restaurantAdapter.setShops(projects)
            }
        })
    }


    private fun hasFineLocationPermission() : Boolean {
        return ContextCompat.checkSelfPermission(requireContext(), Manifest.permission.ACCESS_FINE_LOCATION) == PackageManager.PERMISSION_GRANTED
    }

    override fun onRequestPermissionsResult(requestCode: Int, permissions: Array<out String>, grantResults: IntArray) {
        if(requestCode == REQUEST_CODE) {
            if (grantResults.size > 0 && grantResults[0] == PackageManager.PERMISSION_GRANTED) {
                findShops()
            } else {
                throw RuntimeException()
            }
        }
    }

    private fun findShops() {
        nearbyShopsViewModel.findShops()
    }
}
