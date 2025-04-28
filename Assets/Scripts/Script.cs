using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float kilos;
    public float kilometros;
    string vehiculo;
    float horasTotales;
    float kilometrosPorHora;
    float precioHora;
    float precioTotalHoras;
    bool aumento;

    // Start is called before the first frame update
    void Start()
    {
        if (kilos < 100)
        {
            Debug.Log("Error, no llega al peso minimo de carga");
            return;
        }

        if (kilometros < 1)
        {
            Debug.Log("Error, no llega a la distancia minima");
            return;
        }


        if (kilos < 2000 && kilos > 100)
        {
            vehiculo = "utilitario";
            precioHora = 3000;
            precioTotalHoras = kilometros * precioHora;
            Debug.Log($"El vehiculo que se necesita es {vehiculo}");
            kilometrosPorHora = 25;
            horasTotales = kilometros / kilometrosPorHora;
            Debug.Log($" y las horas totales son {horasTotales}");
            aumento = kilometros > 50;
            Debug.Log($"se cobra una hora extra por excederse {aumento}");
            return;
            
        }

        if (kilos < 5000 && kilos > 2000)
        {
            vehiculo = "pickup";
            precioHora = 4500;
            precioTotalHoras = kilometros * precioHora;
            Debug.Log($"El vehiculo que se necesita es {vehiculo}");
            kilometrosPorHora = 25;
            horasTotales = kilometros / kilometrosPorHora;
            Debug.Log($" y las horas totales son {horasTotales}");
            aumento = kilometros > 50;
            Debug.Log($"se cobra una hora extra por excederse {aumento}");
            return;

        }

        if (kilos < 10000 && kilos > 5000)
        {
            vehiculo = "camion";
            precioHora = 7000;
            precioTotalHoras = kilometros * precioHora;
            Debug.Log($"El vehiculo que se necesita es {vehiculo}");
            kilometrosPorHora = 25;
            horasTotales = kilometros / kilometrosPorHora;
            Debug.Log($" y las horas totales son {horasTotales}");
            aumento = kilometros > 50;
            Debug.Log($"se cobra una hora extra por excederse {aumento}");
            return;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
