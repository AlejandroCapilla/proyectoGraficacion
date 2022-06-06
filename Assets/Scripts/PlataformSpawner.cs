using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlataformSpawner : MonoBehaviour
{
    //public GameObject sectionPrefab;
    public GameObject sectionPref;
    public GameObject world;

    private List<int> rotationList;
    // Start is called before the first frame update
    void Start()
    {
        sectionGenerate(1);
        sectionGenerate(2);
        sectionGenerate(3);
        sectionGenerate(4);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "section")
        {
            sectionGenerate(4);
        }
    }

    private void sectionGenerate(int pos)
    {
        Vector3 position = new Vector3(0, 0, pos*16);
        Quaternion rotation = new Quaternion();
        Instantiate(sectionPref, position, rotation).transform.SetParent(world.transform,worldPositionStays:false);
    }
}
