using UnityEngine;


[CreateAssetMenu]
public class floatdata : ScriptableObject
{
    public float value = 1f;
    public void Updatevalue(float number)
    {
        value += number;
    }

   
}
