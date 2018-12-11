using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : EnemyBase
{
    public Transform Firepoint;

    public GameObject Projectile;
    
    // Use this for initialization
    protected override void Start()
    {
        base.Start();

        InvokeRepeating("Shoot", 1f, 2.5f);
    }

    protected override void Update()
    {
        base.Update();
    }

    void Shoot()
    {
        Instantiate(Projectile, Firepoint.position, Firepoint.rotation);

        SoundManagerScript.PlaySound("EnemyLaser");
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            HP--;

            StartCoroutine(Flash());

            SoundManagerScript.PlaySound("Hurt");
        }

        if (HP < 1)
        {
            Destroy(Enemy);

            Score.scoreValue += 6;
        }
    }
}
