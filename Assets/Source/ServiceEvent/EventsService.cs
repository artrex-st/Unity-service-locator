using System;
using System.Collections.Generic;
using UnityEngine;

public class EventsService : MonoBehaviour, IEventsService
{
    private Dictionary<string, List<Action<object>>> eventSubscribers;

    public EventsService()
    {
        eventSubscribers = new Dictionary<string, List<Action<object>>>();
    }

    public void SubscribeEvent(string eventName, Action<object> callback)
    {
        if (!eventSubscribers.ContainsKey(eventName))
        {
            eventSubscribers[eventName] = new List<Action<object>>();
        }

        eventSubscribers[eventName].Add(callback);
    }

    public void UnsubscribeEvent(string eventName, Action<object> callback)
    {
        if (eventSubscribers.ContainsKey(eventName))
        {
            eventSubscribers[eventName].Remove(callback);
        }
    }

    public void InvokeEvent(string eventName, object eventData)
    {
        if (eventSubscribers.ContainsKey(eventName))
        {
            foreach (var callback in eventSubscribers[eventName])
            {
                callback.Invoke(eventData);
            }
        }
    }
}
