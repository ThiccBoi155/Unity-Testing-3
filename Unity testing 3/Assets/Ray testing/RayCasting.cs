using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    [Header("Refrences")]
    public Camera cam;

    [Header("Settings")]
    public float maxCamDis;
    public LayerMask camCollisionLayerMask;

    private void Start()
    {
        //Gizmos.DrawRay(Vector3.one, Vector3.one * 5);
    }

    void Update()
    {
        //Debug.DrawLine(new Vector3(0, 0, 0), new Vector3(2, 2, 2));
        ShootRay();
    }

    void ShootRay()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, transform.forward, maxCamDis, camCollisionLayerMask);

        List<string> names = new List<string>();

        foreach (RaycastHit hit in hits)
        {
            //Debug.Log(hit.transform.gameObject.name);
            names.Add(hit.transform.gameObject.name);
        }

        if (names.Count > 0)
            Debug.Log(string.Join(", ", names));
    }

    void OnDrawGizmos()
    {
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.color = Color.green;

        Gizmos.DrawCube(Vector3.zero, Vector3.one * .5f);

        Gizmos.color = Color.red;
        Gizmos.DrawRay(Vector3.zero, transform.forward);

    }

    private void OnMouseDown()
    {
        Debug.Log("Hello");
    }
}
