using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : GameComponent
{
    private double health;
	private double water;
	private double soil;
    private double sunlight;
    private int bugs;

	public int notifyPlantIconNeedMin = 90;
	public int notifyPlantIconNeedBugsMin = 5;

	public int resourceHealthMax = 100;
	public int resourceWaterMax = 100;
	public int resourceSoilMax = 100;
	public int resourceSunlightMax = 80;
	public int resourceBugsMax = 20;

	public double Health { get => health; set => health = value; }
	public double Water { get => water; set => water = value; }
	public double Soil { get => soil; set => soil = value; }
	public double Sunlight { get => sunlight; set => sunlight = value; }
	public int Bugs { get => bugs; set => bugs = value; }

	public Plant(MediatorInterface gameMediator) : base(gameMediator)
	{
		this.health = this.resourceHealthMax;
		this.water = this.resourceWaterMax;
		this.soil = this.resourceSoilMax;
		this.sunlight = this.resourceSunlightMax;
		this.bugs = 0;

		Debug.Log("Plant Initialized");
	}

	#region Modifiers - Methods to substract from properties
	public void modifySubstractWater(double value){
		this.water -= value;
		this.notifyWaterStatus();
		//this.debugPlantValue(); //TODO:: Quitar esto cuando no se necesite hacer debug
	}

	public void modifySubstractSoil(double value)
	{
		this.soil -= value;
		this.notifySoilStatus();
	}
	
	public void modifySubstractSunlight(double value)
	{
		this.sunlight -= value;
		this.notifySunLightStatus();
	}

	public void modifySubstractBugs(int value)
	{
		this.bugs -= value;
		//TODO NOTIFY BUG STATUS
	}

	public void modifyPlantHealth()
	{
		//Health is calculated based on: Water (40%) Soil (30%) SunLight (25%) and Bugs (5%)
		this.health = (((this.water * 0.4) / this.resourceWaterMax ) 
					+ ((this.soil * 0.3) / this.resourceSoilMax) 
					+ ((this.sunlight * 0.25)/this.resourceSunlightMax)
					- ((this.bugs * 0.05)/this.resourceBugsMax)) * 100;

		string myNotificationMessage = "";

		//Perdón x el chorizo
		if (this.health > 70) myNotificationMessage = "PlantHealthOk";
		else if (this.health <= 69 && this.health > 40) myNotificationMessage = "PlantHealthMeh";
		else if (this.health < 40) myNotificationMessage = "PlantHealthCritical";
		else if (this.health <= 0) myNotificationMessage = "PlantHealthGameOver";


		this.gameMediator.notify(this,myNotificationMessage);

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

	#region Notifiers - Methods to communicate to Mediator
	
	public void notifyWaterStatus()
	{
		string _event = this.water <= this.notifyPlantIconNeedMin ? "WaterLow" : "WaterOk";
		this.gameMediator.notify(this, _event);
	}

	public void notifySoilStatus()
	{
		string _event = this.soil <= this.notifyPlantIconNeedMin ? "SoilLow" : "SoilOk";
		this.gameMediator.notify(this, _event);
	}

	public void notifySunLightStatus()
	{
		string _event = this.water <= this.notifyPlantIconNeedMin ? "SunLightLow" : "SunLightOk";
		this.gameMediator.notify(this, _event);
	}

	public void notifyBugStatus()
	{
		string _event = this.bugs >= this.notifyPlantIconNeedBugsMin ? "BugsIn" : "BugsOut";
		this.gameMediator.notify(this, _event);
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
