using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Array basic
        /*
        string[] strArray = {"Asep", "Budi", "Carli"};

        Debug.Log("Array index 1: " + strArray[1]);

        strArray[0] = "Dodol";
        Debug.Log("Array index 0 baru: " + strArray[0]);

        Debug.Log("Panjang array: " + strArray.Length);
        */

        // Array with loop
        string[] strArray = {"Asep", "Budi", "Carli", "Dono"};
        for (int i = 0; i < strArray.Length; i++) {
            Debug.Log("Array index ke-" + i + " adalah: " + strArray[i]);
        }

        for (int i = strArray.Length - 1; i >= 0 ; i--) {
            Debug.Log("Array index ke-" + i + " adalah: " + strArray[i]);
        }
    }

}
