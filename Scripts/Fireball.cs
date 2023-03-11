using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;

    void Update()
    {
        move();
    }

    private void move()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
