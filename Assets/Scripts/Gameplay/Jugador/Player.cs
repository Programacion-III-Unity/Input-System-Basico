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
    private Vector2 direccionDeInputMovimiento;

    public GameObject cursor;


    const float BORDE_IZQUIERDO = -11.5f;
    const float BORDE_DERECHO = 11.5f;


    void Awake() {
        entrada = new Input();
        entrada.Player.Disparo.performed += Disparar;
        entrada.Player.Movimiento.performed += InputMover;

    }

    void Start() {
        jugador = GetComponent<Transform>();

    }

    void Update() {
        Mover();
    }

    private void InputMover(InputAction.CallbackContext ctx) {
        direccionDeInputMovimiento = ctx.ReadValue<Vector2>();
    }

    private void Mover() {
        if(DebeMoverse())
            jugador.position += Vector3.right * direccionDeInputMovimiento.x * Time.deltaTime * 2f;
    }

    private bool DebeMoverse() {
        if ((estaTocandoBordeIzquierdo() && direccionDeInputMovimiento.x > 0  ) || ( estaTocandoBordeDerecho() && direccionDeInputMovimiento.x < 0 ))
            return true;
        if (!estaTocandoBordeIzquierdo() && !estaTocandoBordeDerecho())
            return true;
        return false;
    }

    private bool estaTocandoBordeIzquierdo() {
        if(jugador.position.x <= BORDE_IZQUIERDO) return true;
        return false;
    }

    private bool estaTocandoBordeDerecho() {
        if(jugador.position.x >= BORDE_DERECHO) return true;
        return false;
    }


    private void Disparar(InputAction.CallbackContext ctx) {
        Instantiate(bala, jugador.position, Quaternion.identity);
    }

    private void OnEnable() {
        entrada.Enable();
    }
}
