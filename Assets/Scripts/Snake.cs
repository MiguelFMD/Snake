
public class Snake
{
    //Nuestros datos privados
    private SnakeNode Head;
    private SnakeNode Tail;
    private int count;

    public Snake() //constructor para CREAR una serpiente
    {
        SnakeNode newHead = new SnakeNode();
        Head = newHead;
        Tail = newHead;
    }

    public void Eat() //equivale a añadir
    {
        SnakeNode newNode = new SnakeNode();
        //Cuidado con NO asignar Tail antes de asignar el siguiente
        Tail.Next = newNode;
        Tail = newNode;
    }
}
