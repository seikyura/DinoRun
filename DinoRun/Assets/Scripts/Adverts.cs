using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Adverts : MonoBehaviour, IUnityAdsListener
{
    string gameId = "3262901";

    private string video_ad = "video";
    private string rewarded_video_ad = "rewardedVideo";
    private string banner_ad = "bannerAd";

    bool testMode = true;
    public static Adverts s_Instance = null;

    void Start()
    {
        s_Instance = this;
        //Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);
    }

    //void Update()
    //{
    //if (Input.GetKeyDown(KeyCode.E))
    //{
    //    OnUnityAdsReady(video_ad);
    //}
    //if (Input.GetKeyDown(KeyCode.R))
    //{
    //    OnUnityAdsReady(rewarded_video_ad);
    //}
    //if (Input.GetKeyDown(KeyCode.T))
    //{
    //    OnUnityAdsReady(banner_ad);
    //}

    // Undo the purchasing of removing ads // REMOVE BEFORE SUBMISSION
    //if (Input.GetKeyDown(KeyCode.P)) {
    //    PlayerPrefs.SetInt("NoAds", 0);
    //}
    //}

    public void SkippableVideoAd()
    {
        if (PlayerPrefs.GetInt("NoAds", 0) == 1)
        {
            Debug.Log("No ads for you!");
            return;
        }
        OnUnityAdsReady(video_ad);
    }
    public void RewardedVideoAd()
    {
        OnUnityAdsReady(rewarded_video_ad);
    }
    public void BannerAd()
    {
        OnUnityAdsReady(banner_ad);
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.
            print("Played");
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
            print("Skipped");
            GameManager.s_bIsRunning = true;
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
    public void OnUnityAdsReady(string placementId)
    {
        if (placementId == video_ad)
        {
            Advertisement.Show(video_ad);
        }
        else if (placementId == rewarded_video_ad)
        {
            Advertisement.Show(rewarded_video_ad);
        }
        else if (placementId == banner_ad)
        {
            Advertisement.Banner.Show(banner_ad);
        }
    }
    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }
    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
}
