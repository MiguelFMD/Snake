using UnityEngine;

//Esta clase se encargará de la parte visual del mundo para cada nodo
public class SnakeNodeVisual : MonoBehaviour
{
    public SnakeNode snakeNode; //Referencia a nuestra logica del nodo
    public SnakeNodeVisual nextVisualNode; 

    public void MoveVisualNode()
    {
        transform.position = new Vector2(snakeNode.PosX, snakeNode.PosY);
        if(nextVisualNode != null) nextVisualNode.MoveVisualNode();
    }
}
