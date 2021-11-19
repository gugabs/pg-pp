using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera pilotCamera;

    void Start()
    {
        mainCamera.enabled = true;
        pilotCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyUp("c")) {
            mainCamera.enabled = !mainCamera.enabled;
            pilotCamera.enabled = !pilotCamera.enabled;
        } 
    }
}
