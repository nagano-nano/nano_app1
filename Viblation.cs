using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viblation : MonoBehaviour
{
    public Test test;
    public WallPower wallPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(test.viblation == true)
        {
            OVRInput.SetControllerVibration(frequency: 0.1F, amplitude:0.1f, OVRInput.Controller.RTouch);
        }
        if((test.viblation == false) || (wallPower.viblattion == false))
        {
            OVRInput.SetControllerVibration(frequency: 0.0F, amplitude: 0.0f, OVRInput.Controller.RTouch);
        }
    }
}
