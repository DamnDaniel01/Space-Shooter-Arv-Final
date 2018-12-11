using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : EnemyBase
{
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

            Score.scoreValue += 4;
        }
    }
}
