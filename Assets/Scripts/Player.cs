using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 1;
    public Rigidbody2D rb;
    public GameObject wall;
    public SpriteRenderer s;

    public GameObject sL1;
    public GameObject sL2;
    public GameObject sL3;
    public GameObject sL4;
    public GameObject sL5;
    public GameObject sL6;
    public GameObject sL7;
    public GameObject sL8;
    public GameObject sL9;
    public GameObject sL10;
    public GameObject sL11;
    public GameObject sL12;
    public GameObject sL13;
    public GameObject sL14;
    public GameObject sL15;
    public GameObject sL16;
    public GameObject sL17;
    public GameObject sL18;
    public GameObject sL19;
    public GameObject sL20;
    public GameObject sL21;
    public GameObject sL22;

    public GameObject sR1;
    public GameObject sR2;
    public GameObject sR3;
    public GameObject sR4;
    public GameObject sR5;
    public GameObject sR6;
    public GameObject sR7;
    public GameObject sR8;
    public GameObject sR9;
    public GameObject sR10;
    public GameObject sR11;
    public GameObject sR12;
    public GameObject sR13;
    public GameObject sR14;
    public GameObject sR15;
    public GameObject sR16;
    public GameObject sR17;
    public GameObject sR18;
    public GameObject sR19;
    public GameObject sR20;
    public GameObject sR21;
    public GameObject sR22;

    private bool isFlip = false;

    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(isFlip)
            {
                rb.velocity = (Vector2.up + Vector2.left) * velocity;
            } else
            {
                rb.velocity = (Vector2.up + Vector2.right) * velocity;
            }
            
        }
     
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            if (isFlip)
            {
                s.flipX = false;
                isFlip = false;
                GenerateSpikes("left");
            } else
            {
                s.flipX = true;
                isFlip = true;
                GenerateSpikes("right");
            }
            Debug.Log("Collision with wall");
        }
    }

    public void GenerateSpikes(string side)
    {
        if(side == "right")
        {
            // wsun wszystkie kolce ktore sa
            GameObject[] allLeftSpikes = GameObject.FindGameObjectsWithTag("Spike_L");
            foreach(GameObject go in allLeftSpikes)
            {

                go.transform.Translate()
            }

            // najpierw wylosuj ilosc kolcow na scianie
            for (int i = 0; i < Random.Range(4, 12); i++)
            {
                // teraz wylosuj ktore kolce sie wysuwaja
                string n = Random.Range(1, 22).ToString();
                string spike = "Spike_L" + n;

                GameObject.Find(spike).transform.position = new Vector3(-2.19f, transform.position.y, transform.position.z);

                Debug.Log("GenerateSpikes ("+side+"): " + spike);

            }
        }
    }


}
