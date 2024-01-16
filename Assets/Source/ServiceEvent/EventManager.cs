using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    [SerializeField] private Button _debugEventButton;
    private IEventsService _eventsService;

    private void Start()
    {
        _debugEventButton.onClick.AddListener(DebugEventClickHandler);
        _eventsService = ServiceLocator.Instance.GetService<IEventsService>();
    }

    private void DebugEventClickHandler()
    {
        _eventsService.InvokeEvent("Debug", null);
    }
}
