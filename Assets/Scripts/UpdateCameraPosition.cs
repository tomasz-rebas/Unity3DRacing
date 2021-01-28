using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCameraPosition : MonoBehaviour
{
    private GameObject player;
    private Transform playerTransform;
    public Transform cameraTransform;
    public Vector3 offset = new Vector3(0, 1f, -5f);

    void Start()
    {
         player = GameObject.Find("Player");
         playerTransform = player.GetComponent<Transform>();
    }

    void Update()
    {
        cameraTransform.position = playerTransform.position + offset;
    }
}
