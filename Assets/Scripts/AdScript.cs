using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class AdScript : MonoBehaviour
{
    public static AdScript instance;
    private InterstitialAd fullscreenAd;
    private BannerView bannerView;

    private string appId = "ca-app-pub-8619775594640666~4612949732";
    private string bannerId = "ca-app-pub-3940256099942544/6300978111";
    private string fullscreenId = "ca-app-pub-3940256099942544/1033173712";
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
   

    private void Start()
    {
        MobileAds.Initialize(appId);
        RequestFullScreenAd();
    }

    public void RequestBanner()
    {
        bannerView = new BannerView(bannerId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
        bannerView.Show();

    }

    public void HideBanner()
    {
        bannerView.Hide();
    }

    public void RequestFullScreenAd()
    {
        fullscreenAd = new InterstitialAd(fullscreenId);
        AdRequest request = new AdRequest.Builder().Build();
        fullscreenAd.LoadAd(request);

    }

    public void ShowFullscreenAd()
    {
        if (fullscreenAd.IsLoaded())
        {
            fullscreenAd.Show();
            RequestFullScreenAd();
        }
        else
        {
            Debug.Log("Not loaded");
            RequestFullScreenAd();
        }
    }


}
