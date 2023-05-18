static class Equipos{
   public static List<string> ListaEquipos {get; private set;} = new List<string>(){"sacachispas", "moron", "olimpo", "sanLorenzo", "river", "racing", "chacarita","independiente","atlanta","velez" };
   public static List<string> ListaMedias {get; private set;} = new List<string>(){"sacachispas", "moron", "olimpo", "sanLorenzo", "river", "racing", "chacarita","independiente","atlanta","velez" };
   public static List<string> ListaPantalones {get; private set;}= new List<string>(){"sacachispas", "moron", "olimpo", "sanLorenzo", "river", "racing", "chacarita","independiente","atlanta","velez" };
   public static List<string> ListaRemeras {get; private set;}= new List<string>(){"sacachispas", "moron", "olimpo", "sanLorenzo", "river", "racing", "chacarita","independiente","atlanta","velez" };
   public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary <string, Indumentaria>();
    //metodos
    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item){
        if(EquiposIndumentaria.ContainsKey(EquipoSeleccionado)){
            return false; 
        }else{
            EquiposIndumentaria.Add(EquipoSeleccionado, item);
            return true;
        }
    }




}