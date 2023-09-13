using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shape2;

namespace Example {
    public class ExampleNamespace : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Shape shape = new Shape();
            shape.Display();
        }
    }
}
