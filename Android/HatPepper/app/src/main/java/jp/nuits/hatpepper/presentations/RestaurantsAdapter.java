package jp.nuits.hatpepper.presentations;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import jp.nuits.hatpepper.R;
import jp.nuits.hatpepper.usecases.Restaurant;

public class RestaurantsAdapter extends ArrayAdapter<Restaurant> {
    public RestaurantsAdapter(@NonNull Context context) {
        super(context, R.layout.restaurant);
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        View view = convertView;
        if(view == null)
        {
            LayoutInflater inflater = LayoutInflater.from(getContext());
            view = inflater.inflate(R.layout.restaurant, parent, false);
        }

        Restaurant restaurant = getItem(position);
        TextView addressLine1 = view.findViewById(R.id.restaurant_name);
        addressLine1.setText(restaurant.getName());

        return view;
    }
}
