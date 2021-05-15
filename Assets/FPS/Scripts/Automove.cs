//Justin Clark
//April 21, 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automove : MonoBehaviour
{
    public GameObject[] Waypoints;
    public int location;
    public float speed = 3.0f;

    // This sets the initial location to 0.
    void Start()
    {
        location = 0;
    }

    void Update()
    {
         // Move our position a step closer to the target.
         float step = speed * Time.deltaTime; // calculate distance to move
         transform.position = Vector3.MoveTowards(transform.position, Waypoints[location].transform.position, step); //Sets next position to move to to the specific location

         // Check if the position of the cube and sphere are approximately equal.
         if (Vector3.Distance(transform.position, Waypoints[location].transform.position) < 5f) // When the drone is within a certain distance of the location
         {
            location += 1; //Increase the location by 1, to make the drone go to the next location in the list
            
            if (location >= Waypoints.Length)
            {
                location -= 1; // If the drone reaches the final location, this prevents the location from going beyond the array's length.
            }
         }
    }
}
