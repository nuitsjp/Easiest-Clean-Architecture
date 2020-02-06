package jp.nuits.hatpepper.presentation

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.databinding.DataBindingUtil
import androidx.recyclerview.widget.RecyclerView
import jp.nuits.hatpepper.R
import jp.nuits.hatpepper.databinding.RestaurantBinding
import jp.nuits.hatpepper.usecase.Restaurant

class RestaurantAdapter :
    RecyclerView.Adapter<RestaurantAdapter.ShopViewHolder>() {

    private var restaurant: List<Restaurant>? = null

    fun setShops(restaurant: List<Restaurant>) {
        // 再更新は今回は考慮しない
        if (this.restaurant == null) {
            this.restaurant = restaurant
            notifyItemRangeInserted(0, restaurant.size)
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewtype: Int): ShopViewHolder {
        val binding =
            DataBindingUtil.inflate(LayoutInflater.from(parent.context), R.layout.restaurant, parent, false) as RestaurantBinding
        return ShopViewHolder(binding)
    }

    override fun onBindViewHolder(holder: ShopViewHolder, position: Int) {
        holder.binding.shop = restaurant?.get(position)
        holder.binding.executePendingBindings()
    }

    override fun getItemCount(): Int {
        return restaurant?.size ?: 0
    }

    open class ShopViewHolder(val binding: RestaurantBinding) : RecyclerView.ViewHolder(binding.root)
}
