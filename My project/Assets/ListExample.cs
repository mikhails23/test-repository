using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> strList = new List<string>();

        strList.Add("Agus");
        strList.Add("Anto");
        strList.Add("Budi");
        strList.Add("Jono");

        strList.Insert(2, "Joko");

        Debug.Log("List: ");
        for (int i = 0; i < strList.Count; i++) {
            Debug.Log(strList[i]);
        }

        Debug.Log("List length: " + strList.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
