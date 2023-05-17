using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_4.Models;

namespace TP_4.Controllers;

public class IndumentariaController : Controller
{
    public IActionResult Index()
    {
        ViewBag.IndumentariaEquipos=induEquipos;
        //Cargar en un ViewBag el diccionario de Indumentarias Equipos
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.lEquipos = Equipos.ListaEquipos;
        ViewBag.lMedias = Equipos.ListaMedias;
        ViewBag.lPantalones = Equipos.ListaPantalones;
        ViewBag.lRemeras = Equipos.ListaRemeras;

        //Cargar las listas de la clase Equipos en ViewBags para poder ser invocados en la View.
        return View();
    }

    public IActionResult GuardarIndumentaria ()
    {
        /*Debe validar que reciba todos los parámetros requeridos.
        Carga en un objeto indumentaria la info enviada como parámetro.
        Carga la indumentaria con el equipo en la clase Equipos
        En caso que no se hayan recibido los parámetros correctamente vuelve a la view SelectIndumentaria enviando un Mensaje de Error (utilizar ViewBag), en caso contrario vuelve a la pagina Index (Volver a Cargar los ViewBags con las listas de datos.*/
        
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
