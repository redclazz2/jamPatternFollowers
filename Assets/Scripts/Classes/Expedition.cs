using UnityEngine;

public class Expedition : GameComponent
{
	[SerializeField]
	private int timerExpedition = 3600;

    public int TimerExpedition { get => timerExpedition; set => timerExpedition = value; }

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
