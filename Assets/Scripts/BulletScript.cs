using UnityEngine;
using UnityEngine.Rendering;

public class BulletScript : MonoBehaviour
{
private Rigidbody2D rb;
[SerializeField]
public float Speed;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = transform.right * Speed;
    }

     public void OnCollisionEnter2D(Collision2D collision)
        {
            
            if (collision.gameObject.tag == "Wall")
            {
            Destroy(gameObject);
            Debug.Log("Bullet Destroyed");
            }
            else if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy Damaged");
        }
        }
}
