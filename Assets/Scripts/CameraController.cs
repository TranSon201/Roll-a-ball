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
        // Get Vector bằng khoảng cách giữa camera và player.
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Update camera luôn chạy theo vị trí của player
        transform.position = player.transform.position + offset;
    }
}
