using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHp = 100;
    private float currentHp;
    public float timeBetweenShoots = 0.5f;
    public GameObject bulletPrefab;
    public Transform bulletOrigin;
    public float timeOfLastShoot;


    // Start is called before the first frame update
    private void Start()
    {
        currentHp = maxHp;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > timeOfLastShoot + timeBetweenShoots)
                shoot();
            
        }
    }

    private void shoot()
    {
        Instantiate(bulletPrefab, bulletOrigin.position, bulletOrigin.rotation);
        timeOfLastShoot = Time.time;
    }
    
    public void Damage(float amount)
    {
        currentHp -= amount;

            if (currentHp <= 0f)
            {
                Debug.Log("Game Over");
                Destroy(this.gameObject);

            }
    }

}

