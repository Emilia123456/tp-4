static class Equipos{
    List<string> ListaEquipos {get; private set;} = new List<string>("Sacachispas", "Deportivo Moron", "Villa Mitre", "San Lorenzo", "River", "Racing", "Chacarita","Independiente","Atlanta","Velez" );
    List<string> ListaMedias {get; private set;}
    List<string> ListaPantalones {get; private set;}
    List<string> ListaRemeras {get; private set;}
    Dictionary<string, indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary <string, Indumentaria>();
    //metodos
    public bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item){
        if(EquiposIn)
        dicEquiposIndumentaria.Add(EquipoSeleccionado, item);

    }
   
}