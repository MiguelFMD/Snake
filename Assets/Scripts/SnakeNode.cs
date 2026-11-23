
public class SnakeNode
{
    private SnakeNode Next; //la siguiente parte de la serpiente
    public float PosX {get; private set;} //posicion actual del nodo
    public float PosY {get; private set;}
    public float LastPosX {get; private set;} //guardaremos la ultima posicion para añadir nodos a la cola al final
    public float LastPosY {get; private set;}
    public SnakeNode(SnakeNode next, float posX, float posY)
    {
        Next = next;
        PosX = posX;
        PosY = posY;
        LastPosX = posX;
        LastPosY = posY;
    }

    public void SetNext(SnakeNode newNext)
    {
        Next = newNext;
    }

    public void Move(float newPosX, float newPosY)
    {
        if(Next != null) Next.Move(PosX, PosY); //Cambiamos la posicion del siguiente por las del nodo actual
        LastPosX = PosX; //Actualizamos las ultimas posiciones
        LastPosY = PosY;
        PosX = newPosX; //Luego cambiamos a las nuevas posiciones que nos han pasado
        PosY = newPosY;
    }
}
