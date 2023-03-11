using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public GameObject player;

    void Update()
    {
        player = GameObject.Find("Player");
        move(PlayerDirection());
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
        Destroy(gameObject);
    }
}
