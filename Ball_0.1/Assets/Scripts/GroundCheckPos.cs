using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckPos : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;
    private Vector3 rotation;

    private void Awake()
    {
        if (player != null)
            player = FindObjectOfType<BallController2>().transform;
    }

    private void Update()
    {
        if (player != null)
        {
            pos = player.position;
            pos.y = pos.y - 0.44f;
            transform.position = pos;

            rotation = transform.rotation.eulerAngles;
            rotation.z = 0;
            transform.rotation = Quaternion.Euler(rotation);
        }

    }
}
