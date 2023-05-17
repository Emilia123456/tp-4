static class Equipos{
    List<string> ListaEquipos {get; private set;} = new List<string>("Sacachispas", "Deportivo Moron", "Olimpo", "San Lorenzo", "River", "Racing", "Chacarita","Independiente","Atlanta","Velez" );
    List<string> ListaMedias {get; private set;}
    List<string> ListaPantalones {get; private set;}
    List<string> ListaRemeras {get; private set;}
    Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary <string, Indumentaria>();
    //metodos
    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item){
        if(EquiposIndumentaria.ContainsKey(EquipoSeleccionado)){
            return false; 
        }else{
            dicEquiposIndumentaria.Add(EquipoSeleccionado, item);
            return true;
        }
    }
}