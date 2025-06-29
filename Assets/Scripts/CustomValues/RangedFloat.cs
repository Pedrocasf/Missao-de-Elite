using UnityEngine;

[System.Serializable]
public class RangedFloat
{
    [SerializeField] protected float maxValue;
    [SerializeField] protected float currentValue;
    [SerializeField] protected float minValue;

    public float MaxValue => maxValue;
    public float MinValue => minValue;
    public float CurrentValue
    {
        get => currentValue;
        set => currentValue=Mathf.Clamp(value, minValue, maxValue);
    }
    public float Percentage
    {
        get => (currentValue - minValue) / (maxValue - (float)minValue);
        set => currentValue = Mathf.Lerp(minValue, maxValue, Mathf.Clamp01(value));
    }

    public void SetToMaxValue()
    {
        currentValue = maxValue;
    }

    public void SetToMinValue()
    {
        currentValue = minValue;
    }

    public bool IsMaxValue()
    {
        return currentValue == maxValue;
    }

    public bool IsMinValue()
    {
        return currentValue == minValue;
    }

}
