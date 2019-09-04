using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{

    public float value = 1f;
    public float maxValue = 1f;
    public void Updatevalue(float amount)
    {
        value += amount;
    }


    public void UpdatevalueLimitZero(float amount)
    {
        if (value < 0)
        {
            value = 0;
        }
        else
        {
            Updatevalue(amount);
        }
    }

    public void UpdatevalueLimitZeroandMax(float amount)
    {
        if (value < maxValue)
       {
           Updatevalue(amount);
       }
       else
       {
           value = maxValue;
       }
        UpdatevalueLimitZero(amount);
    }
}
