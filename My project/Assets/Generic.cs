using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour
{
    public void SwapValue<T>(ref T var1, ref T var2) {
        T var3 = var1;
        var1 = var2;
        var2 = var3;
    }

    public class Pair<T1, T2> {
        public T1 key;
        public T2 value;

        public Pair(T1 key, T2 value) {
            this.key = key;
            this.value = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Swap
        /*
        string var1 = "Anto";
        string var2 = "Budi";

        Debug.Log("Before swap");
        Debug.Log("var1: " + var1);
        Debug.Log("var2: " + var2);

        SwapValue<string>(ref var1, ref var2);
        Debug.Log("After swap");
        Debug.Log("var1: " + var1);
        Debug.Log("var2: " + var2);
        */

        // Generic Class
        Pair<string, string> Car = new Pair<string, string>("Toyota", "Avanza");
        Pair<int, string> Person = new Pair<int, string>(11, "Tsubasa");

        Debug.Log("Car -> " + Car.key + ": " + Car.value);
        Debug.Log("Person -> " + Person.key + ": " + Person.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
