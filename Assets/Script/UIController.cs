using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Observer;
using UnityEditor.Experimental.GraphView;
using UnityEngine.Events;
using System;
using System.Data.Common;
using UnityEngine.UI;
public class UIController : ObserverEventManager
{
    public GameObject light, sound, effect;
    void Start()
    {
        attach(EventKeys.UI.LIGHT_STATE, (Action<UnityAction>)Light);
        attach(EventKeys.UI.SOUND_STATE, (Action<int, string, int>)Sound);
        attach(EventKeys.UI.EFFECT_STATE, (Action<UnityAction<int>, UnityAction<string>, bool>)Effect);
    }

    private void Light(UnityAction a)
    {
        Debug.Log("Vào đây trước khi return");
        a.Invoke();
        light.SetActive(true);
    }
    private void Sound(int a, string b, int c)
    {
        Debug.Log("Show int: " + a + " , string: " + b + " , int: " + c);
        detach(EventKeys.UI.SOUND_STATE,(Action<int, string, int>)Sound);
        sound.SetActive(true);
    }
    private void Effect(UnityAction<int> id, UnityAction<string> name, bool flag)
    {
        if (flag)
            id?.Invoke(10);
        else
            name?.Invoke("fail");
        effect.SetActive(true);
    }
}
