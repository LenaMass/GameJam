using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Vector3 TheSpawnPoint;
    [SerializeField] private GameObject player;
    private Rigidbody rb;

    private void Start()
    {
        rb = player.GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered Trigger");
            other.transform.position = TheSpawnPoint;

        }


    }
}
