using UnityEngine;

public class SnakeVisual : MonoBehaviour
{
    private Snake snake;
    void Start()
    {
        snake = new Snake();
    }

    public void Eat()
    {
        snake.Eat();
        print(snake.SnakeLength());
    }

}
