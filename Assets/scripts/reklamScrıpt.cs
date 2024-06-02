using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;
public class reklamScrıpt : MonoBehaviour
{
    private BannerView bannerView;
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
    }
    void RequestBanner()
    {
        string reklamID = "ca-app-pub-4996140830834832/8618713936";

        this.bannerView = new BannerView(reklamID, AdSize.Banner,AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);
    }
}
