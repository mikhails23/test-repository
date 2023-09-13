using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Print Hello World
        Debug.Log("Hello World");

        int varInt = 10;
        float varFloat = 2.5f;
        double varDouble = 2.5;
        char varChar = 'F';
        string varString = "Variable String";
        bool varBool = true;

        Debug.Log("varInt = " + varInt);
        Debug.Log("varFloat = " + varFloat);
        Debug.Log("varDouble = " + varDouble);
        Debug.Log("varChar = " + varChar);
        Debug.Log("varString = " + varString);
        Debug.Log("varBool = " + varBool);

        int varInt1 = 10, varInt2 = 20;
        Debug.Log("Before switch varInt1: " + varInt1 + " varInt2: " + varInt2);
        int varInt3 = varInt1;
        varInt1 = varInt2;
        varInt2 = varInt3;
        Debug.Log("After switch varInt1: " + varInt1 + " varInt2: " + varInt2);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Debug.Log("Hello Update");
    // }
}
