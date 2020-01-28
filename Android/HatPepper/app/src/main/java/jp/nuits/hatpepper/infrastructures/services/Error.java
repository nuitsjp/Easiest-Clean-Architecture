package jp.nuits.hatpepper.infrastructures.services;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Error {
    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    @SerializedName("message")
    @Expose
    private String message;
    @SerializedName("code")
    @Expose
    private String code;
}
