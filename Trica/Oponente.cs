public class Oponente : Player{
    Random random = new Random();
    public int Obtenerpocision(){
        int x = random.Next(1,3);
        int y = random.Next(1,3);
        return Insertar(x, y);
    }
}