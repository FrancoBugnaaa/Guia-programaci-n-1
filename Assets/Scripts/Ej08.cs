using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    //8. Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error &quot;El día ingresado no es válido&quot;.
    void Start()
    {
        switch (dia)
        {
            case 1:
                Debug.Log("Hoy es Domingo");
                break;
            case 2:
                Debug.Log("Hoy es Lunes");
                break;
            case 3:
                Debug.Log("Hoy es Martes");
                break;
            case 4:
                Debug.Log("Hoy es Miercoles");
                break;
            case 5:
                Debug.Log("Hoy es Jueves");
                break;
            case 6:
                Debug.Log("Hoy es Viernes");
                break;
            case 7:
                Debug.Log("Hoy es Sabado");
                break;
            default:
                Debug.Log("No es un día Posible");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
