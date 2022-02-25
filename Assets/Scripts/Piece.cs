using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Board board {get; private set;}
    public TetrominoData data {get; private set;}
    public Vector3Int position {get; private set;}
    public Vector3Int[] cells {get; private set;}
    // spawn position
    // tetromino data to use while pieceis active
    // and reference to the game board 
    public void Initialize(Board board,Vector2Int position, TetrominoData data)
    {
        this.board = board;
        this.position = (Vector3Int)position;
        this.data = data;

        if(this.cells == null){
            this.cells = new Vector3Int[data.cells.Length];
        }

        for (int i = 0; i < data.cells.Length; i++)
        {
            this.cells[i] = (Vector3Int)data.cells[i];
        }
    }
    private bool Move(Vector2Int translation)
    {
        // calculate new position to check if valid
        Vector3Int newPosition = this.position;
        newPosition.x += translation.x;
        newPosition.y += translation.y;

        bool valid = this.board.IsValidPosition(this,newPosition);

        if(valid){
            this.position = newPosition;
        }
        return valid;
    }
}
