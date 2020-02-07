using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        // Tạo hiệu ứng xoay cho pickups
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime);
    }
}
