using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Car avanza = new Car();
        avanza.name = "Avanza";
        avanza.speed = 60f;
        avanza.color = "Black";

        avanza.Move();

        Car innova = new Car();
        innova.name = "Innova";
        innova.speed = 80f;
        innova.color = "Blue";

        innova.Move();

        Car mobilio = new Car("Mobilio", 65f, "Red");
        mobilio.Move();

        Car sigra = new Car("Sigra", 69.42f, "Grey");
        sigra.Move();
    }

}

public class Car {
    public string name;
    public float speed;
    public string color;

    public Car() {

    }

    public Car(string name, float speed, string color) {
        this.name = name;
        this.speed = speed;
        this.color = color;
    }

    public void Move() {
        Debug.Log(color + " " + name + " car is moving in " + speed + " km/h");
    }
}
