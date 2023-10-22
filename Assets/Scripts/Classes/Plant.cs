using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : GameComponent
{
	private double health { get { return this.health; } set { } } 
	private double water { get { return this.water; } set { } }
	private double soil { get { return this.soil;  } set { } }
	private double sunlight { get { return this.sunlight; } set { } }
	private int bugs { get { return this.bugs; } set { } }	

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

}
