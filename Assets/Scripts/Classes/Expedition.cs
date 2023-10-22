using UnityEngine;

public class Expedition : GameComponent
{
	int timerExpedition = 3600;
	public Expedition(MediatorInterface gameMediator) : base(gameMediator)
	{
		Debug.Log("Expedition State Initialized");
	}

	public void startExpedition()
	{

	}

	public void stopExpedition()
	{

	}

	public void finishExpedition()
	{

	}
}
