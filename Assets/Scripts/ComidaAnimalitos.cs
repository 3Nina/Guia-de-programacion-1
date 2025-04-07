using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaAnimalitos : MonoBehaviour
{
    //1. Definición de variables
    public int cantDias;
    public string codAnimal;
    int gramosComidaTotal;

    int racionGatos = 300;
    int racionPerrosPeque = 400;
    int racionPerrosGrande = 700;
    int racionAnimalActual;

    float costoFinal;
    float precioPorCienGramos = 80;

    void Start()
    {
        //2. Ingreso de datos (más adelante)

        if (cantDias < 3)
        {
            Debug.Log("Cantidad de días no válida.");
            // aca se puede poner un return y sacar el else.
        }
        else
        {
            if(codAnimal == "G" || codAnimal == "g")   // == porque compara
            {
                racionAnimalActual = racionGatos;
            } else if (codAnimal == "PP")
            {
                racionAnimalActual = racionPerrosPeque;
            } else if (codAnimal == "PG")
            {
                racionAnimalActual = racionPerrosGrande;
            }
            else
            {
                Debug.Log("Código no válido.");
                return; // Interrumpe la ejecucion de la funcion y no ejecuta la linea de codigo siguiente.
            }

            //3. Procesamiento de datos

            gramosComidaTotal = racionAnimalActual * cantDias;
            costoFinal = gramosComidaTotal / 100 * precioPorCienGramos;

            //4. Mostrar el resultado

            Debug.Log("Para ese periodo se necesitan " + gramosComidaTotal + " gramos de alimento");
            Debug.Log("El costo de la cantidad de alimento es $ " + costoFinal);
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
