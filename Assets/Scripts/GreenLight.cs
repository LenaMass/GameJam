using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLight : MonoBehaviour
{
    [SerializeField] private GameObject Room;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Green"))
        {
            Room.GetComponent<Light>().enabled = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Green"))
        {
            Room.GetComponent<Light>().enabled = false;
        }
    }
}

