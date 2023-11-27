using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidkoScript : SampleScript
{
    public GameObject prefab;
    public int quantity;
    public float step;
    public override void Use()
    {
        CreateObjects();
    }


    void CreateObjects()
    {
        for (int i = 0; i < quantity; i++)
        {
            Vector3 position = transform.position + transform.forward * i * step;
            Instantiate(prefab, position, Quaternion.identity);
        } 
       
    }
}
