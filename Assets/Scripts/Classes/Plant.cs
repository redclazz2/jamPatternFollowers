using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : GameComponent
{
	private double health;
	private double water;
	private double soil;
	private double sunlight;
	private int bugs;

	public double Health { get => health; set => health = value; }
	public double Water { get => water; set => water = value; }
	public double Soil { get => soil; set => soil = value; }
	public double Sunlight { get => sunlight; set => sunlight = value; }
	public int Bugs { get => bugs; set => bugs = value; }

	public Plant(MediatorInterface gameMediator) : base(gameMediator)
	{
		this.health = 100;
		this.water = 100;
		this.soil = 100;
		this.sunlight = 100;
		this.bugs = 0;

		Debug.Log("Plant Initialized");
	}

	#region Modifiers - Methods to substract from properties
	public void modifySubstractWater(double value){
		this.water -= value;
		this.debugPlantValue();
	}

	public void modifySubstractSoil(double value)
	{
		this.soil -= value;
	}
	
	public void modifySubstractSunlight(double value)
	{
		this.sunlight -= value;
	}

	public void modifySubstractBugs(int value)
	{
		this.bugs -= value;
	}
	#endregion

	#region Modifiers - Methods to Add to Properties
	public void modifyAddWater(double value)
	{
		this.water += value;
	}

	public void modifyAddSoil(double value)
	{
		this.soil += value;
	}

	public void modifyAddSunlight(double value)
	{
		this.sunlight += value;
	}

	public void modifyAddBugs(int value)
	{
		this.bugs += value;
	}
	#endregion

	public void debugPlantValue()
	{
		Debug.Log($"Water has been modified to: {this.water}");
		Debug.Log($"Soil has been modified to: {this.soil}");
		Debug.Log($"Sun Light has been modified to: {this.sunlight}");
		Debug.Log($"Bugs has been modified to: {this.bugs}");
		Debug.Log($"-------------------------------------");
	}
}
