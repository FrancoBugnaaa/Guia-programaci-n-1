﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej10 : MonoBehaviour
{
    // Start is called before the first frame update
    //10. Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar un  programa que informe si un estacionamiento se encuentra o no abierto según la hora  ingresada por el usuario.  
    //Nosotros sabemos que el estacionamiento se encuentra abierto entre las 10 y las 18hs. (Crear constante HORA_APERTURA = 10, y HORA_CIERRE = 18).  
    //Al iniciar el programa, se tomará como hora actual el valor de una variable expuesta en el Inspector, y deberemos setear una  variable booleana llamada estaAbierto en true o false, según corresponda, e informar por  pantalla mediante la misma si el estacionamiento se encuentra abierto o no.Obs: En el caso de que el valor de la variable correspona a una hora menor a 0 o mayor a 24, mostrar el  mensaje: “Ha ingresado una hora incorrecta” 

    public const int HoraApertura = 10;
    public const int HoraCierre = 18;
    public int HoraActual;
    public bool estaAbierto;

    void Start()
    {
       if (HoraActual > 24 || HoraActual < 0) { Debug.Log("Ha ingresado una hora erronea"); }
       if (HoraActual < HoraApertura || HoraActual > HoraCierre)
        {
            estaAbierto = false;
                Debug.Log("Estacionamineto abierto: " + estaAbierto);
        }         
       else
        {
            estaAbierto = true;
            Debug.Log("Estacionamiento abierto: " + estaAbierto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
