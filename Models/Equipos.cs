static class Equipos{
   public static List<string> ListaEquipos {get; private set;} = new List<string>(){"Sacachispas", "Deportivo Moron", "Olimpo", "San Lorenzo", "River", "Racing", "Chacarita","Independiente","Atlanta","Velez" };
   public static List<string> ListaMedias {get; private set;} = new 
   public static List<string> ListaPantalones {get; private set;}
   public static List<string> ListaRemeras {get; private set;}
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