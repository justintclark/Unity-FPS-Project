//Justin Clark
//April 21, 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{ 
    public float timer = 6f;
    public Transform Player;
    public GameObject ExplosionRadius;

    void Start()
    {
        Player = GameObject.Find("PlayerLocation").transform; //Sets player location for when the grenade spawns
        GetComponent<Rigidbody>().AddForce(Player.up * 300);  //Uses physics to push the grenade up into the air 
        GetComponent<Rigidbody>().AddForce(Player.forward * 800); //Uses physics to propel the grenade forward, giving the appearance that it is thrown by the player
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.5)
        {
            GetComponent<Rigidbody>().isKinematic = true; //Uses a kinematic state to prevent the grenade from moving when it explodes
            GetComponent<SphereCollider>().enabled = true; // Enables blast radius of the explosion
            ExplosionRadius.SetActive(true); //Enables the blast radius to cause damage
        }

        if (timer <= 0)
        {
            Destroy(gameObject); //Destroys the object after it explodes
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) //If the grenade comes in direct contact with an enemy tagged "Enemy," it will explode.
        {
            timer = 0.3f; 
            Destroy(other.gameObject); //Destroys the opponent tagged "Enemy" -- This does NOT work against the BOSS enemy.
            GetComponent<Rigidbody>().isKinematic = true; 
            ExplosionRadius.SetActive(true);
            if (timer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
