using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float jump;
    Rigidbody2D rb;
    public ProyectilControl ProyectilPrefab;
    public Transform LaunchOffset;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        var movimiento = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movimiento, 0, 0) * Time.deltaTime * speed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProyectilPrefab, LaunchOffset.position, LaunchOffset.transform.rotation);
        }
    }
}
