using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public GameObject player;

    private void Start() {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        move(PlayerDirection());
        FlipSprite();
    }

    private Vector2 PlayerDirection()
    {
        Vector2 playerPosition = player.GetComponent<Transform>().position;
        Vector2 enemyPosition  = transform.position;

        Vector2 direction = (playerPosition - enemyPosition).normalized;

        direction *= speed * Time.deltaTime;

        return direction;
    }

    private void move(Vector2 vec)
    {
        transform.Translate(vec.x, vec.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        GameObject.Find("MainCamera").GetComponent<GameplayController>().ToScore();
        Destroy(gameObject);
    }

    private void FlipSprite()
    {
        float xDirection  = PlayerDirection().x;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (xDirection < 0) sr.flipX = false;
        else sr.flipX = true;
    }
}
