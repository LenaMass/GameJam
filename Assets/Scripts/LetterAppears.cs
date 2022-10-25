using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterAppears : MonoBehaviour
{
    [SerializeField] private Image LetterImage;
    [SerializeField] private TextMeshProUGUI LetterText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            LetterImage.enabled = true;
            LetterText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            LetterImage.enabled = false;
            LetterText.enabled = false;
        }
    }
}
