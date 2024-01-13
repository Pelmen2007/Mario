using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float damage;

    private int hilka = 3;





    void Start()
    {
        
    }

      void Update()
    {
        if (hilka <= 0)
        {
            gameObject.SetActive(false);        
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            
        }
        if (collision.tag == "Bullet")
        {
            hilka -= 1;
        }
    }
}
