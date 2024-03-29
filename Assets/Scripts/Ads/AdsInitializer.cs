using UnityEngine;
using UnityEngine.Advertisements;

namespace Ads
{
    public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
    {

        [SerializeField] string androidGameID = "4488585";
        [SerializeField] string iOSGameID = "4488584";
        [SerializeField] bool testMode = false;
        private string gameID;

        void Awake()
        {
            InitializeAds();
        }
        public void InitializeAds()
        {
            gameID = (Application.platform == RuntimePlatform.IPhonePlayer) ? iOSGameID : androidGameID;
            Advertisement.Initialize(gameID, testMode, this);
        }

        public void OnInitializationComplete()
        {
            //Debug.Log("Unity Ads initialization complete.");
        }

        public void OnInitializationFailed(UnityAdsInitializationError error, string message)
        {
            //Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
        }
    }
}