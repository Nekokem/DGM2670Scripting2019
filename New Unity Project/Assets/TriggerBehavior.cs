using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehavior : MonoBehaviour
{
    public floatdata data;
    private void OnTriggerEnter(Collider other)
    {
        data.Updatevalue(-.1f);
    }
}
