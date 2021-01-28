using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCameraPosition : MonoBehaviour
{
    private GameObject player;
    private Transform playerTransform;
    public Transform cameraTransform;
    public float yOffset = 1.14f;
    public float zOffset = -4.39f;

    void Start()
    {
         player = GameObject.Find("Player");
         playerTransform = player.GetComponent<Transform>();
    }

    void Update()
    {
        cameraTransform.position = new Vector3(
            playerTransform.position.x,
            playerTransform.position.y + yOffset,
            playerTransform.position.z + zOffset
        );
    }
}
