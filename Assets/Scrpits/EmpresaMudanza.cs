using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaMudanza : MonoBehaviour
{
    public float CantidadCarga;
    public float DistanciaKilometros;
    
    
    int HorasTotal;
    int DistanciaMinima = 1;
    int CantidadMenor = 100;

    int HoraMInimaPorVehiculo = 2;

    int HoraVehiculo = 1;
    int KilometrosHora = 25;

    float CapacidadMaximaUtilitario = 2000;
    float CapacidadMaximaPickup = 5000;
    float CapacidadMaximaCamion = 10000;

    float PrecioHoraUtilitario = 3000;
    float PrecioHoraPickup = 4500;
    float PrecioHoraCamion = 7000;

    int HoraExtra;
    float PrecioTotal;

    // Start is called before the first frame update
    void Start()
    {
        if (CantidadCarga < CantidadMenor)
        {
            Debug.Log("La cantidad minima a cargar es " + CantidadMenor + "Kg");
            return;
        }

        if (DistanciaKilometros < DistanciaMinima)
        {
            Debug.Log("La distancia minima para llevar la carga es de " + DistanciaMinima + " Km");
            return;
        }

   

        if (CantidadCarga > CapacidadMaximaCamion)
        {
            Debug.Log("No se puede llevar es cantidad");
        }

        KilometrosHora = HoraVehiculo;

            
        if(CantidadCarga <= 2000)
        {
            Debug.Log("El vehiculo devbe ser utilitario $3000");
            return;
        }

        if (CantidadCarga <= 5000)
        {
            Debug.Log("El vehiculo devbe ser PickUp y el precio total por hora es $4500");

            return;
        }

        if (CantidadCarga <= 10000)
        {
            Debug.Log("El vehiculo devbe ser Camion con  $7000");
            return;
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
