using System.Collections;
using System.Collections.Generic;
using Observer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController : ObserverEventManager
{
    public Button lightBtn, soundBtn, effectBtn, activeAll;
    void Start()
    {
        UnityAction callback = () =>
        {
            Debug.Log("có call back nên return lại nè");
        };
        lightBtn.onClick.AddListener(() =>
        {
            notify(EventKeys.UI.LIGHT_STATE, callback);
        });

        soundBtn.onClick.AddListener(() =>
        {
            notify(EventKeys.UI.SOUND_STATE, new object[] { 2, "hai", 2 });
        });



        UnityAction<int> ID = (value) =>
       {
           Debug.Log("Show ID: " + value);
       };
        UnityAction<string> NAME = (name) =>
        {
            Debug.Log("Show Name: " + name);
        };
        bool flag = true;
        object[] data = new object[] { ID, NAME, flag };
        effectBtn.onClick.AddListener(() =>
        {
            notify(EventKeys.UI.EFFECT_STATE, data);
        });



        activeAll.onClick.AddListener(() =>{
            notify(EventKeys.UI.IMAGE_STATE);
        });
    }
    void Update()
    {

    }
}
