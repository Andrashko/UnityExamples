using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventSystem : MonoBehaviour
{
    private static Dictionary<string, UnityEvent> eventDictionary = new Dictionary<string, UnityEvent>();
    public static UnityEvent GetEvent(string name)
    {
        if (!eventDictionary.ContainsKey(name))
        {
            eventDictionary[name] = new UnityEvent();
        }
        return eventDictionary[name];
    }

    private static Dictionary<string, object> eventDictionaryWithParams = new Dictionary<string, object>();

    public static UnityEvent<T> GetEvent<T>(string eventName)
    {
        if (!eventDictionaryWithParams.ContainsKey(eventName))
        {
            eventDictionaryWithParams[eventName] = new UnityEvent<T>();
        }
        return eventDictionaryWithParams[eventName] as UnityEvent<T>;
    }
}
