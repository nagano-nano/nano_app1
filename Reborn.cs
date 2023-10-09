using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reborn : MonoBehaviour
{
    public GameObject charactor;
    Vector3 startposition;
    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = charactor.transform.position;
        if(  (position.x > 5.25) || (position.x < -5.25) || (position.z > 5.25) || (position.z < -5.25) || (position.y < -2))
        {
            transform.position = startposition;
        }
    }
}
