using UnityEngine;

public class GameComponent:MonoBehaviour
{
    public MediatorInterface gameMediator;
    public GameComponent(MediatorInterface gameMediator)
    {
        this.gameMediator = gameMediator;
    }
}
