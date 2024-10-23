using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOb : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(25,0,0);
    public GameObject oB;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(oB, spawnPos, oB.transform.rotation);
    }
}
