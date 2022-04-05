using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public string persona1;
    public string persona2;
    public string persona3;
    public float capitalaportado1;
    public float capitalaportado2;
    public float capitalaportado3;
    float montototalaportado;
    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    // Start is called before the first frame update
    void Start()
    {
        montototalaportado = (capitalaportado1 + capitalaportado2 + capitalaportado3);
        porcentaje1 = (capitalaportado1 * 100 / montototalaportado);
        porcentaje2 = (capitalaportado2 * 100 / montototalaportado);
        porcentaje3= (capitalaportado3 * 100 / montototalaportado);
        Debug.Log(persona1 + ":" + " aporto " + "$" + capitalaportado1 + " el porcentaje del total que aporto es " + porcentaje1 + " el monto total aportado entre todos es de " + montototalaportado);
        Debug.Log(persona2 + ":" + " aporto " + "$" + capitalaportado2 + " el porcentaje del total que aporto es " + porcentaje2 + "el monto total aportado entre todos es de " + montototalaportado);
        Debug.Log(persona3 + ":" + " aporto " + "$" + capitalaportado3 + " el porcentaje del total que aporto es " + porcentaje3 + "el monto total aportado entre todos es de " + montototalaportado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
