using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    void PlayerAttack3Times() {
        int atkCounter = 1;
        while (atkCounter <= 3) {
            Debug.Log("Attack ke-" + atkCounter);
            Debug.Log("Enemy damaged");
            atkCounter++;
        }
    }

    void EnemyHealing() {
        Debug.Log("Enemy healing");
    } 

    void PlusTwoNumbers(int a, int b) {
        int result = a + b;
        Debug.Log(a + " + " + b + " = " + result);
    }

    void DisplayText() {
        Debug.Log("Hello there"); 
    }
    void DisplayText(string text) {
        Debug.Log(text);
    }

    void DisplayText(string text1, string text2) {
        Debug.Log(text1 + " " + text2);
    }

    void DisplayText(string text, int num) {
        Debug.Log(text + " " + num);
    }
    
    int PlusTwoNumbersWithReturn(int a, int b) {
        return a + b;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Functions 1
        /*
        PlayerAttack3Times();
        EnemyHealing();
        PlayerAttack3Times();
        */

        // Functions with param
        /*
        PlusTwoNumbers(2, 4);
        PlusTwoNumbers(5, 3);
        */

        // Function types
        /*
        DisplayText("name");
        // int result = PlusTwoNumbersWithReturn(10, 20);
        Debug.Log("10 + 20 = " + PlusTwoNumbersWithReturn(10, 20));
        */

        // Function overload
        DisplayText();
        DisplayText("Oh");
        DisplayText("My", "name");
        DisplayText("is", 4);

    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
