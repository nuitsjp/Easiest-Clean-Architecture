
package jp.nuits.hatpepper.infrastructures.services;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class GourmetSearchResults {
    @SerializedName("results")
    @Expose
    private Results results;

    public Results getResults() {
        return results;
    }

    public void setResults(Results results) {
        this.results = results;
    }
}
