using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bussola : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 dir;

    // Update is called once per frame
    private void Update()
    {
        dir.z = playerTransform.eulerAngles.y;
        transform.localEulerAngles = dir;
    }
}
