using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CHealth : ScriptableObject
{
   public int Value
    {
        get { return _Value;  }
    }

    public int CurrentVaue
    {
        get { return _CurrentValue; }
    }

    [SerializeField]
    public int _CurrentValue;

    [SerializeField]
    public int _Value;

    public void init()
    {
        _CurrentValue = _Value;
    }

   public int Damage(int value)
    {
        _CurrentValue -= value;

        return _CurrentValue;
    }

    public int heal(int value)
    {
        _CurrentValue += value;
        return _CurrentValue;
    }
}
