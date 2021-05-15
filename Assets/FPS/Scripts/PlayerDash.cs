//Justin Clark
//February 16, 2021

//Dash script that allows for quicker, more skillful movement by the player at the tap of the sprint (SHIFT) key. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Dash();
    }

    void Dash()
    {
        if (Input.GetButtonDown("Sprint")) // On press of left SHIFT key
        {
            StartCoroutine("Dashing"); // Start coroutine for dashing
        }
    }

    IEnumerator Dashing()
    {
        GetComponent<PlayerCharacterController>().maxSpeedOnGround *= 5f; // Player moves 5 times faster for 
        yield return new WaitForSeconds(0.05f); // 0.05 seconds
        GetComponent<PlayerCharacterController>().maxSpeedOnGround = 10f; // and then returns to normal sprint speed
    }
}
