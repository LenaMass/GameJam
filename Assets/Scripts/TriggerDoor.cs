using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    //private Animator _animator;

    [SerializeField] private Animator Anim;
    //[SerializeField] private Animator DoorAnim2;
     public SoundManager sm;

    void Start()
    {
        //_animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {

            //other.gameObject.GetComponent<PlayerMovement>().key--;
            sm.PlayShelfmovement();
            this.GetComponent<Animator>().SetTrigger("IsOpenning");
            // DoorAnim.SetTrigger("IsOpenning2");
            // DoorAnim.SetInteger("CollectKeys",2) ;
        }
    }
}