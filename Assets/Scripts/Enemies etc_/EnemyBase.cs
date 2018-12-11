using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class EnemyBase : MonoBehaviour
{
    public float moveSpeed;

    public int HP;

    Player Player1;

    public GameObject Enemy;

    // Feedback
    SpriteRenderer rend;
    public Color colorToTurnTo;
    Color normalColor = Color.white;

    // Use this for initialization
    protected virtual void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        Player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime, Space.World);

        if (transform.position.x < -10)
        {
            Player1.HP -= 1;

            SoundManagerScript.PlaySound("Hurt");

            Destroy(Enemy);
        }
    }
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            StartCoroutine(Flash());

            Destroy(Enemy);

            SoundManagerScript.PlaySound("Hurt");
        }
    }

    public IEnumerator Flash()
    {
        rend.material.color = colorToTurnTo;

        yield return new WaitForSeconds(0.15f);

        rend.material.color = normalColor;
    }
}
