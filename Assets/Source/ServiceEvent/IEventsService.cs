using System;

public interface IEventsService
{
    void SubscribeEvent(string eventName, Action<object> callback);
    void UnsubscribeEvent(string eventName, Action<object> callback);
    void InvokeEvent(string eventName, object eventData);
}
