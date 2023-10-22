using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerAdapter : MonoBehaviour
{
    GameDialog gameDialog;

    void Start()
    {
        this.gameDialog = new GameDialog();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
