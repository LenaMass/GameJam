using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
<<<<<<< Updated upstream
            anim.Play("DoorOpen");
=======
            anim.SetTrigger("IsOpen");
>>>>>>> Stashed changes

        }
        
    }
}
