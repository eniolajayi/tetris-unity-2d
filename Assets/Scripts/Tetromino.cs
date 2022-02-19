using UnityEngine;
using UnityEngine.Tilemaps;

// The proper definition for the tetris blocks
// check wikipedia
public enum Tetromino
{
    I,O,T,J,L,S,Z
}

[System.Serializable]
public struct TetrominoData
{
    public  Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells {get; private set;}

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
    }

}