using UnityEngine;
using UnityEngine.Tilemaps;

// Controls overrall state of the game
public class Board : MonoBehaviour
{
    public Tilemap tilemap {get; private set;}
    public Piece activePiece {get; private set;}
    public TetrominoData[] tetrominoes;
    public Vector3Int spawnPosition;

    private void Awake()
    {
        this.tilemap =  GetComponentInChildren<Tilemap>();
        this.activePiece =  GetComponentInChildren<Piece>();
        for(int i = 0; i < this.tetrominoes.Length; i++){
            this.tetrominoes[i].Initialize();
        }
    }

    private void Start()
    {
        SpawnPiece();

    }

    public void SpawnPiece()
    {
        int random = Random.Range(0, this.tetrominoes.Length);
        TetrominoData data = this.tetrominoes[random];

        this.activePiece.Initialize(this, (Vector2Int) this.spawnPosition ,data);
        Set(this.activePiece);
    }

    public void Set(Piece piece)
    {
        for (int i = 0; i < piece.cells.Length; i++)
        {
            // provide position to tile map
            // each cellplus position of our peice as a whole
            Vector3Int tilePosition = piece.cells[i] + piece.position;
            //set it to tilemap
            this.tilemap.SetTile(tilePosition, piece.data.tile);

        }
    }
}
