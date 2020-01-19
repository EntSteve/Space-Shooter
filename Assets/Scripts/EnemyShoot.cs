using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject LaserPrefab;

    public float shootDelay = 0.25f;
    float cooldownTimer = 0;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer += shootDelay;
            Instantiate(LaserPrefab, transform.position, transform.rotation);
        }
    }
}
