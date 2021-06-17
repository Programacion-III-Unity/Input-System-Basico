using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador: MonoBehaviour
{
    [SerializeField] private GameObject bala;
    [SerializeField] private float velocidad;
    Transform jugador;
    private Vector2 direccionDeInput;
    
    const float BORDE_LATERAL = 8.5f;
    const float BORDE_SUPERIOR = 4.5f;


    void Start() {
        jugador = GetComponent<Transform>();
    }

    private void Update(){
        Mover();
    }

    private void Mover(){
        jugador.Translate(Vector3.right * this.direccionDeInput.x * Time.deltaTime * this.velocidad, Space.Self);
        jugador.Translate(Vector3.up * this.direccionDeInput.y * Time.deltaTime * this.velocidad, Space.Self);
        jugador.position = new Vector3(
            ClamplearEjeX(jugador.position.x),
            ClamplearEjeY(jugador.position.y),
            jugador.position.z
        );
    }

    private float ClamplearEjeX(float posicion){
        return Mathf.Clamp(posicion, (BORDE_LATERAL * -1f), BORDE_LATERAL);
    }
    private float ClamplearEjeY(float posicion){
        return Mathf.Clamp(posicion, (BORDE_SUPERIOR * -1f), BORDE_SUPERIOR);
    }
    public void OnMovimiento(InputValue value){
        this.direccionDeInput = (Vector2)value.Get();
    }

    public void OnDisparo(InputValue value){
        GameObject nuevaBala;
        if ((float)value.Get() == 1f){
            nuevaBala = Instantiate(bala, jugador.position, jugador.rotation);
            nuevaBala.transform.parent = GameObject.Find("__Dynamic").transform;
        }
    }

    public void OnSalir(InputValue value){
        Application.Quit();
    }

    
}
