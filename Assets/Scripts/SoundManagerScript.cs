using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip fireSound, hitSound, enemyFireSound;

    static AudioSource audioSrc;


    // Use this for initialization
    void Start()
    {
        fireSound = Resources.Load<AudioClip>("Star Wars Laser");

        hitSound = Resources.Load<AudioClip>("Hurt");

        enemyFireSound = Resources.Load<AudioClip>("EnemyLaser");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Star Wars Laser":
                audioSrc.PlayOneShot(fireSound);
                break;

            case "Hurt":
                audioSrc.PlayOneShot(hitSound);
                break;

            case "EnemyLaser":
                audioSrc.PlayOneShot(enemyFireSound);
                break;
        }
    }
}
