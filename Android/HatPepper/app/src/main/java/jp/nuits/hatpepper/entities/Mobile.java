
package jp.nuits.hatpepper.entities;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Mobile {

    @SerializedName("l")
    @Expose
    private String l;
    @SerializedName("s")
    @Expose
    private String s;

    public String getL() {
        return l;
    }

    public void setL(String l) {
        this.l = l;
    }

    public String getS() {
        return s;
    }

    public void setS(String s) {
        this.s = s;
    }

}
