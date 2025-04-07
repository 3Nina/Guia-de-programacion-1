using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    //Declaración de variables

    public float montoAConvertir;
    public string codigoMoneda;

    float cotizacionDolar = 1350.12f;
    float cotizacionEuro = 1622.4f;
    float cotizacionReal = 221.3f;

    float montoConvertido;
    float montoMinimo = 1000;  //Por convencion cuando se habla de dinero, se usa float

    float cotizacionMonedaElegida;

    void Start()
    {
        // Inreso y validación de datos
        if (montoAConvertir < montoMinimo)
        {
            Debug.Log("El monto mínimo es $1000");
            return; 
        }

        if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        } else if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        } else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = cotizacionReal;
        }
        else
        {
            Debug.Log("Opción de moneda extrangera no válida");
            return;
        }

        // Proceamientro datos

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //Salida datos

        Debug.Log("El monto ingresado equivale a " + montoConvertido);
    }

    void Update()
    {
        
    }
}
