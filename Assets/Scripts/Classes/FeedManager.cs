using UnityEngine;

public class FeedManager : MonoBehaviour
{
    [SerializeField] private PlantManager plantObject;
    [SerializeField] private int feedWater;
    [SerializeField] private int feedSoil;
    [SerializeField] private int feedSunLight;
    [Header("Sprites para botón dinámico")]
    [SerializeField] private Sprite[] sunLightSprites;
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
        plantObject.SunLight += feedSunLight;
    }
}
