using UnityEngine;

public class Shelter : GameComponent
{
	public enum SunLightLevel
	{
		High,
		Medium,
		Low
	}

	private double water;
	private double soil;
	private SunLightLevel sunlight;
	private int bugs;

	public double Water { get { return this.water;  } set { this.water = value; } }
	public double Soil { get { return this.soil; } set { this.soil = value; } }
	public SunLightLevel SunLight { get { return this.sunlight; } set { this.sunlight = value; } }
	public int Bugs{ get { return this.bugs; } set { this.bugs = value; } }

	public Shelter(MediatorInterface gameMediator) : base(gameMediator)
	{
		this.water = 50;
		this.soil = 50;
		this.sunlight= SunLightLevel.Medium;
		this.bugs = 2;
		Debug.Log("Shelter Initialized!");
	}

	#region Modifiers - Add from variable values
	
	public void addShelterWater(double value)
	{
		this.water += value;
	}

	public void addShelterSoil(double value)
	{
		this.soil += value;
	}

	public void addShelterBugs(int value)
	{
		this.bugs += value;
	}

	public void modifySunCurrent(SunLightLevel value)
	{
		this.sunlight = value;
	}

	#endregion

	#region Modifiers - Substract to variable values
	public void removeShelterWater(double value)
	{
		this.water -= value;
	}

	public void removeShelterSoil(double value)
	{
		this.soil -= value;
	}

	public void removeShelterBugs(int value)
	{
		this.bugs -= value;
	}
	#endregion
}
