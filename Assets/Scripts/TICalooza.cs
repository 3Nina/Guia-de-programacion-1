using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICalooza : MonoBehaviour
{
    //1. Definición de variables
    public int cantEntradasCampo;
    public int cantEntradasPlatea;

    int cantEntradasTotal;
    int entradasSinVender;

    float precioEntradasCampo = 1200f;
    float precioEntradasPlatea = 2000f;

    int capacidadMaxTotal = 36600;
    int capacidadMaxCampo = 20400;
    int capacidadMaxPlatea = 16200;

    float plataRecaudadaCampo;
    float plataRecaudadaPlatea;
    float plataRecaudadaTotal;

    void Start()
    {
        //2. Ingreso de datos (más adelante)
        if ((cantEntradasCampo > capacidadMaxCampo || cantEntradasCampo < 0) && (cantEntradasPlatea > capacidadMaxPlatea || cantEntradasPlatea < 0)){
            Debug.Log("Cantidad de entradas vendiadas no válida");
            return;
        } else if (cantEntradasCampo > capacidadMaxCampo || cantEntradasCampo < 0){
            Debug.Log("Cantidad de entradas de campo no válida");
            return;
        } else if (cantEntradasPlatea > capacidadMaxPlatea || cantEntradasPlatea < 0){
            Debug.Log("Cantidad de entradas de paletea no válida");
            return;
        }

        //3. Procesamiento de datos
        plataRecaudadaCampo = cantEntradasCampo * precioEntradasCampo;
        plataRecaudadaPlatea = cantEntradasPlatea * precioEntradasPlatea;
        plataRecaudadaTotal = plataRecaudadaCampo + plataRecaudadaPlatea;

        cantEntradasTotal = cantEntradasCampo + cantEntradasPlatea;
        entradasSinVender = capacidadMaxTotal - cantEntradasTotal;

        //4. Mostrar el resultado
        Debug.Log("Con el campo se recaudaron $" + plataRecaudadaCampo);
        Debug.Log("En platea se recaudaron $" + plataRecaudadaPlatea);
        Debug.Log("En total se recaudaron $" + plataRecaudadaTotal);

        if (cantEntradasTotal == capacidadMaxTotal){
            Debug.Log("Sold Out!");
        } else {
            Debug.Log("Entradas no vendidas: " + entradasSinVender);
        }

        if (cantEntradasTotal > capacidadMaxTotal / 2){
            Debug.Log("El festival fué un éxito!");
        } else {
            Debug.Log("Debemos mejorar la convocatoria");
        }
        
    }

    
    void Update()
    {
        
    }
}
