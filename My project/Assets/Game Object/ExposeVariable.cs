using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExposeVariable : MonoBehaviour
{
    public int Number;

    [SerializeField]
    private string _color = "Red";

    private float _length = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Number: " + Number);
        Debug.Log("Color: " + _color);
        Debug.Log("Length: " + _length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
