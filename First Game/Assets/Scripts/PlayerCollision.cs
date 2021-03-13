using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // a reference to our PlayerMovement script
    public PlayerMovement movement;


    // this function runs when we hit another object
    // we get information about the collisiona nd call it "collisionInfo"
    void OnCollisionEnter(Collision collisionInfo){

        // we check if the object we collided with has a tag of "obstacle"
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
