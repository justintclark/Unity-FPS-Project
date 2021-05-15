//Justin Clark
//April 21, 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGrenade : MonoBehaviour
{
    public int GrenadeCount = 0;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("GrenadePickup")) //When a player comes in direct contact with a grenade pickup prefab, it adds 1 to the amount of grenades the player is holding.
        {
            GrenadeCount += 1;
            Destroy(other.gameObject);
        }
    }
}
