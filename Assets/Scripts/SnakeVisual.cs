using UnityEngine;

public class SnakeVisual : MonoBehaviour
{
    [SerializeField] private SnakeNodePool snakeNodePool; //<---Sistema de pool acoplado al SnakeVisual, mala práctica pero nos sirve para prototipos rápdidos
    private Snake snake;

    void Start()
    {
        snake = new Snake(transform.position.x, transform.position.y);
    }

    public void Eat()
    {
        SnakeNodeVisual newSnakeNodeVisual = snakeNodePool.RequestNode();
        SnakeNode newSnakeNode = new SnakeNode(null, snake.Tail.LastPosX, snake.Tail.LastPosY); //Asignamos la posicion inicial para el nodo
        newSnakeNodeVisual.snakeNode = newSnakeNode;
        snake.Eat(newSnakeNodeVisual.snakeNode);
    }

    public void Move()
    {
        
    }

}
