using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
namespace Observer
{
    public class ObserverEventManager : MonoBehaviour
    {
        private static Observer instance;
        private static Observer Instance
        {
            get
            {
                if (instance == null)
                    instance = new Observer();
                return instance;
            }
        }
        public static void attach(string obsName, Delegate method)
        {
            Instance.Attach(obsName, method);
        }
        public static void detach(string obsName, Delegate method)
        {
            Instance.Detach(obsName,method);
        }
        public static void notify(string obsName, params object[] args )
        {
            Instance.Notify(obsName, args);
        }
    }
}

