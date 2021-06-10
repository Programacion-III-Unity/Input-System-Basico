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
    private Vector2 nuevaPosicion;


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
        nuevaPosicion = ctx.ReadValue<Vector2>();
    }

    private void Mover() {
        jugador.position += Vector3.right * nuevaPosicion.x * Time.deltaTime * 2f;
    }

    private void Disparar(InputAction.CallbackContext ctx) {
        Instantiate(bala, jugador.position, Quaternion.identity);
    }

    private void OnEnable() {
        entrada.Enable();
    }
}
