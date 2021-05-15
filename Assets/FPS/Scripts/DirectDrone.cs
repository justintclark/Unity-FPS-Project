// Justin Clark
//April 21, 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectDrone : MonoBehaviour
{
    public GameObject drone;

    void Start()
    {
        drone = GameObject.FindWithTag("Drone");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            drone.transform.position = transform.position; //If the player wants to summon the drone to their location, pressing the Z button will immediately set the transform of the drone equal to the transform of the player.
        }
    }
}
