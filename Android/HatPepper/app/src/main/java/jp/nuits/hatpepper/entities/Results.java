
package jp.nuits.hatpepper.entities;

import java.util.List;
import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Results {

    @SerializedName("api_version")
    @Expose
    private String apiVersion;
    @SerializedName("results_returned")
    @Expose
    private String resultsReturned;
    @SerializedName("results_start")
    @Expose
    private Integer resultsStart;
    @SerializedName("shop")
    @Expose
    private List<Shop> shop = null;
    @SerializedName("results_available")
    @Expose
    private Integer resultsAvailable;

    public String getApiVersion() {
        return apiVersion;
    }

    public void setApiVersion(String apiVersion) {
        this.apiVersion = apiVersion;
    }

    public String getResultsReturned() {
        return resultsReturned;
    }

    public void setResultsReturned(String resultsReturned) {
        this.resultsReturned = resultsReturned;
    }

    public Integer getResultsStart() {
        return resultsStart;
    }

    public void setResultsStart(Integer resultsStart) {
        this.resultsStart = resultsStart;
    }

    public List<Shop> getShop() {
        return shop;
    }

    public void setShop(List<Shop> shop) {
        this.shop = shop;
    }

    public Integer getResultsAvailable() {
        return resultsAvailable;
    }

    public void setResultsAvailable(Integer resultsAvailable) {
        this.resultsAvailable = resultsAvailable;
    }

}
