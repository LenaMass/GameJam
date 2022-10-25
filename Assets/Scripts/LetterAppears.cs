using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterAppears : MonoBehaviour
{
    [SerializeField] private Image LetterImage;
    [SerializeField] private TextMeshProUGUI LetterText;

    [SerializeField] private Image HintImage;
    [SerializeField] private TextMeshProUGUI HintText;

    void Update()
    {
        if(HintImage.enabled)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
               HintImage.enabled = false;
               HintText.enabled = false;
               LetterImage.enabled = true;
               LetterText.enabled = true;

            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
 
        if(other.CompareTag("Player"))
        {
            HintImage.enabled = true;
            HintText.enabled = true;


        }
        

        
           
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            HintImage.enabled = false;
            HintText.enabled = false;
            LetterImage.enabled = false;
            LetterText.enabled = false;
        }
    }


}
