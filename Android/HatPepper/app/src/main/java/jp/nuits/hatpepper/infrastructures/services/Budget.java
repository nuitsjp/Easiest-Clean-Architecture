
package jp.nuits.hatpepper.infrastructures.services;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Budget {

    @SerializedName("average")
    @Expose
    private String average;
    @SerializedName("name")
    @Expose
    private String name;
    @SerializedName("code")
    @Expose
    private String code;

    public String getAverage() {
        return average;
    }

    public void setAverage(String average) {
        this.average = average;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

}
