using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // this will put the player to the scene where we are at + 1 of the index (next scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
