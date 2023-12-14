using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 initialPosition;
    private bool isBeingDragged = false;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (isBeingDragged)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Assurez-vous que la position Z reste constante
            transform.position = mousePosition;

            transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0f);
        }
    }

    void OnMouseDown()
    {
        isBeingDragged = true;
    }

    void OnMouseUp()
    {
        isBeingDragged = false;

        // Vérifier s'il y a un collider avec un tag spécifique sous l'objet
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);

        bool isOverValidTarget = false;

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Tile"))
            {
                isOverValidTarget = true;
                break;
            }
        }

        // Si l'objet n'est pas au-dessus d'une cible valide, retournez à la position initiale
        if (!isOverValidTarget)
        {
            transform.position = initialPosition;
        }
    }
}
