
package jp.nuits.hatpepper.entities;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Genre {

    @SerializedName("name")
    @Expose
    private String name;
    @SerializedName("catch")
    @Expose
    private String _catch;
    @SerializedName("code")
    @Expose
    private String code;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCatch() {
        return _catch;
    }

    public void setCatch(String _catch) {
        this._catch = _catch;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

}
