using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float destroyTime;
    public float currentTime;

    private void Update()
    {
        move();
        DestroyFireball();
    }

    private void move()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void DestroyFireball()
    {
        currentTime += Time.deltaTime;
        
        if(currentTime >= destroyTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
