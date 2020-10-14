using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIreWeapon : MonoBehaviour
{
    [SerializeField] Camera cameraController;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    //fire the weapon using a raycast.
    void Shoot()
    {
        //calculate direction to shoot the ray
        //cast a debug ray
        //do the raycast detection
        Vector3 rayDirection = cameraController.transform.forward;

    }
}
