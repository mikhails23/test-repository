using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // IF branch
        /*
        int health = 99;

        if (health >= 100) {
            Debug.Log("Health is full");
        } else if (health <= 0) {
            Debug.Log("You are already dead");
        } else {
            health = health + 10;
            if (health >= 100) {
                health = 100;
            }
            Debug.Log("Health Healed");
        }
        Debug.Log("Health is now: " + health);
        */

        // Switch Case branch
        char answer = 'F';
        switch(answer) {
            case 'A':
                Debug.Log("Answer is A");
                break;
            case 'B':
                Debug.Log("Answer is B");
                break;
            case 'C':
                Debug.Log("Answer is C");
                break;
            case 'D':
                Debug.Log("Answer is D");
                break;
            default:
                Debug.Log("Invalid answer");
                break;
        }
    }
}
