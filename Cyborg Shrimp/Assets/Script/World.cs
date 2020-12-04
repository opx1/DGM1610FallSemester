using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : SceneController
{
    public Transform player;
    public new void Start()
    {
        base.Start();

        switch (prevScene)
        {
            case "Switch1":
                player.position = new Vector3(-2.5f,1f,0f);
                break;
            case "Switch3":
                player.position = new Vector3(2.5f,1f,0f);
                break;
            case "Switch2": 
                player.position= new Vector3(2.5f, 1f, 0f);
                break;
            default:
                player.position = new Vector3(-2.5f,1f,0f);
                break;
        }
    }
}
