using UnityEngine;

public class GameComponent
{
    public MediatorInterface gameMediator;
    public GameComponent(MediatorInterface gameMediator)
    {
        this.gameMediator = gameMediator;
    }
}
