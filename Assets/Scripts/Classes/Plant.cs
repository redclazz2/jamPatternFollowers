using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : GameComponent
{
	private GameDialog gameDialogInstance;
    private double health;
	private double water;
	private double soil;
    private double sunlight;
    private int bugs;
	public int notifyPlantIconNeedMin = 90;
	public int notifyPlantIconNeedBugsMin = 5;

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
		//Obtener referencia del Mediador
		gameDialogInstance = FindObjectOfType<GameDialog>();
		gameMediator = gameDialogInstance.GetComponent<MediatorInterface>();
		Debug.Log("Plant Initialized");
	}

	#region Modifiers - Methods to substract from properties
	public void modifySubstractWater(double value){
		this.water -= value;
		this.notifyWaterStatus();
		this.debugPlantValue(); //TODO:: Quitar esto cuando no se necesite hacer debug
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

	#region Status Checkers - Methods to communicate to Mediator
	
	public void notifyWaterStatus()
	{
		string _event = this.water < this.notifyPlantIconNeedMin ? "WaterLow" : "WaterOk";
		this.gameMediator.notify(this, _event);
	}

	public void notifySoilStatus()
	{
		string _event = this.soil < this.notifyPlantIconNeedMin ? "SoilLow" : "SoilOk";
		this.gameMediator.notify(this, _event);
	}

	public void notifySunLightStatus()
	{
		string _event = this.water < this.notifyPlantIconNeedMin ? "SunLightLow" : "SunLightOk";
		this.gameMediator.notify(this, _event);
	}

	public void notifyBugStatus()
	{
		string _event = this.bugs > this.notifyPlantIconNeedBugsMin ? "BugsIn" : "BugsOut";
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
