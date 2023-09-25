using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text m_countText;
    private int m_count;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        ++m_count;
        SetCountText();
    }
    private void SetCountText()
    {
        m_countText.text = "Count: " + m_count.ToString();
    }
}