using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformSpawner : MonoBehaviour
{
    public GameObject plataformPrefab;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "plataform")
        {
            Vector3 position = new Vector3(0, 0, 56);
            Quaternion rotation = new Quaternion();
            Instantiate(plataformPrefab,position,rotation);
        }
    }
}
