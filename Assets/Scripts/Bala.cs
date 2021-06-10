using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Transform posicion;

    void Start()
    {
        posicion = GetComponent<Transform>();
    }

    void Update() {
        posicion.position += Vector3.right * Time.deltaTime * 8f;
        CheckearLimiteDePantalla();
    }

    private void CheckearLimiteDePantalla() {
        if (posicion.position.x > 10f) Destroy(this.gameObject);
    }
}
