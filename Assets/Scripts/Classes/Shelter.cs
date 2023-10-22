using UnityEngine;

public class Shelter : GameComponent
{
	public enum SunLightLevel
	{
		High,
		Medium,
		Low
	}

	private double water { get { return this.water; } set { } }
	private double soil { get { return this.soil; } set { } }
	private SunLightLevel sunlight { get { return this.sunlight; } set { this.sunlight = value; } }
	private int bugs { get { return this.bugs; } set { } }

	public Shelter(MediatorInterface gameMediator) : base(gameMediator)
	{
		this.water = 50;
		this.soil = 50;
		this.sunlight= SunLightLevel.Medium;
		this.bugs = 2;
		Debug.Log("Shelter Initialized!");
	}
}
