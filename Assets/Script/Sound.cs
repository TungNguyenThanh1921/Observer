using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Observer;
using System;
public class Sound : ObserverEventManager
{
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = this.GetComponent<Image>();
        attach(EventKeys.UI.IMAGE_STATE, (Action)ActiveImage);
    }
    private void ActiveImage()
    {
        image.color = Color.green;
    }

}
