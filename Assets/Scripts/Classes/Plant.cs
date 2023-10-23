using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    //Properties
    [SerializeField] private int health;
    [SerializeField] private int water;
    [SerializeField] private int soil;
    [SerializeField] private int sunLight;
    [SerializeField] private int bugs;

    public int Health { get => health; set => health = value; }
    public int Water { get => water; set => water = value; }
    public int Soil { get => soil; set => soil = value; }
    public int SunLight { get => sunLight; set => sunLight = value; }
    public int Bugs { get => bugs; set => bugs = value; }
}
