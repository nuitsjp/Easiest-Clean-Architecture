
package jp.nuits.hatpepper.infrastructures;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Shop {

    @SerializedName("name_kana")
    @Expose
    private String nameKana;
    @SerializedName("other_memo")
    @Expose
    private String otherMemo;
    @SerializedName("photo")
    @Expose
    private Photo photo;
    @SerializedName("large_area")
    @Expose
    private LargeArea largeArea;
    @SerializedName("party_capacity")
    @Expose
    private String partyCapacity;
    @SerializedName("large_service_area")
    @Expose
    private LargeServiceArea largeServiceArea;
    @SerializedName("address")
    @Expose
    private String address;
    @SerializedName("mobile_access")
    @Expose
    private String mobileAccess;
    @SerializedName("id")
    @Expose
    private String id;
    @SerializedName("lng")
    @Expose
    private String lng;
    @SerializedName("course")
    @Expose
    private String course;
    @SerializedName("show")
    @Expose
    private String show;
    @SerializedName("parking")
    @Expose
    private String parking;
    @SerializedName("non_smoking")
    @Expose
    private String nonSmoking;
    @SerializedName("horigotatsu")
    @Expose
    private String horigotatsu;
    @SerializedName("name")
    @Expose
    private String name;
    @SerializedName("genre")
    @Expose
    private Genre genre;
    @SerializedName("open")
    @Expose
    private String open;
    @SerializedName("tatami")
    @Expose
    private String tatami;
    @SerializedName("card")
    @Expose
    private String card;
    @SerializedName("charter")
    @Expose
    private String charter;
    @SerializedName("wifi")
    @Expose
    private String wifi;
    @SerializedName("sub_genre")
    @Expose
    private SubGenre subGenre;
    @SerializedName("shop_detail_memo")
    @Expose
    private String shopDetailMemo;
    @SerializedName("band")
    @Expose
    private String band;
    @SerializedName("middle_area")
    @Expose
    private MiddleArea middleArea;
    @SerializedName("lat")
    @Expose
    private String lat;
    @SerializedName("karaoke")
    @Expose
    private String karaoke;
    @SerializedName("logo_image")
    @Expose
    private String logoImage;
    @SerializedName("midnight")
    @Expose
    private String midnight;
    @SerializedName("budget")
    @Expose
    private Budget budget;
    @SerializedName("urls")
    @Expose
    private Urls urls;
    @SerializedName("lunch")
    @Expose
    private String lunch;
    @SerializedName("english")
    @Expose
    private String english;
    @SerializedName("close")
    @Expose
    private String close;
    @SerializedName("service_area")
    @Expose
    private ServiceArea serviceArea;
    @SerializedName("budget_memo")
    @Expose
    private String budgetMemo;
    @SerializedName("tv")
    @Expose
    private String tv;
    @SerializedName("private_room")
    @Expose
    private String privateRoom;
    @SerializedName("coupon_urls")
    @Expose
    private CouponUrls couponUrls;
    @SerializedName("small_area")
    @Expose
    private SmallArea smallArea;
    @SerializedName("barrier_free")
    @Expose
    private String barrierFree;
    @SerializedName("wedding")
    @Expose
    private String wedding;
    @SerializedName("access")
    @Expose
    private String access;
    @SerializedName("child")
    @Expose
    private String child;
    @SerializedName("capacity")
    @Expose
    private String capacity;
    @SerializedName("pet")
    @Expose
    private String pet;
    @SerializedName("free_food")
    @Expose
    private String freeFood;
    @SerializedName("ktai_coupon")
    @Expose
    private String ktaiCoupon;
    @SerializedName("station_name")
    @Expose
    private String stationName;
    @SerializedName("catch")
    @Expose
    private String _catch;
    @SerializedName("free_drink")
    @Expose
    private String freeDrink;

    public String getNameKana() {
        return nameKana;
    }

    public void setNameKana(String nameKana) {
        this.nameKana = nameKana;
    }

    public String getOtherMemo() {
        return otherMemo;
    }

    public void setOtherMemo(String otherMemo) {
        this.otherMemo = otherMemo;
    }

    public Photo getPhoto() {
        return photo;
    }

    public void setPhoto(Photo photo) {
        this.photo = photo;
    }

    public LargeArea getLargeArea() {
        return largeArea;
    }

    public void setLargeArea(LargeArea largeArea) {
        this.largeArea = largeArea;
    }

    public String getPartyCapacity() {
        return partyCapacity;
    }

    public void setPartyCapacity(String partyCapacity) {
        this.partyCapacity = partyCapacity;
    }

    public LargeServiceArea getLargeServiceArea() {
        return largeServiceArea;
    }

    public void setLargeServiceArea(LargeServiceArea largeServiceArea) {
        this.largeServiceArea = largeServiceArea;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getMobileAccess() {
        return mobileAccess;
    }

    public void setMobileAccess(String mobileAccess) {
        this.mobileAccess = mobileAccess;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getLng() {
        return lng;
    }

    public void setLng(String lng) {
        this.lng = lng;
    }

    public String getCourse() {
        return course;
    }

    public void setCourse(String course) {
        this.course = course;
    }

    public String getShow() {
        return show;
    }

    public void setShow(String show) {
        this.show = show;
    }

    public String getParking() {
        return parking;
    }

    public void setParking(String parking) {
        this.parking = parking;
    }

    public String getNonSmoking() {
        return nonSmoking;
    }

    public void setNonSmoking(String nonSmoking) {
        this.nonSmoking = nonSmoking;
    }

    public String getHorigotatsu() {
        return horigotatsu;
    }

    public void setHorigotatsu(String horigotatsu) {
        this.horigotatsu = horigotatsu;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Genre getGenre() {
        return genre;
    }

    public void setGenre(Genre genre) {
        this.genre = genre;
    }

    public String getOpen() {
        return open;
    }

    public void setOpen(String open) {
        this.open = open;
    }

    public String getTatami() {
        return tatami;
    }

    public void setTatami(String tatami) {
        this.tatami = tatami;
    }

    public String getCard() {
        return card;
    }

    public void setCard(String card) {
        this.card = card;
    }

    public String getCharter() {
        return charter;
    }

    public void setCharter(String charter) {
        this.charter = charter;
    }

    public String getWifi() {
        return wifi;
    }

    public void setWifi(String wifi) {
        this.wifi = wifi;
    }

    public SubGenre getSubGenre() {
        return subGenre;
    }

    public void setSubGenre(SubGenre subGenre) {
        this.subGenre = subGenre;
    }

    public String getShopDetailMemo() {
        return shopDetailMemo;
    }

    public void setShopDetailMemo(String shopDetailMemo) {
        this.shopDetailMemo = shopDetailMemo;
    }

    public String getBand() {
        return band;
    }

    public void setBand(String band) {
        this.band = band;
    }

    public MiddleArea getMiddleArea() {
        return middleArea;
    }

    public void setMiddleArea(MiddleArea middleArea) {
        this.middleArea = middleArea;
    }

    public String getLat() {
        return lat;
    }

    public void setLat(String lat) {
        this.lat = lat;
    }

    public String getKaraoke() {
        return karaoke;
    }

    public void setKaraoke(String karaoke) {
        this.karaoke = karaoke;
    }

    public String getLogoImage() {
        return logoImage;
    }

    public void setLogoImage(String logoImage) {
        this.logoImage = logoImage;
    }

    public String getMidnight() {
        return midnight;
    }

    public void setMidnight(String midnight) {
        this.midnight = midnight;
    }

    public Budget getBudget() {
        return budget;
    }

    public void setBudget(Budget budget) {
        this.budget = budget;
    }

    public Urls getUrls() {
        return urls;
    }

    public void setUrls(Urls urls) {
        this.urls = urls;
    }

    public String getLunch() {
        return lunch;
    }

    public void setLunch(String lunch) {
        this.lunch = lunch;
    }

    public String getEnglish() {
        return english;
    }

    public void setEnglish(String english) {
        this.english = english;
    }

    public String getClose() {
        return close;
    }

    public void setClose(String close) {
        this.close = close;
    }

    public ServiceArea getServiceArea() {
        return serviceArea;
    }

    public void setServiceArea(ServiceArea serviceArea) {
        this.serviceArea = serviceArea;
    }

    public String getBudgetMemo() {
        return budgetMemo;
    }

    public void setBudgetMemo(String budgetMemo) {
        this.budgetMemo = budgetMemo;
    }

    public String getTv() {
        return tv;
    }

    public void setTv(String tv) {
        this.tv = tv;
    }

    public String getPrivateRoom() {
        return privateRoom;
    }

    public void setPrivateRoom(String privateRoom) {
        this.privateRoom = privateRoom;
    }

    public CouponUrls getCouponUrls() {
        return couponUrls;
    }

    public void setCouponUrls(CouponUrls couponUrls) {
        this.couponUrls = couponUrls;
    }

    public SmallArea getSmallArea() {
        return smallArea;
    }

    public void setSmallArea(SmallArea smallArea) {
        this.smallArea = smallArea;
    }

    public String getBarrierFree() {
        return barrierFree;
    }

    public void setBarrierFree(String barrierFree) {
        this.barrierFree = barrierFree;
    }

    public String getWedding() {
        return wedding;
    }

    public void setWedding(String wedding) {
        this.wedding = wedding;
    }

    public String getAccess() {
        return access;
    }

    public void setAccess(String access) {
        this.access = access;
    }

    public String getChild() {
        return child;
    }

    public void setChild(String child) {
        this.child = child;
    }

    public String getCapacity() {
        return capacity;
    }

    public void setCapacity(String capacity) {
        this.capacity = capacity;
    }

    public String getPet() {
        return pet;
    }

    public void setPet(String pet) {
        this.pet = pet;
    }

    public String getFreeFood() {
        return freeFood;
    }

    public void setFreeFood(String freeFood) {
        this.freeFood = freeFood;
    }

    public String getKtaiCoupon() {
        return ktaiCoupon;
    }

    public void setKtaiCoupon(String ktaiCoupon) {
        this.ktaiCoupon = ktaiCoupon;
    }

    public String getStationName() {
        return stationName;
    }

    public void setStationName(String stationName) {
        this.stationName = stationName;
    }

    public String getCatch() {
        return _catch;
    }

    public void setCatch(String _catch) {
        this._catch = _catch;
    }

    public String getFreeDrink() {
        return freeDrink;
    }

    public void setFreeDrink(String freeDrink) {
        this.freeDrink = freeDrink;
    }

}
