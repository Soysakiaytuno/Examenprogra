using System.ComponentModel;

public class Juego{
    bool turno;
    Usuario jugador = new Usuario();
    Oponente cpu = new Oponente();
    bool victoria;
    List<string> Trica = [" []"," []"," []", " []", " []"," []"," []"," []"," []"];
    public void Iniciojuego(){
        turno = true;
        victoria = false;
        while(!victoria){
            if(turno){
            Mostrarjuego();
            int posuser = jugador.Pedirpocision();
            if(Trica[posuser] == " []"){
                Trica[posuser] = xo();
            victoria = Victoria();
            if(Empate()){
                victoria = true;
            }
            turno = false;
            }
            else{
                Console.WriteLine("Valor invalido envie otro");
            }
            }
            else if(!turno){
                Mostrarjuego();
                int poscpu = cpu.Obtenerpocision();
                if(Trica[poscpu] == " []"){
                    Trica[cpu.Obtenerpocision()] = xo();
                    victoria = Victoria();
                    turno = true;
                    if(Empate()){
                        victoria = true;
                    }
                }   
            }
        }
        Ganador();
    }
    public void Ganador(){
        if(Empate() && !Victoria()){
            Console.WriteLine("EMPATE");
        }
        else if(turno && !Empate()){
            Console.WriteLine("GANASTE");
        }
        else if(!turno && !Empate()){
            Console.WriteLine("Perdiste");
        }
    }
    public string xo(){
        if(turno){
            return "x";
        }
        else{
            return "o";
        }
    }
    public void Mostrarjuego(){
        for(int i = 0; i < 9; i++){
            if(i == 3 || i == 6){
                Console.WriteLine();
            }
            Console.Write(Trica[i]);
        }
        Console.WriteLine();
    }
    public bool Empate(){
        for(int i = 0; i < 9; i++){
            if(Trica[i] == " []"){
                return false;
            }
        }
        return true;
    }
    public bool Victoria(){
        for(int i = 0; i < 3; i++){
            if(Trica[i] == Trica[i+1] && Trica[i+1] == Trica[i+2] && Trica[i] != " []"){
                return true;
            }
        }
        for(int i = 3; i < 6; i++){
            if(Trica[i] == Trica[i+1] && Trica[i+1] == Trica[i+2] && Trica[i] != " []"){
                return true;
            }
        }
        for(int i = 6; i < 9; i++){
            if(Trica[i] == Trica[i+1] && Trica[i+1] == Trica[i+2] && Trica[i] != " []"){
                return true;
            }
        }
        if(Trica [0] == Trica[4] && Trica[4] == Trica[8] && Trica[0] != " []"){
            return true;
        }
        if(Trica [2] == Trica[4] && Trica[4] == Trica[6] && Trica[0] != " []"){
            return true;
        }
        if(Trica [0] == Trica[3] && Trica[3] == Trica[6] && Trica[0] != " []"){
            return true;
        }
        if(Trica [1] == Trica[4] && Trica[4] == Trica[7] && Trica[1] != " []"){
            return true;
        }
        if(Trica [2] == Trica[5] && Trica[5] == Trica[8] && Trica[2] != " []"){
            return true;
        }
        return false;
    }
}