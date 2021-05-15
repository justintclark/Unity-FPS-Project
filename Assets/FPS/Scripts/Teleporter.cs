//Justin Clark
//February 15, 2021
//Simple teleporter based on a simple of idea if merely setting the player's position to some other object's position. 
//This is a simple logic I came up with for the idea of a teleporter. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    public GameObject destination;

    private void OnTriggerEnter(Collider other) //If touched by another object's collider
    {
        player.transform.position = destination.transform.position; //Set player's position to destination's position
        Debug.Log("Teleporter activated."); // Debug output for testing purposes
    }
}
