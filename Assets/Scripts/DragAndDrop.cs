using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] private bool isDraggable = true;
    [SerializeField] private bool isDragged = false;
    [SerializeField] private bool smartDrag = true;
    [SerializeField] private bool snapToGrid = true;
    Vector2 initPosMouse, initPosObject;

    private void Update()
    {
        if (isDragged)
        {
            if (!smartDrag)
            {
                gameObject.transform.position = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else
            {
                transform.position = initPosObject + (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition) - initPosMouse;
            }
            if (snapToGrid)
            {
                transform.position = new Vector2(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));
            }
        }
    }

    private void OnMouseOver()
    {
        if (isDraggable && Input.GetMouseButtonDown(0))
        {
            if (smartDrag)
            {
                initPosMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                initPosObject = transform.position;
            }
            isDragged = true;
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
    }
}
