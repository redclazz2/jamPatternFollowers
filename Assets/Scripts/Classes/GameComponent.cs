using UnityEngine;

public class GameComponent:MonoBehaviour
{
    private MediatorInterface gameMediator;
    public GameComponent(MediatorInterface gameMediator)
    {
        this.gameMediator = gameMediator;
    }
}
