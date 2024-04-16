using UnityEngine;

public class GizmoPointController : MonoBehaviour
{
    [Header("Estado Inicial")]
    [SerializeField] private Vector3 posicionInicial;
    [SerializeField] private Vector3 escalaInicial = new Vector3(1, 1, 1);
    [Header("Estado Actual")]
    [SerializeField] private Vector3 posicionActual;
    [SerializeField] private Vector3 escalaActual;
    [SerializeField] private float radioDelPuntoGizmos;
    [Header("Referencia de los otros puntos en el Eje")]
    [SerializeField] private GizmoPointController posicionObjetivoEnZ;
    [SerializeField] private GizmoPointController posicionObjetivoEnY;
    [SerializeField] private GizmoPointController posicionObjetivoEnX;
    public Vector3 PosicionActual
    {
        get
        {
            return posicionActual;
        }
    }
    public Vector3 EscalaActual
    {
        get
        {
            return escalaActual;
        }
    }
    private void Start()
    {
        posicionActual = posicionInicial;
        escalaActual = escalaInicial;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            AplicarEscala(escalaActual);
        }
    }
    private void OnDrawGizmos()
    {
        // Dibujamos los puntos de color verde
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(posicionActual, radioDelPuntoGizmos);
        if (posicionObjetivoEnX != null && posicionObjetivoEnY != null && posicionObjetivoEnZ != null)
        {
            // Dibujamos lineas para conectar el punto creado con los otros puntos en los distintos ejes
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(posicionActual, posicionObjetivoEnZ.posicionActual);
            Gizmos.DrawLine(posicionActual, posicionObjetivoEnY.posicionActual);
            Gizmos.DrawLine(posicionActual, posicionObjetivoEnX.posicionActual);
        }
    }
    public void ActualizarPosicion(Vector3 nuevaPosicion)
    {
        posicionActual = nuevaPosicion;
    }
    public void ActualizarEscala(Vector3 nuevaEscala)
    {
        escalaActual = nuevaEscala;
    }
    public void AplicarEscala(Vector3 escala)
    {
        posicionActual.x = posicionActual.x * escala.x;
        posicionActual.y = posicionActual.y * escala.y;
        posicionActual.z = posicionActual.z * escala.z;
        escalaActual = escala;
    }


}
