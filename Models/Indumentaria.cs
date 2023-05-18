class Indumentaria {
    //propiedades
    public string Medias {get; private set;}
    public string Pantalon {get; private set;}
    public string Camiseta {get; private set;}
    // constructor vacio
    public Indumentaria(){
    }
    //constructor
    public  void indumentaria(string medias, string pantalon, string camiseta){

        Medias=medias;
        Pantalon=pantalon; 
        Camiseta=camiseta; 

    }
    

}
