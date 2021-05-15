//Justin Clark
//April 21, 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGrenade : MonoBehaviour
{
    public GameObject Grenade;
    public GameObject player; 

    // When the player presses the G key on their keyboard, a grenade is spawned to the player's position and subtracts 1 from the player's grenade count.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && player.GetComponent<PickupGrenade>().GrenadeCount >= 1)
        {
            Instantiate(Grenade, player.transform.position, Quaternion.identity);
            player.GetComponent<PickupGrenade>().GrenadeCount -= 1;
        }
    }

}
