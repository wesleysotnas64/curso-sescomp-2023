using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;

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

        direction = (direction.normalized) * Time.deltaTime;
        direction *= speed;

        move(direction);
    }

    private void move(Vector2 vec)
    {
        transform.Translate(vec.x, vec.y, 0);
    }
}
