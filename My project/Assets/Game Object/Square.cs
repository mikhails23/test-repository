using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private GameObject _circle;

    // Start is called before the first frame update
    void Start()
    {
        _circle = GameObject.Find("Circle");
        Transform transform = _circle.GetComponent<Transform>();
        Debug.Log(transform.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
