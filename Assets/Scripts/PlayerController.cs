using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Transform particleEffect;
    public Transform particleEffect2;
    private Rigidbody rd;
    private Vector3 rb;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        particleEffect2.transform.position = transform.position;
        // Tạo di chuyển cho player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rd.AddForce(movement * speed);
    }
    void OnCollisionEnter(Collision other)
    {
        // Khi player va chạm wall tao hieu ung
        if (other.gameObject.CompareTag("Wall"))
        {
            Vector3 particlePos = new Vector3(transform.position.x, transform.position.y + 0.3f,transform.position.z);
            Instantiate(particleEffect, particlePos, Quaternion.identity);
         
        }
    }
}
