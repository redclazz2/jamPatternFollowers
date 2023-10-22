using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MediatorInterface
{
    public void notify(GameComponent sender, string _event);
	public void notify(UIManager uiManager, string _event);
}
