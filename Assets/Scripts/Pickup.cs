using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [Header("Pickup Settings")]
    [SerializeField] Transform holdArea;
    private GameObject heldobj;
    private Rigidbody rb; 

    [Header("Physics Parameters")]
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;
 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldobj == null)
            {
                RaycastHit hit;
                if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,pickupRange))
                {
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }
        if (heldobj != null)
        {
            MoveObject();
        }
    }

    void MoveObject()
    {
        if(Vector3.Distance(heldobj.transform.position,holdArea.position) > 0.1f)
        {
            Vector3 movDirection = (holdArea.position - heldobj.transform.position);
            rb.AddForce(movDirection * pickupForce);
        }
    }
    void PickupObject(GameObject pickobj)
    {
        if (pickobj.GetComponent<Rigidbody>())
        {
            rb = pickobj.GetComponent<Rigidbody>();
            rb.useGravity = false;
            rb.drag = 10;
            rb.constraints = RigidbodyConstraints.FreezeRotation;

            rb.transform.parent = holdArea;
            heldobj = pickobj;
                
        }
    }
    void DropObject()
    {
            rb.useGravity = true;
            rb.drag = -1;
            rb.constraints = RigidbodyConstraints.None;

            heldobj.transform.parent = null;
            heldobj = null;
    }
}

