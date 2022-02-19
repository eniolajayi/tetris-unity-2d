using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Board board {get; private set;}
    public TetrominoData data {get; private set;}
    public Vector3Int position {get; private set;}
    // spawn position
    // tetromino data to use while pieceis active
    // and reference to the game board 
    public void Initialize(Board board,Vector2Int position, TetrominoData data)
    {

    }
}
