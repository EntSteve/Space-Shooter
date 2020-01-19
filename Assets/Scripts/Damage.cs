using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int hp = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp--;
        if (hp == 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
