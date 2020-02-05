package jp.nuits.hatpepper.infrastructure.api

data class Results(
    val api_version: String,
    val results_available: Int,
    val results_returned: String,
    val results_start: Int,
    val shop: List<Shop>
)