package jp.nuits.hatpepper.usecase

/**
 * 店舗
 * @property id ID
 * @property name 名称
 */
class Shop(
    val id : String,
    val name : String,
    val genre : String,
    val genreCatch : String,
    val photoUrl : String,
    val budget : String,
    val access : String) {
}