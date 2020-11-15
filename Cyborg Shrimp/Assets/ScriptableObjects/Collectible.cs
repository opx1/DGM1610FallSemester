using UnityEngine;

[CreateAssetMenu]
public class Collectible : ScriptableObject
{
  public float powerLevel = 1f;
  public int cashValue = 10;
  public Color artColor = Color.blue;
  public Sprite art;
}