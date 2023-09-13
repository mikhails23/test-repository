using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
