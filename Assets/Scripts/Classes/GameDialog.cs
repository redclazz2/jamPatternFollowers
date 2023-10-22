using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameDialog : MonoBehaviour, MediatorInterface
{
	//Clock Checkers == Frames for internal clock handling
	public float clockEventPlantChecker = 10.0f;
	public int eventGeneralChecker = 1200;
	public Plant planta;
	public Shelter shelter;
	public EventManager eventManager;
	public Expedition expedition;

	private void Start()
	{
		this.planta = new Plant(this);
		this.shelter = new Shelter(this);
		this.eventManager = new EventManager(this);
		this.expedition = new Expedition(this);

		Debug.Log("Game Dialog Initialized");

		InvokeRepeating("rollEventPlant", 0.0f, clockEventPlantChecker);
	}

	public void notify(GameComponent sender, string _event)
	{
		if(sender == this.planta)
		{

		}

		if(sender == this.shelter) 
		{ 
		
		}

		if(sender == this.eventManager) 
		{ 
		
		}

		//..
	}

	void rollEventPlant()
	{
		double reducePlantVariables = 0.5; //TODO Change to random value
		this.planta.modifySubstractWater(reducePlantVariables);
		this.planta.modifySubstractSunlight(reducePlantVariables);
		this.planta.modifySubstractSoil(reducePlantVariables);
	}

	void rollEventGeneral()
	{

	}
}
