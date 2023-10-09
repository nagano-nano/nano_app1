using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPower : MonoBehaviour
{    
    public GameObject tyusya;
    public Rigidbody rb;
    public Rigidbody rb1;
    public Rigidbody rb2;
    public Rigidbody rb3;
    public GameObject parts1;
    public GameObject parts2;
    private Vector3 preposition;
    private Vector3 prepositionForEcho;
    public GameObject RighthandPositionForInjection;
    public GameObject LefthandPositionForEcho;
    public GameObject echo;
    public bool viblattion;


    private void Start()
    {
        rb = tyusya.GetComponent<Rigidbody>();
        rb1 = tyusya.GetComponent<Rigidbody>();
        rb2 = tyusya.GetComponent<Rigidbody>();
        rb3 = tyusya.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject == parts1) || (other.gameObject == parts2))
        {
            preposition = tyusya.transform.position;
        }
        if(other.gameObject == echo)
        {
            prepositionForEcho = echo.transform.position;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject == parts1) || (other.gameObject == parts2))
        {
            tyusya.transform.position = preposition;
        }
        if (other.gameObject == echo)
        {
            echo.transform.position = prepositionForEcho;
        }

        if (other.gameObject == tyusya)
        {
            rb.useGravity = false;
            rb1.useGravity = false;
            rb2.useGravity = false;
            rb3.useGravity = false;
            tyusya.GetComponent<Test>().enabled = true;
            viblattion = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == tyusya)
        {
            rb.useGravity = true;
            rb1.useGravity = true;
            rb2.useGravity = true;
            rb3.useGravity = true;
            tyusya.GetComponent<Test>().enabled = false;

            if (RighthandPositionForInjection.transform.position.y > 0.7)
            {
                tyusya.transform.localPosition = RighthandPositionForInjection.transform.localPosition;
                tyusya.transform.localRotation = RighthandPositionForInjection.transform.localRotation;
            }
            viblattion = false;
        
        }

        if (other.gameObject == echo)
        {
            if (LefthandPositionForEcho.transform.position.y > 0.573)
            {
                echo.transform.localPosition = LefthandPositionForEcho.transform.localPosition;
                echo.transform.localRotation = LefthandPositionForEcho.transform.localRotation;
            }
        }
    }
    private void Update()
    {
        if (RighthandPositionForInjection.transform.position.y > 0.7)
        {
            if (tyusya != RighthandPositionForInjection)
            {
                tyusya.transform.localPosition = RighthandPositionForInjection.transform.localPosition;
                tyusya.transform.localRotation = RighthandPositionForInjection.transform.localRotation;
            }
        }
        if (LefthandPositionForEcho.transform.position.y > 0.59)
        {
            if (echo != LefthandPositionForEcho)
            {
                echo.transform.localPosition = LefthandPositionForEcho.transform.localPosition;
                echo.transform.localRotation = LefthandPositionForEcho.transform.localRotation;
            }
        }
    }
}
