using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : SampleScript
{
    public float rotationSpeed = 10f;
    public Vector3 rotationAxis = Vector3.up;
    public float targetAngle = 90f;

    private bool isRotating = false;
    private float currentAngle = 0f;

    public override void Use()
    {
        if (!isRotating)
        {
            StartCoroutine(RotateObject());
        }
    }

    private IEnumerator RotateObject()
    {
        isRotating = true;
        float duration = targetAngle / rotationSpeed;

        while (currentAngle < targetAngle)
        {
            float angleToRotate = rotationSpeed * Time.deltaTime;
            transform.Rotate(rotationAxis, angleToRotate);
            currentAngle += angleToRotate;
            yield return null;
        }

        isRotating = false;
    }
}
