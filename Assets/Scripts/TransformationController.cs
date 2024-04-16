using UnityEngine;

public class TransformationController : MonoBehaviour
{
    [Header("Vectores de Transformación")]
    [SerializeField] private Vector3 vectorTraslacion;
    [SerializeField] private Vector3 vectorEscala;

    [Header("Puntos a Transformar")]
    [SerializeField] private GizmoPointController[] puntos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < puntos.Length; ++i)
            {
                AplicarTransformacion(puntos[i]);
            }
        }
    }
    private void AplicarTransformacion(GizmoPointController punto)
    {
        Vector3 posicionNueva = punto.PosicionActual + vectorTraslacion;
        punto.ActualizarPosicion(posicionNueva);
        punto.AplicarEscala(vectorEscala);
    }
}
