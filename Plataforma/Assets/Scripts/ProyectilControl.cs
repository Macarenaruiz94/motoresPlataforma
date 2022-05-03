using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilControl : MonoBehaviour
{
    public float speed = 4;

    
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag("Enemigo"))
        {
            SendMessage("Hit");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
