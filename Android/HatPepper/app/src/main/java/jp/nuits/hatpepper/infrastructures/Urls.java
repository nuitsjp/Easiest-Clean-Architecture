
package jp.nuits.hatpepper.infrastructures;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Urls {

    @SerializedName("pc")
    @Expose
    private String pc;

    public String getPc() {
        return pc;
    }

    public void setPc(String pc) {
        this.pc = pc;
    }

}
