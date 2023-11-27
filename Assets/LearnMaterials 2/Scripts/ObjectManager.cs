using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField]
    private List<SampleScript> _scripts;

    void Start()
    {
        _scripts.AddRange(FindObjectsOfType<SampleScript>());
    }

    public void UseAll()
    {
        foreach (var script in _scripts)
            script.Use();
    }
}
