
public class Snake
{
    //Nuestros datos privados
    private SnakeNode Head;
    private SnakeNode Tail;
    private int length;

    public Snake() //constructor para CREAR una serpiente
    {
        SnakeNode newHead = new SnakeNode();
        Head = newHead;
        Tail = newHead;
        length = 1;
    }

    public void Eat() //equivale a añadir
    {
        SnakeNode newNode = new SnakeNode();
        //Cuidado con NO asignar Tail antes de asignar el siguiente
        Tail.Next = newNode;
        Tail = newNode;
        length++;
    }

    public int SnakeLength()
    {
        return length;
    }
}
