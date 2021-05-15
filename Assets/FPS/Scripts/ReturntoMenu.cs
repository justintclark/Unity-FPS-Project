//Justin Clark
//April 21, 2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoMenu : MonoBehaviour
{
    // After 28 seconds, the credits will end and return the player to the main menu.
    void Start()
    {
        StartCoroutine("ReturnToMenu");
    }
    
    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(28f);
        SceneManager.LoadScene(0);
    }
}
