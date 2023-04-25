using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; // distància inicial entre la càmera i el player

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset; // la càmera seguirà al jugador 
    }
}
