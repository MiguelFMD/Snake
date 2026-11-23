using UnityEngine;

public class SnakeVisual : MonoBehaviour
{
    [SerializeField] private SnakeNodePool snakeNodePool; //<---Sistema de pool acoplado al SnakeVisual, mala práctica pero nos sirve para prototipos rápdidos
    private Snake snake;
    private SnakeNodeVisual head;
    private SnakeNodeVisual currentNode;

    void Start()
    {
        snake = new Snake(transform.position.x, transform.position.y);
        head = GetComponent<SnakeNodeVisual>();
        head.snakeNode = snake.Head;
        currentNode = head;
    }

    public void Eat()
    {
        SnakeNodeVisual newSnakeNodeVisual = snakeNodePool.RequestNode();
        if(newSnakeNodeVisual == null) return;  //Si no hay nodos disponibles, no hacemos nada
        SnakeNode newSnakeNode = new SnakeNode(null, snake.Tail.LastPosX, snake.Tail.LastPosY); //Asignamos la posicion inicial para el nodo
        newSnakeNodeVisual.snakeNode = newSnakeNode;
        newSnakeNodeVisual.MoveVisualNode();
        snake.Eat(newSnakeNodeVisual.snakeNode);
        currentNode.nextVisualNode = newSnakeNodeVisual;
        currentNode = newSnakeNodeVisual;
    }

    public void Move()
    {
        snake.MoveHead(transform.position.x, transform.position.y);
        head.MoveVisualNode();
    }

}
