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

    public AudioClip shootAudioClip;
    public AudioClip explotionPlayerAudioClip;


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

        AudioSource.PlayClipAtPoint(shootAudioClip, transform.position, 0.7f);
    }
    
    public void Damage(float amount)
    {
        currentHp -= amount;

            if (currentHp <= 0f)
            {
                Dead();
            }
    }

    private void Dead()
    {
        FindObjectOfType<GameManager>().gameOver();
        Destroy(this.gameObject);
        AudioSource.PlayClipAtPoint(explotionPlayerAudioClip, transform.position, 0.7f);
        

    }

}

