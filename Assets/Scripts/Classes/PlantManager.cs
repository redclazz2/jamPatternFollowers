using UnityEngine;

public class PlantManager : MonoBehaviour
{
    //Properties
    [Header("Estadísticas")]
    [SerializeField] private double health;
    [SerializeField] private int water;
    [SerializeField] private int maxWater;
    [SerializeField] private int soil;
    [SerializeField] private int maxSoil;
    [SerializeField] private int sunLight;
    [SerializeField] private int maxSunLight;
    [SerializeField] private int bugs;
    [SerializeField] private int maxBugs;
    [Header("Randomizer para reducir estadísticas")]
    [SerializeField] private float reduceStatsTimer;
    [SerializeField] private int rndReduceWater;
    [SerializeField] private int rndReduceSoil;
    [SerializeField] private int rndReduceSunLight;
    [Header("Estados de la planta")]
    private GameObject plantObject;
    public GameObject[] plantStates;

    public double Health { get => health; }
    public int Water { get => water; set => water = value; }
    public int Soil { get => soil; set => soil = value; }
    public int SunLight { get => sunLight; set => sunLight = value; }
    public int Bugs { get => bugs; set => bugs = value; }

    private void Awake()
    {
        plantObject = plantStates[0];
        plantObject.SetActive(true);
        InvokeRepeating(nameof(ReduceStats), 0.0f, reduceStatsTimer);
    }

    //Métodos
    public void ReduceStats()
    {
        int reduceWater = Random.Range(1, rndReduceWater);
        int reduceSoil = Random.Range(1, rndReduceSoil);
        int reduceSunLight = Random.Range(1, rndReduceSunLight);
        if (water > 0)
        {
            water -= reduceWater > water ? water : reduceWater;
        }
        if (soil > 0)
        {
            soil -= reduceSoil > soil ? soil : reduceSoil;
        }
        if (sunLight > 0)
        {
            sunLight -= reduceSunLight > sunLight ? sunLight : reduceSunLight;
        }
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        this.health = ((this.water * 0.4 / this.maxWater)
                        + (this.soil * 0.3 / this.maxSoil)
                        + (this.sunLight * 0.3 / this.maxSunLight)
                        - (this.bugs * 0.05 / this.maxBugs)) * 100;

        if (health > 70 && !plantStates[0].activeSelf)
        {
            plantObject.SetActive(false);
            plantObject = plantStates[0];
            plantObject.SetActive(true);
        }
        else if (health < 70 && health > 40 && !plantStates[1].activeSelf)
        {
            plantObject.SetActive(false);
            plantObject = plantStates[1];
            plantObject.SetActive(true);
        }
        else if (health < 40 && !plantStates[2].activeSelf)
        {
            plantObject.SetActive(false);
            plantObject = plantStates[2];
            plantObject.SetActive(true);
        }
        else if (health == 0 && !plantStates[3].activeSelf)
        {
            plantObject.SetActive(false);
            plantObject = plantStates[3];
            plantObject.SetActive(true);
        }

        Debug.Log("Health: " + this.health);
    }
}
