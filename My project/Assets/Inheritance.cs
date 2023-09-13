using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Motorcycle cbr = new Motorcycle("CBR", 100f, "Silver", "F 4 ST", 150);
        cbr.Move();
        cbr.DisplaySpec();

        Horse redHare = new Horse("Red Hare", 60f, "Crimson", 20);
        redHare.Move();
        redHare.DisplaySpec();
    }

}
public class Transport {
    public string name;
    public float speed;
    public string color;

    public Transport(string name, float speed, string color) {
        this.name = name;
        this.speed = speed;
        this.color = color;
    }

    public void Move() {
        Debug.Log(color + " " + name + " is moving in " + speed + " km/h");
    }
}

public class Motorcycle : Transport {
    public string licensePlate;
    public int cc;

    public Motorcycle(string name, float speed, string color, string licensePlate, int seat) : base(name, speed, color) {
        this.licensePlate = licensePlate;
        this.cc = seat;
    }

    public void DisplaySpec() {
        Debug.Log(color + " " + cc + " cc " + name + " motorcycle with license plate " + licensePlate + " can move in " + speed + " km/h");
    }
}

public class Horse : Transport {
    public int age;

    public Horse(string name, float speed, string color, int age) : base(name, speed, color) {
        this.age = age;
    }

    public void DisplaySpec() {
        Debug.Log(color + " " + age + " years old " + name + " horse is moving in " + speed + " km/h");
    }
}