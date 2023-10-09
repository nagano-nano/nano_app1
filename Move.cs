using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject bloodEffect;
    Animator m_Animator;
    public WallPower wallpower;
    bool move;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {

            if (wallpower.viblattion == true)
            {
                move = true;
                m_Animator.SetBool("Move", move);
                bloodEffect.SetActive(false);
            }
        }
        if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))
        {
            if (move == true)
            {
                {
                    move = false;
                    m_Animator.SetBool("Move", move);
                    bloodEffect.SetActive(true);
                }
            }
        }

    }
}
