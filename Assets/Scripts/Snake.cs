using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public GameObject Bloque;
    public GameObject Escenario;
    public int Ancho, Alto;

    private Vector3 direccion = Vector3.right;

    public void Awake()
    {
        crearMuros();
    }

    private void crearMuros()
    {
        for (int x = 0; x < Ancho; x++)
        {
            for (int y = 0; y < Alto; y++)
            {
                if (x == 0 || x == Ancho - 1 || y == 0 || y == Alto - 1)
                {
                    Vector3 posicion = new Vector3(x, y);
                    Instantiate(Bloque, posicion, Quaternion.identity, Escenario.transform);
                }
            }
        }
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direccionSeleccionada = new Vector3(horizontal, vertical);
        if (direccionSeleccionada != Vector3.zero)
        {
            direccion = direccionSeleccionada;
        }
    }
}
