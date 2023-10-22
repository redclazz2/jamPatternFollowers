using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class GameDialog : MonoBehaviour, MediatorInterface
{
	//Clock Checkers == Frames for internal clock handling
	public UIManager uIManager;
	public float clockEventPlantChecker = 10.0f;
	public int clockEventGeneralChecker = 1200;
	public SpriteRenderer plantSpriteRenderer;
	public Sprite[] plantSpriteFull;
	public Sprite[] plantSpriteMedium;
	public Sprite[] plantSpriteLow;

	Shelter shelter;
	Plant plant;
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
	}

	public void notify(UIManager uiManager,string _event)
	{
		switch(_event)
		{
			case "WaterBtn":
				Debug.Log("------------UI Water Pressed--------------");
				if(this.shelter.Water >  0 && this.plant.Water < 100)
				{
					Debug.Log("Shelter has enough water to perform the action!");
					this.shelter.removeShelterWater(5);
					this.plant.modifyAddWater(5);
					Debug.Log($"Shelter resource {_event}: {this.shelter.Water} in {this.plant.Water}");
				}
				break;
		}
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


			case "PlantHealthOk":
				plantSpriteRenderer.sprite = this.plantSpriteFull;
				break;
			case "PlantHealthMeh":
				plantSpriteRenderer.sprite = this.plantSpriteMedium;
				break;
			case "PlantHealthCritical":
				plantSpriteRenderer.sprite = this.plantSpriteLow;
				break;
			case "PlantHealthGameOver":
				plantSpriteRenderer.enabled = false;
				break;
		}
	}

	void rollEventPlant()
	{
		double reducePlantVariables = 0.5; //TODO Change to random value
		this.plant.modifySubstractWater(reducePlantVariables);
		this.plant.modifySubstractSunlight(reducePlantVariables);
		this.plant.modifySubstractSoil(reducePlantVariables);
		this.plant.modifyPlantHealth();
		Debug.Log($"Plant Health: {this.plant.Health}");
	}

	void rollEventGeneral()
	{

	}
}
