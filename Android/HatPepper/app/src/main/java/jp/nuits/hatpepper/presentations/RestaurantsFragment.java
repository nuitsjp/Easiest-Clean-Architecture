package jp.nuits.hatpepper.presentations;

import androidx.lifecycle.ViewModelProviders;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import javax.inject.Inject;

import jp.nuits.hatpepper.HatPepperApplication;
import jp.nuits.hatpepper.R;

public class RestaurantsFragment extends Fragment {

    @Inject
    RestaurantsViewModel restaurantsViewModel;

    public static RestaurantsFragment newInstance() {
        return new RestaurantsFragment();
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container,
                             @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.main_fragment, container, false);
    }

    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        ((HatPepperApplication) getActivity().getApplicationContext()).getAppComponent().inject(this);
        super.onActivityCreated(savedInstanceState);
        // TODO: Use the ViewModel
    }

}
