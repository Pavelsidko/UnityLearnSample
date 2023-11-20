using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public List<SampleScript> sampleScripts;
    RotationScript RotationScript = new RotationScript();

    // Start is called before the first frame update
    void Start()
    {
        ActivateAllObjects();
    }
    public void ActivateAllObjects()
    {
        sampleScripts.Add(RotationScript);

        foreach (var script in sampleScripts)
        {
            script.Use();
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
