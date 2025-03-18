using UnityEngine;

public class SistemaSolar : MonoBehaviour
{
    public Transform sol, tierra, luna;
    
    public float rotacionVelocidad = 50f;
    public float orbitaVelocidadTierra = 10f;
    public float orbitaVelocidadLuna = 30f;
    public float escalaFactor = 1.5f;
    public Vector3 traslacionDistancia = new Vector3(2, 0, 0);

    private bool rotandoSistema = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotandoSistema = !rotandoSistema;
        }

        // Rotar cada objeto sobre su propio eje
        if (Input.GetKeyDown(KeyCode.R))
        {
            Rotar(sol);
            Rotar(tierra);
            Rotar(luna);
        }

        // Trasladar todo el sistema
        if (Input.GetKeyDown(KeyCode.T))
        {
            Trasladar(sol);
            Trasladar(tierra);
            Trasladar(luna);
        }

        // Escalar todo el sistema
        if (Input.GetKeyDown(KeyCode.E))
        {
            Escalar(sol);
            Escalar(tierra);
            Escalar(luna);
        }

        if (rotandoSistema)
        {
            Orbitar();
        }
    }

    void Rotar(Transform objeto)
    {
        objeto.Rotate(Vector3.up, rotacionVelocidad * Time.deltaTime);
    }

    void Escalar(Transform objeto)
    {
        objeto.localScale *= escalaFactor;
    }

    void Trasladar(Transform objeto)
    {
        objeto.position += traslacionDistancia;
    }

    void Orbitar()
    {
        // La Tierra orbita alrededor del Sol
        tierra.RotateAround(sol.position, Vector3.up, orbitaVelocidadTierra * Time.deltaTime);
        
        // La Luna orbita alrededor de la Tierra
        luna.RotateAround(tierra.position, Vector3.up, orbitaVelocidadLuna * Time.deltaTime);
    }
}
