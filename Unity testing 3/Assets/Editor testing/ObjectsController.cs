using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsController: MonoBehaviour
{
    [Header("Refrences")]
    public Transform cube;
    public Transform sphere;

    [Header("Settings")]
    public float sphereRadius;
    public Vector3 cubeDimensions;

    private void Update()
    {
        //SetSphereValues();
        //SetCubeValues();
    }

    private void OnValidate()
    {
        SetSphereValues();
        SetCubeValues();
    }

    void SetSphereValues()
    {
        sphere.localScale = Vector3.one * sphereRadius;
    }

    void SetCubeValues()
    {
        cube.localScale = cubeDimensions;
    }

    private void Reset()
    {
        Debug.Log("reset");

        sphereRadius = 1f;
        cubeDimensions = Vector3.one;

        SetSphereValues();
        SetCubeValues();
    }

    private void PrintValue(float i)
    {
        Debug.Log("the value is " + i);
    }
}
