using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LS : MonoBehaviour
{

    //  private void OnTriggerEnter(Collider other)
    //  {
    //     if (other.gameObject.CompareTag("Sea"))
    //    {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    }
    //   }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
            SceneManager.LoadScene("ScientistRoom");
 
        //   SceneManager.LoadScene("level2");
    }
}