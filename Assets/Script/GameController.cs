using System.Collections;
using System.Collections.Generic;
using Observer;
using UnityEngine;

public class GameController : ObserverEventManager
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("TurnOnObj", 2);
        Invoke("TurnOffObj", 5);
    }
    private void TurnOffObj()
    {
        notify(EventKeys.UI.TURN_OFF_OBJECT);
    }
    private void TurnOnObj()
    {
        notify("ActiveImage");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
