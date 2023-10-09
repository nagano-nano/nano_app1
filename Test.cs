using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Vector3 previousPosition;
    Vector3 zero = new Vector3(0, 0, 0);
    Quaternion previousRotation;
    Vector3 velocities;
    Vector3 velocityminus;
    Vector3 deltaPosition;
    public float keta = 40;
    public float gosa = 0.01f;
    public bool viblation;

    private void OnEnable()
    {
        previousRotation = transform.rotation;
        previousPosition = transform.position;
    }

    void Update()
    {
        ControllSyringe();

        Vibration();

    }

    private void ControllSyringe()
    {
        transform.rotation = previousRotation;
        velocities = transform.rotation * new Vector3(0, -1, 0);

        float velocitiesMagnitude = velocities.magnitude;

        velocities.x *= keta;
        velocities.y *= keta;
        velocities.z *= keta;

        velocities.x = Mathf.Round(velocities.x / velocitiesMagnitude);
        velocities.y = Mathf.Round(velocities.y / velocitiesMagnitude);
        velocities.z = Mathf.Round(velocities.z / velocitiesMagnitude);


        velocityminus = -velocities;


        deltaPosition = transform.position - previousPosition;

        float deltaPositionMagnitude = deltaPosition.magnitude;


        deltaPosition.x *= keta;
        deltaPosition.y *= keta;
        deltaPosition.z *= keta;


        deltaPosition.x = Mathf.Round(deltaPosition.x / deltaPositionMagnitude);
        deltaPosition.y = Mathf.Round(deltaPosition.y / deltaPositionMagnitude);
        deltaPosition.z = Mathf.Round(deltaPosition.z / deltaPositionMagnitude);


        if (deltaPositionMagnitude > gosa)
        {

            if ((((deltaPosition != velocities)) && (deltaPosition != zero)))
            {
                if ((((deltaPosition != velocityminus))))
                {
                    transform.position = previousPosition;
                }
            }

        }

        previousPosition = transform.position;
    }

    void Vibration()
    {
        if (deltaPosition != new Vector3(0, 0, 0))
        {
            viblation = true;
        }
        if (deltaPosition == new Vector3(0, 0, 0))
        {
            viblation = false;
        }
    }

}