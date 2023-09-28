using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D player;
    [SerializeField] GameObject fireball;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "item")
        {
            Debug.Log("�t�@�C�A�[�A�C�e�����擾����");
            
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "item")
                {
            Debug.Log("�t�@�C�A�[�A�C�e�����擾����");
        }
    }
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = new Vector2(3, player.velocity.y);
            /*transform.position = transform.position + new Vector3(0.1f, 0, 0);

            transform.localScale = new Vector3 (1, 1, 1);*/
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocity = new Vector2(-3,player.velocity.y);
            /*transform.position = transform.position + new Vector3(-0.1f, 0, 0);

            transform.localScale = new Vector3(-1, 1, 1);*/
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.velocity += new Vector2(0,3);
            //transform.position = transform.position + new Vector3(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(fireball,transform.position,Quaternion.identity);
        }

    }
}
