﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{

    public float value = 1f;

    public void Updatevalue(float amount)
    {
        value += amount;
    }
}