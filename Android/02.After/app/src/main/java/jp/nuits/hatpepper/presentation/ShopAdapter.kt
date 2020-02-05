package jp.nuits.hatpepper.presentation

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.databinding.DataBindingUtil
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.RecyclerView
import jp.nuits.hatpepper.R
import jp.nuits.hatpepper.databinding.ShopBinding
import jp.nuits.hatpepper.usecase.Shop

class ShopAdapter :
    RecyclerView.Adapter<ShopAdapter.ShopViewHolder>() {

    private var shops: List<Shop>? = null

    fun setShops(shops: List<Shop>) {
        // 再更新は今回は考慮しない
        if (this.shops == null) {
            this.shops = shops
            notifyItemRangeInserted(0, shops.size)
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewtype: Int): ShopViewHolder {
        val binding =
            DataBindingUtil.inflate(LayoutInflater.from(parent.context), R.layout.shop, parent, false) as ShopBinding
        return ShopViewHolder(binding)
    }

    override fun onBindViewHolder(holder: ShopViewHolder, position: Int) {
        holder.binding.shop = shops?.get(position)
        holder.binding.executePendingBindings()
    }

    override fun getItemCount(): Int {
        return shops?.size ?: 0
    }

    open class ShopViewHolder(val binding: ShopBinding) : RecyclerView.ViewHolder(binding.root)
}
