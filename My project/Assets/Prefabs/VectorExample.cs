using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    [SerializeField]
    Vector2 _vector1 = new Vector2(1f, 2f);

    [SerializeField]
    Vector3 _vector2 = new Vector3(0f, 25f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("_vector1: " + _vector1);
        Debug.Log("_vector2: " + _vector2);

        Vector3 vectorResult = _vector2 + new Vector3(0f, 20f, 0f);
        Debug.Log("vectorResult: " + vectorResult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
