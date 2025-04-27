using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaDeVacaciones : MonoBehaviour
{
    //1. Definición de variables
    public int cantJuveniles;
    public int cantInfantiles;

    int cantJuvenilPorProfesor = 20;
    int cantInfantilPorProfesor = 10;
    int cantProfesorPorCoordinador = 5;
    
    int profesoresInfantiles;
    int profesoresJuveniles;
    int coordinadores;
    int listaDeEspera;

    int profesoresTotal;
    int infantilesRestantes;
    int juvenilesRestantes;

    void Start()
    {
        //2. Ingreso de datos (más adelante)
        if ((cantJuveniles < 0 || cantJuveniles > 100) && (cantInfantiles < 0 || cantInfantiles > 100)){   // como en matematica, para que lo analice bien
            Debug.Log("Canidad de infantiles y juveniles no válida");  
            return;
        } else if (cantInfantiles < 0 || cantInfantiles > 100){
            Debug.Log("Cantidad de infantiles no válida");
            return;
        } else if (cantJuveniles < 0 || cantJuveniles > 100){
            Debug.Log("Cantidad de juveniles no válida");
            return;
        }
        
        //3. Procesamiento de datos
        profesoresJuveniles = cantJuveniles / cantJuvenilPorProfesor;
        juvenilesRestantes = cantJuveniles % cantInfantilPorProfesor;  // el % saca el resto de la division

        profesoresInfantiles = cantInfantiles / cantInfantilPorProfesor;
        infantilesRestantes = cantInfantiles % cantInfantilPorProfesor; 

        profesoresTotal = profesoresInfantiles + profesoresJuveniles;
        listaDeEspera = juvenilesRestantes + infantilesRestantes;

        coordinadores = profesoresTotal / cantProfesorPorCoordinador;
        if (profesoresTotal % 5 != 0){  // cuando el modulo 5 (resto) de los profesores totales es distinto a 0 (pueden haber mas profes sin llegar a 5 mas)
            coordinadores ++;  // se le agrega uno mas a los coordinadores.
        }

        //4. Mostrar el resultado
        Debug.Log("Se necesitan " + profesoresJuveniles + " profesores para los inscriptos juveniles.");
        Debug.Log("Se necesitan " + profesoresInfantiles + " profesores para los inscriptos infantiles.");
        Debug.Log("Se necesitan " + coordinadores + " coordinadores.");
        Debug.Log("Van a haber " + listaDeEspera + " personas en la lista de espera.");
    }

    
    void Update()
    {
        
    }
}
