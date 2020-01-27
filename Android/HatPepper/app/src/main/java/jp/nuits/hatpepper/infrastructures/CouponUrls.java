
package jp.nuits.hatpepper.infrastructures;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class CouponUrls {

    @SerializedName("sp")
    @Expose
    private String sp;
    @SerializedName("pc")
    @Expose
    private String pc;

    public String getSp() {
        return sp;
    }

    public void setSp(String sp) {
        this.sp = sp;
    }

    public String getPc() {
        return pc;
    }

    public void setPc(String pc) {
        this.pc = pc;
    }

}
