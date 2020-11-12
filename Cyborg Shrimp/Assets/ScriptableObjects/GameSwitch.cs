using System;
using UnityEngine;
[CreateAssetMenu]
public class GameSwitch : ScriptableObject
{
    public enum GameStates
    {
        Starting,
        Playing,
        Ending,
        InStore,
        Pausing
    }

    public GameStates currentGameState = GameStates.Starting;

    public void ChangeToPlaying()
    {
        currentGameState = GameStates.Playing;
    }
    
    public void RunCurrentState()
    {
        switch (currentGameState)
        {
            case GameStates.Starting:
                Debug.Log("starting");
                break;
            case GameStates.Playing:
                Debug.Log("playing");
                break;
            case GameStates.Ending:
                Debug.Log("ending");
                break;
            case GameStates.InStore:
                Debug.Log("instore");
                break;
            case GameStates.Pausing:
                Debug.Log("pausing");
                break;
           
        }
    }
        
}