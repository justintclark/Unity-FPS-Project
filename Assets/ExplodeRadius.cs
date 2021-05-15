﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeRadius : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}