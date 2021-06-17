using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    Transform jugador;
    [SerializeField] private GameObject bala;
    private Input entrada;
    private Vector2 direccionDeInput;
    [SerializeField] private float velocidad;


    
    const float BORDE_LATERAL = 8.5f;
    const float BORDE_SUPERIOR = 4.5f;


    void Awake() {
        entrada = new Input();
        entrada.Player.Disparo.performed += Disparar;
        entrada.Player.Movimiento.performed += InputMover;

    }

    void Start() {
        jugador = GetComponent<Transform>();

    }

    private void OnEnable()
    {
        entrada.Enable();
    }

    void Update() {
        Mover();
    }

    private void InputMover(InputAction.CallbackContext ctx) {
        this.direccionDeInput = ctx.ReadValue<Vector2>();
    }

    private void Mover() {
        jugador.Translate(Vector3.right * this.direccionDeInput.x * Time.deltaTime * this.velocidad);
        jugador.Translate(Vector3.up * this.direccionDeInput.y * Time.deltaTime * this.velocidad);
        jugador.position = new Vector3(
            ClamplearEjeX(jugador.position.x),
            ClamplearEjeY(jugador.position.y),
            jugador.position.z
        );

    }

    private float ClamplearEjeX(float posicion){
        return Mathf.Clamp(posicion, (BORDE_LATERAL * -1f), BORDE_LATERAL);
    }
    private float ClamplearEjeY(float posicion)
    {
        return Mathf.Clamp(posicion, (BORDE_SUPERIOR * -1f), BORDE_SUPERIOR);
    }



    private void Disparar(InputAction.CallbackContext ctx) {
        Instantiate(bala, jugador.position, jugador.rotation);
    }

    
}
