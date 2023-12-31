using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private Tile tileStart;
    [SerializeField] private Tile tileFinish;
    [SerializeField] private Tile tileDirection;
    public Tile player;
    private Transform cam;
    private Tile tile;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                tile = Instantiate(tilePrefab, new Vector3(x, y, 0), Quaternion.identity);
                tile.name = $"tile {x}, {y}";
                if (tile.name == "tile 0, 0")
                {
                    tile = Instantiate(tileStart, new Vector3(x, y, 0), Quaternion.identity);
                    // tile = Instantiate(player, new Vector3(x, y, 0), Quaternion.identity);
                }
                if (tile.name == $"tile {width - 1}, {height - 1}")
                {
                    tile = Instantiate(tileFinish, new Vector3(x, y, 0), Quaternion.identity);
                }
                if (tile.name == $"tile 1, 0")
                {
                    tile = Instantiate(tileDirection, new Vector3(x, y, 0), Quaternion.identity);
                }
            }
        }
    }
}