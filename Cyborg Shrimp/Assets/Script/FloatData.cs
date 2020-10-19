using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatData : ScriptableObject
{
  public float value;

  public void UpdateValue(float number)
  {
    value += number;
  }
}
