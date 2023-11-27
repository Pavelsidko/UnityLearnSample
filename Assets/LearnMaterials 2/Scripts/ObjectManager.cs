using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField]
    private List<SampleScript> _scripts;

    void Start()
    {
        _scripts.AddRange(FindObjectsOfType<SampleScript>());
    }

    public void UseAll()
=======
    public List<SampleScript> sampleScripts;
    RotationScript RotationScript = new RotationScript();
    // Start is called before the first frame update
    void Start()
    {
        ActivateAllObjects();    }
    public void ActivateAllObjects()
    {
        //sampleScripts.Add(RotationScript);
        //sampleScripts.Add(Larionov);
        //foreach (var script in sampleScripts)
        //{
        //    script.Use();
        //}
    }
    // Update is called once per frame
    void Update()
>>>>>>> d58fbb18e378f95e8e491b8c6d80ea90bb3e0062
    {
        foreach (var script in _scripts)
            script.Use();
    }
}
