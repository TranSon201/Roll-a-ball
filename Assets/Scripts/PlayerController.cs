using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    private Rigidbody rd;
    private int count ;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }
    void FixedUpdate()
    {
        // Tạo di chuyển cho player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rd.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        // Khi player va chạm pickup sẽ tắt hoạt động pickup
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        // Hiển thị số pickup đã ăn 
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = " You Win ";
        }
    }
}
