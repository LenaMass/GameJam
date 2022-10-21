using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKey : MonoBehaviour
{
    public GameObject Text;
    public GameObject AnimObject;
    public GameObject Trigger;
    public SoundManager sm;

    public bool open = false; 
    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Text.SetActive(true);
            open = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
            Text.SetActive(false);
            open = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (open == true)
            {
                Text.SetActive(false);
                AnimObject.GetComponent<Animator>().Play("KitchenDoor");
                Trigger.SetActive(false);
                sm.PlayPreeskey2();


    open = false;
            }
        }
    }
}
