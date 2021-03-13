using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");

            // restart game
            // Restart();

            // restart game with a slight delay
            Invoke("Restart", restartDelay);
        } 
    }

    private void Restart()
    {
        // name of the scene in folder scenes
        //SceneManager.LoadScene("SampleScene");

        // this loads the currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
