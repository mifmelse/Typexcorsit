using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCintrillir : MonoBehaviour
{
    private GameObject[] wadah;
    private GameObject player;
    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    void Start()
    {
        wadah = GameObject.FindGameObjectsWithTag("Player");
        player = wadah[0];
        _cameraOffset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPos = player.transform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer)
        {
            transform.LookAt(player.transform);
        }
    }
}
