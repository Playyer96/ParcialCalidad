public class TileMap
{
    private Tile [][] tiles;
    public TileMap (int width, int height)
    {
        tiles = new Tile[width][height];

            for (int i = 0; i < width; i++ || int j = 0; i < height; j++)
            {
                tiles[i][j] = new Tile (i, j);
            }

        for (int connections; int i = 0; i < connections; i++)
        {
            int dx = 1;
            int dy = 0;
            int x = Random.Range (0, width-1);
            int y = Random.Range (0, height-1);
            Tile initial = tiles[x, y];
            Tile tile = tiles[x+dx, y+dy];
            if (dx == 1)
                initial.Right (tile);
            else if (dy == 1)
                initial.Up (tile);
            if (dx == 0)
                dx = 1;
            else
                dx = 0;
            if (dy == 0)
                dy = 1;
            else
                dy = 0;
        }
    }

    public Tile GetTile (int x, int y)
    {
        return tiles[x, y];
    }
}

    public class Player (TileMap map, int direction)
    {
        map = map;
        direction.x = x;
        direction.y = y;
    
    public void TryMove (Direction direction)
    {
        Tile tile = map.GetTile (x, y);
        switch (direction)
        {
            case Direction.Left:
                if (tile.Check ())
                    x -= 1;
                break;
            case Direction.Right:
                if (tile.Check ())
                    x += 1;
                break;
            case Direction.Up:
                if (tile.Check ())
                    y += 1;
                break;
            case Direction.Down:
                if (tile.Check ())
                    y -= 1;
                break;
        }
    }
}

public enum Direction
{
    Left,
    Right,
    Up,
    Down
}