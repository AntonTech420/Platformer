using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPivot : MonoBehaviour
{
    [SerializeField] Camera m_camera;
    [SerializeField] Transform gunPivot;
    [SerializeField] private bool rotateOverTime = true;
    [Range(0, 60)] [SerializeField] private float rotationSpeed = 4;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
        RotateGun(mousePos, true);
    }
    
    void RotateGun(Vector3 lookPoint, bool allowRotationOverTime)
    {
        Vector3 distanceVector = lookPoint - gunPivot.position;

        float angle = Mathf.Atan2(distanceVector.y, distanceVector.x) * Mathf.Rad2Deg;
        if (rotateOverTime && allowRotationOverTime)
        {
            gunPivot.rotation = Quaternion.Lerp(gunPivot.rotation, Quaternion.AngleAxis(angle, Vector3.forward), Time.deltaTime * rotationSpeed);
        }
        else
        {
            gunPivot.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
