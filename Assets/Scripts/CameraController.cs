using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 cameraOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = new Vector3(0, 60, -30);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
