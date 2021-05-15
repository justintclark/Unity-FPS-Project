//Justin Clark
//February 15, 2021
//Power up item used to increase the player's health. I came up with this idea to counterbalance any hard mode challenge that might feel unfair. 
//By the time the player collects two in the third level, he or she should feel sufficiently powerful enough to challenge the boss.
//As this is for hard mode, hard mode's difficulty scales the enemies' damage by 1.5x. Enemies' health pools are also increased by 2.5x. 
//Boss health pools are increased significantly. 
//My intent was to also increase the player's damage output, but the way this project is coded doesn't make it very clear how exactly to
//influence the damage of each of the projectiles. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpherePickup : MonoBehaviour
{

    public GameObject player;
    Health playerHealth; 

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = player.GetComponent<Health>();
    }

    void OnTriggerEnter (Collider other)
    {
        playerHealth.maxHealth *= 2; //Double the player's maximum health.
        playerHealth.Heal(300); //Heal the player's health to full... or up to 300. 
        Destroy(gameObject); //Destroy this object after it is picked up.
    }
}
