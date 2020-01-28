
package jp.nuits.hatpepper.infrastructures.services;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Photo {

    @SerializedName("pc")
    @Expose
    private Pc pc;
    @SerializedName("mobile")
    @Expose
    private Mobile mobile;

    public Pc getPc() {
        return pc;
    }

    public void setPc(Pc pc) {
        this.pc = pc;
    }

    public Mobile getMobile() {
        return mobile;
    }

    public void setMobile(Mobile mobile) {
        this.mobile = mobile;
    }

}
