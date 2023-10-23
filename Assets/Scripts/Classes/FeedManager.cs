using UnityEngine;
using UnityEngine.UI;

public class FeedManager : MonoBehaviour
{
    [SerializeField] private PlantManager plantObject;
    [SerializeField] private int feedWater;
    [SerializeField] private int feedSoil;
    [SerializeField] private int feedSunLight;
    [Header("SunLight Manager")]
    [SerializeField] private Image sunLightBtn;
    [SerializeField] private Sprite[] sunLightSprites;
    [SerializeField] private GameObject sunRays;
    private bool sunLightIsActive = false;

    public void FeedWater()
    {
        if (plantObject.MaxWater - plantObject.Water < feedWater)
        {
            plantObject.Water += plantObject.MaxWater - plantObject.Water;
        }
        else
        {
            plantObject.Water += feedWater;
        }
    }

    public void FeedSoil()
    {
        if (plantObject.MaxSoil - plantObject.Soil < feedSoil)
        {
            plantObject.Soil += plantObject.MaxSoil - plantObject.Soil;
        }
        else
        {
            plantObject.Soil += feedSoil;
        }
    }

    public void FeedSunLight()
    {
        if (sunLightIsActive)
        {
            sunLightIsActive = false;
            sunLightBtn.sprite = sunLightSprites[0];
            sunRays.SetActive(false);
        }
        else
        {
            sunLightIsActive = true;
            sunLightBtn.sprite = sunLightSprites[1];
            sunRays.SetActive(true);
            if (plantObject.MaxSunLight - plantObject.SunLight < feedSunLight)
            {
                plantObject.SunLight += plantObject.MaxSunLight - plantObject.SunLight;
            }
            else
            {
                plantObject.SunLight += feedSunLight;
            }
        }
    }
}
