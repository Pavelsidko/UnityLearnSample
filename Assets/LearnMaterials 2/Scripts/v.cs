using System.Collections;
using UnityEngine;

public class v : SampleScript
{
    public Transform target;

    public override void Use()
    {
        StartCoroutine(ShrinkChildren());
    }
    IEnumerator ShrinkChildren()
    {
        foreach (Transform child in target)
        {
            StartCoroutine(ShrinkObject(child));
        }

        yield return new WaitForSeconds(10f);
        foreach (Transform child in target)
        {
            Destroy(child.gameObject);
        }
    }

    IEnumerator ShrinkObject(Transform obj)
    {
        float scaleSpeed = 0.1f;
        Vector3 targetScale = Vector3.zero;

        while (obj.localScale != targetScale)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, targetScale, Time.deltaTime * scaleSpeed);
            yield return null;

        }

    }
}