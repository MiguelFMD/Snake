

public class Snake
{
    //Nuestros datos privados
    public SnakeNode Head {get; private set;}
    public SnakeNode Tail {get; private set;}
    private int length;

    public Snake(float posX, float posY) //constructor para CREAR una serpiente
    {
        SnakeNode newHead = new SnakeNode(null, posX, posY);
        Head = newHead;
        Tail = newHead;
        length = 1;
    }

    public void Eat(SnakeNode newNode) //equivale a añadir
    {
        //Cuidado con NO asignar Tail antes de asignar el siguiente
        Tail.SetNext(newNode);
        Tail = newNode;
        length++;
    }

    public void MoveHead(float posX, float posY)
    {
        if(Head != null) Head.Move(posX, posY);
    }

    public int SnakeLength()
    {
        return length;
    }
}
