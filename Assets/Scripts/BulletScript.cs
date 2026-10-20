using IndieMarc.TopDown;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletScript : MonoBehaviour
{
private Rigidbody2D rb;
[SerializeField]
public float Speed;
public PlayerCharacter PlayerCharacterScript; 
public Vector3 BulletDirection; 
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       PlayerCharacterScript = GameObject.Find("CharacterTopDown").GetComponent<PlayerCharacter>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(BulletDirection.x, BulletDirection.y, 0) * Speed;
        Debug.Log("Bullet Direction" + BulletDirection);
        Debug.Log("Bullet Velocity" + rb.linearVelocity);
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
