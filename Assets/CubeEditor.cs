using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[ExecuteInEditMode]
[RequireComponent(typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{
    
    Waypoint waypoint;

    // Start is called before the first frame updat
    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();

    }

    private void UpdateLabel()
    {
        int gridSize = waypoint.GetGridSize();
        string textLabel = waypoint.GetGridPos().x / gridSize + "," + waypoint.GetGridPos().y / gridSize;
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = textLabel;
        gameObject.name = "Cube " + textLabel;
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        
        transform.position = new Vector3(waypoint.GetGridPos().x, 0, waypoint.GetGridPos().y);
    }
}
