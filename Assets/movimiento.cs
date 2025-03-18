using UnityEngine;

public class Transformaciones : MonoBehaviour
{
    public float escalaFactor = 1.5f;
    public float rotacionAngulo = 45f;
    public Vector3 traslacionDistancia = new Vector3(2, 0, 0);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Escalar();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Rotar();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Trasladar();
        }
    }

    // Escalar el objeto
    public void Escalar()
    {
        transform.localScale *= escalaFactor;
    }

    // Rotar el objeto
    public void Rotar()
    {
        transform.Rotate(Vector3.up, rotacionAngulo);
    }

    // Trasladar el objeto
    public void Trasladar()
    {
        transform.position += traslacionDistancia;
    }
}
