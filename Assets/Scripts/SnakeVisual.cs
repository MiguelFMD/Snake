using UnityEngine;

public class SnakeVisual : MonoBehaviour
{
    [SerializeField] private SnakeNodePool snakeNodePool; //<---Sistema de pool acoplado al SnakeVisual, mala práctica pero nos sirve para prototipos rápdidos
    private Snake snake;

    void Start()
    {
        snake = new Snake();
    }

    public void Eat()
    {
        snake.Eat();
        snakeNodePool.RequestNode().transform.SetParent(this.transform);
    }

}
