using UnityEngine;

public class GameComponent:ScriptableObject
{
    public MediatorInterface gameMediator;
    public GameComponent(MediatorInterface gameMediator)
    {
        this.gameMediator = gameMediator;
    }
}
