using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsSound : MonoBehaviour
{
    public AudioSource FootSteps;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            FootSteps.enabled = true;
        }
        else
        {
            FootSteps.enabled = false;
        }
    }
}
