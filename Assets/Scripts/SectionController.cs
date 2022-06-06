using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SectionController : MonoBehaviour
{
    public GameObject plataformPrefab;
    
    private List<int> rotationList;
    // Start is called before the first frame update
    void Start()
    {
        rotationList = new List<int>(){1,2,3,4,5,6,7,8,9,10};
        int listLimit = 10;
        for (int j = 0; j < 6; j++)
        {
            int numAl = rotationList[Random.Range(0, listLimit)];
            rotationList.Remove(numAl);
            listLimit = listLimit - 1;
            int rotationZ = numAl * 36;
            Vector3 position = new Vector3(0, 0, 0);
            Quaternion rotation = Quaternion.Euler(0f, 0f, rotationZ);
            Instantiate(plataformPrefab,position,rotation).transform.SetParent(this.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0,0,-30f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "plataform_destroyer")
        {
            Destroy(gameObject);
        }
    }
}
