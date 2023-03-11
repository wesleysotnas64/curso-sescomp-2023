using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;

    public GameObject fireball;

    private void Update() {
        Joistyck();
    }

    private void Joistyck()
    {
        Vector2 direction = new Vector2(0, 0);

        if(Input.GetKey("w")) direction += Vector2.up;
        if(Input.GetKey("s")) direction += Vector2.down;
        if(Input.GetKey("a")) direction += Vector2.left;
        if(Input.GetKey("d")) direction += Vector2.right;

        if(Input.GetMouseButtonDown(0)) CastFireball();

        direction = (direction.normalized) * Time.deltaTime;
        direction *= speed;

        move(direction);
    }

    private void move(Vector2 vec)
    {
        transform.Translate(vec.x, vec.y, 0);
    }

    private void CastFireball()
    {
        GameObject fb = Instantiate(fireball, transform.position, transform.rotation);
        fb.GetComponent<Transform>().up = MouseDirection();
    }

    public Vector2 MouseDirection()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 newDirection = new Vector2
        (
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        return newDirection.normalized;
    }
}
