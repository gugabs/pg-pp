using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraProjection : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        if (Input.GetKeyUp("p")) {
            mainCamera.orthographic = !mainCamera.orthographic;
        }
    }
}
