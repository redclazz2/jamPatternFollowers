using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameDialog : MediatorInterface
{
	//Clock Checkers == Frames for internal clock handling
	int clockEventPlantChecker = 100;
	int eventGeneralChecker = 400;
	public Plant planta;
	public Shelter shelter;
	public EventManager eventManager;
	public Expedition expedition;


	public GameDialog()
	{
		this.planta = new Plant(this);
		this.shelter = new Shelter(this);
		this.eventManager = new EventManager(this);
		this.expedition = new Expedition(this);

		Debug.Log("Game Dialog Initialized");
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

	}

	void rollEventGeneral()
	{

	}
}
