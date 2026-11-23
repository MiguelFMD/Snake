using System.Collections.Generic;
using UnityEngine;

public class SnakeNodePool : MonoBehaviour
{
    [SerializeField] private GameObject snakeNodePrefab; //El prefab que vamos a instanciar
    private Queue<SnakeNodeVisual> snakeNodePool = new Queue<SnakeNodeVisual>(); //Nuestra cola de nodos
    private Transform snakeNodeInstances;

    void Awake()
    {
        snakeNodeInstances = GetComponent<Transform>();
        foreach(Transform snakeNode in snakeNodeInstances)
        {
            ReturnNode(snakeNode.GetComponent<SnakeNodeVisual>());
        }
    }

    //Sacar nodo: Si no hay ninguno disponible, se instancia uno
    public SnakeNodeVisual RequestNode()
    {
        if(snakeNodePool.Count > 0) //Si hay nodos disponibles lo sacamos
        {
            SnakeNodeVisual newSnakeNode = snakeNodePool.Dequeue(); //Sacamos el primero disponible de la cola
            newSnakeNode.gameObject.SetActive(true);
            newSnakeNode.transform.SetParent(null);
            return newSnakeNode;
        }
        else
        {
            GameObject snakeNodeInstance = Instantiate(snakeNodePrefab);
            SnakeNodeVisual newSnakeNode = snakeNodeInstance.GetComponent<SnakeNodeVisual>();
            return newSnakeNode;
        }
    }

    public void ReturnNode(SnakeNodeVisual snakeNodeToReturn) //Equivalente a encolar para nuestra pool
    {
        snakeNodeToReturn.gameObject.SetActive(false);
        snakeNodePool.Enqueue(snakeNodeToReturn);
        snakeNodeInstances.transform.SetParent(snakeNodeInstances);
    }
    
}
