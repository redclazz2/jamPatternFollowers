using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameDialog : MonoBehaviour, MediatorInterface
{
	//Clock Checkers == Frames for internal clock handling
	public UIManager uIManager;
	public float clockEventPlantChecker = 10.0f;
	public int clockEventGeneralChecker = 1200;
	Plant plant;
	Shelter shelter;
	EventManager eventManager;
	Expedition expedition;

	private void Start()
	{
		this.plant = new Plant(this);
		this.shelter = new Shelter(this);
		this.eventManager = new EventManager(this);
		this.expedition = new Expedition(this);
		Debug.Log("Game Dialog Initialized");

		InvokeRepeating("rollEventPlant", 0.0f, clockEventPlantChecker);
	}

	public void notify(GameComponent sender, string _event)
	{
		if(sender == this.plant)
		{
			this.handlePlantEvents(_event);
		}

		if(sender == this.shelter) 
		{ 
		
		}

		if(sender == this.eventManager) 
		{ 
		
		}

		if(sender == this.expedition) {
		
		}

		if( sender == this.uIManager) {
		
		}
		//..
	}

	private void handlePlantEvents(string _event)
	{
		switch (_event)
		{
			case "WaterLow":
				this.uIManager.EnableWaterNeedIcon();
				break;
			case "WaterOk":
				this.uIManager.DisableWaterNeedIcon();
				break;
			case "SoilLow":
				this.uIManager.EnableSoilNeedIcon();
				break;
			case "SoilOk":
				this.uIManager.DisableSoilNeedIcon();
				break;
			case "SunLightLow":
				this.uIManager.EnableSolarLightNeedIcon();
				break;
			case "SunLightOk":
				this.uIManager.DisableSolarLightNeedIcon();
				break;
			case "BugsIn":
				break;
			case "BugsOut":
				break;
			
		}
	}

	void rollEventPlant()
	{
		double reducePlantVariables = 0.5; //TODO Change to random value
		this.plant.modifySubstractWater(reducePlantVariables);
		this.plant.modifySubstractSunlight(reducePlantVariables);
		this.plant.modifySubstractSoil(reducePlantVariables);
	}

	void rollEventGeneral()
	{

	}
}
