using UnityEngine;

public class EventManager:GameComponent
{
    private EventInterface currentEvent;

	public EventManager(MediatorInterface mediator): base(mediator)
    {
        this.currentEvent = null;
		Debug.Log("Event Manager Initialized");
	}    

    public void executeEvents()
    {
        this.currentEvent.executeEvent();
    }

    public void changeCurrentEvent(EventInterface newEvent)
    {
        this.currentEvent = newEvent;
    }
}
