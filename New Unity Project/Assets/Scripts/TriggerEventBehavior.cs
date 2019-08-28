﻿using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{

    public UnityEvent TriggerEnterEvent, TriggerStayEvent;
    
    private void OnTriggerEnter(Collider other)
    {
      TriggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        TriggerStayEvent.Invoke();
    }
}
