using UnityEngine;

//Esta clase se encargará de la parte visual del mundo para cada nodo
public class SnakeNodeVisual : MonoBehaviour
{
    public SnakeNode snakeNode; //Referencia a nuestra logica del nodo
    private SnakeNodeVisual nextVisualNode; 
    
    public void MoveNode(Vector2 newPosition)
    {
        transform.position = newPosition;
        snakeNode.Move(transform.position.x, transform.position.y);
    }
}
