public class Usuario : Player{
    public int Pedirpocision(){
        Console.Write("Ingresa el valor de la pocision en x: ");
        string posx = Console.ReadLine();
        Console.Write("Ingresa el valor de la pocision en y: ");
        string posy = Console.ReadLine();
        int x = Int32.Parse(posx);
        int y = Int32.Parse(posy);
        return Insertar(x, y);
    }
}