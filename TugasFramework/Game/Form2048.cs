using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TugasFramework.Game
{
    /// <summary>
    /// 2048 using code from https://github.com/gabrielecirulli/2048
    /// </summary>
    public partial class Form2048 : Form
    {
        private int size;
        private int startTiles;
        private int score;
        private bool over;
        private bool won;
        private bool keepPlaying;
        private Grid grid;
        private Button[,] place;
        private Random random;
        private Dictionary<int, Color> tileBackgroundColor = new Dictionary<int,Color>();

        enum Direct
        {
            Up = 0,
            Right = 1,
            Down = 2,
            Left = 3
        }

        struct Coordinat
        {
            public int x;
            public int y;

            public Coordinat(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct Tile
        {
            public int x;
            public int y;
            public Coordinat previousPosition;
            public Tile[] mergeFrom;
            public int value;

            public Tile(Coordinat position, int value)
            {
                this.x = position.x;
                this.y = position.y;
                this.value = value;
                this.previousPosition = new Coordinat();
                this.mergeFrom = null;
            }

            public void savePosition()
            {
                previousPosition.x = this.x;
                previousPosition.y = this.y;
            }

            public void updatePosition(Coordinat position)
            {
                this.x = position.x;
                this.y = position.y;
            }
        }

        struct Grid
        {
            private int size;
            public Tile[,] cells;

            public Grid(int size, Tile[,] previousState)
            {
                this.size = size;
                cells = new Tile[this.size, this.size];
                if (previousState != null)
                {
                    this.fromState(previousState);
                }
                else
                {
                    this.empty();
                }
            }

            private void empty()
            {
                for (int i = 0; i < this.size; i++)
                {
                    for (int j = 0; j < this.size; j++)
                    {
                        cells[i, j] = new Tile(new Coordinat(i, j), 0);
                    }
                }
            }

            private void fromState(Tile[,] previousState)
            {
                for (int i = 0; i < this.size; i++)
                {
                    for (int j = 0; j < this.size; j++)
                    {
                        cells[i, j] = previousState[i, j];
                    }
                }
            }

            public Coordinat randomAvailableCells()
            {
                List<Coordinat> cell = availableCells();
                Random rand = new Random(DateTime.Now.Millisecond);
                return cell[(int)Math.Round(rand.NextDouble() * (cell.Count - 1), 0)];
            }

            public List<Coordinat> availableCells()
            {
                List<Coordinat> cell = new List<Coordinat>();
                for (int x = 0; x < this.size; x++)
                {
                    for (int y = 0; y < this.size; y++)
                    {
                        if (cells[x, y].value == 0)
                        {
                            cell.Add(new Coordinat(x, y));
                        }
                    }
                }
                return cell;
            }

            public bool cellsAvailable()
            {
                return availableCells().Count > 0;
            }

            public bool cellAvailable(Coordinat cell)
            {
                return !cellOccupied(cell);
            }

            public bool cellOccupied(Coordinat cell)
            {
                return cellContent(cell).value > 0;
            }

            public Tile cellContent(Coordinat cell)
            {
                if (this.withinBounds(cell))
                {
                    return this.cells[cell.x, cell.y];
                }
                else
                {
                    return new Tile();
                }
            }

            public bool withinBounds(Coordinat position)
            {
                return position.x >= 0 && position.x < this.size &&
                        position.y >= 0 && position.y < this.size;
            }

            public void insertTile(Tile tile)
            {
                //this.cells[tile.x, tile.y].value = tile.value;
                this.cells[tile.x, tile.y] = tile;
            }

            public void removeTile(Tile tile)
            {
                this.cells[tile.x, tile.y].value = 0;
            }
        }

        struct GameData
        {
            public int size;
            public int score;
            public bool over;
            public bool won;
            public bool keepPlaying;
            public Tile[,] grid;
        }

        public Form2048()
        {
            InitializeComponent();

            this.size = 4;
            this.startTiles = 2;
            random = new Random(DateTime.Now.Millisecond);

            this.place = new Button[this.size, this.size];
            for (int y = 0; y < this.size; y++)
            {
                dataGridView1.Columns.Add("P" + y, "P" + y);
                for (int x = 0; x < this.size; x++)
                {
                    place[x, y] = this.Controls["button" + x + y] as Button;
                }
            }

            // 0
            tileBackgroundColor[0] = Color.FromArgb((int)(255 * 0.35), 238, 228, 218);
            // 2        eee4da
            tileBackgroundColor[1 << 1] = Color.FromArgb(0xee, 0xe4, 0xda);
            // 4        ede0c8
            tileBackgroundColor[1 << 2] = Color.FromArgb(0xed, 0xe0, 0xc8);
            // 8        f2b179
            tileBackgroundColor[1 << 3] = Color.FromArgb(0xf2, 0xb1, 0x79);
            // 16       f59563
            tileBackgroundColor[1 << 4] = Color.FromArgb(0xf5, 0x95, 0x63);
            // 32       f67c5f
            tileBackgroundColor[1 << 5] = Color.FromArgb(0xf6, 0x7c, 0x5f);
            // 64       f65e3b
            tileBackgroundColor[1 << 6] = Color.FromArgb(0xf6, 0x5e, 0x3b);
            // 128      edcf72
            tileBackgroundColor[1 << 7] = Color.FromArgb(0xed, 0xcf, 0x72);
            // 256      edcc61
            tileBackgroundColor[1 << 8] = Color.FromArgb(0xed, 0xcc, 0x61);
            // 512      edc850
            tileBackgroundColor[1 << 9] = Color.FromArgb(0xed, 0xc8, 0x50);
            // 1024     edc53f
            tileBackgroundColor[1 << 10] = Color.FromArgb(0xed, 0xc5, 0x3f);
            // 2048     edc22e
            tileBackgroundColor[1 << 11] = Color.FromArgb(0xed, 0xc2, 0x2e);
            // 4096     3c3a32
            tileBackgroundColor[1 << 12] = Color.FromArgb(0x3c, 0x3a, 0x32);
            // 8192     3c3a32
            tileBackgroundColor[1 << 13] = Color.FromArgb(0x3c, 0x3a, 0x32);
            // 16384    3c3a32
            tileBackgroundColor[1 << 14] = Color.FromArgb(0x3c, 0x3a, 0x32);
            // 32768    3c3a32
            tileBackgroundColor[1 << 15] = Color.FromArgb(0x3c, 0x3a, 0x32);
            // 65536    3c3a32
            tileBackgroundColor[1 << 16] = Color.FromArgb(0x3c, 0x3a, 0x32);

            this.setup();
        }

        private void Form2048_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.move((int)Direct.Down);
            }
            else if (e.KeyCode == Keys.Up)
            {
                this.move((int)Direct.Up);
            }
            else if (e.KeyCode == Keys.Right)
            {
                this.move((int)Direct.Right);
            }
            else if (e.KeyCode == Keys.Left)
            {
                this.move((int)Direct.Left);
            }
        }

        private void showGrid()
        {
            string[] a = new string[this.size];
            for (int y = 0; y < this.size; y++)
            {
                for (int x = 0; x < this.size; x++)
                {
                    Tile t = grid.cells[x, y];
                    a[x] = t.x + " " + t.y + " " + t.value;
                    if (t.value != 0)
                    {
                        place[x, y].Text = t.value.ToString();
                    }
                    else
                    {
                        place[x, y].Text = "";
                    }
                    place[x, y].BackColor = tileBackgroundColor[t.value];
                }
            }
            this.labelScore.Text = this.score.ToString();
            //Application.DoEvents();
        }

        private void setup()
        {
            GameData previousState = getGameState();

            // Reload the game from a previous game if present
            if (previousState.grid != null)
            {
                this.grid = new Grid(previousState.size, previousState.grid);
                this.score = previousState.score;
                this.over = previousState.over;
                this.won = previousState.won;
                this.keepPlaying = previousState.keepPlaying;
            }
            else
            {
                this.grid = new Grid(this.size, null);
                this.score = 0;
                this.over = false;
                this.won = false;
                this.keepPlaying = false;

                // Add the initial tiles
                this.addStartTiles();
            }
            this.showGrid();
        }

        private GameData getGameState()
        {
            GameData data = new GameData();
            //Tile[,] tile = new Tile[this.size, this.size];
            //Random r = new Random(DateTime.Now.Millisecond);
            //for (int i = 0; i < this.size; i++)
            //{
            //    for (int j = 0; j < this.size; j++)
            //    {
            //        int t = r.Next(0, 15);
            //        if (t != 0)
            //        {
            //            tile[i, j] = new Tile(new Coordinat(i, j), 1 << t);
            //        }
            //        else
            //        {
            //            tile[i, j] = new Tile(new Coordinat(i, j), 0);
            //        }
            //    }
            //}
            //data.grid = tile;
            data.size = 4;
            data.score = 1000;
            data.over = false;
            data.won = false;
            data.keepPlaying = true;
            return data;
        }

        private void addStartTiles()
        {
            for (var i = 0; i < this.startTiles; i++)
            {
                this.addRandomTile();
            }
        }

        private void addRandomTile()
        {
            if (this.grid.cellsAvailable())
            {
                int value = (random.NextDouble() < 0.9) ? 2 : 4;
                Tile tile = new Tile(this.grid.randomAvailableCells(), value);
                grid.insertTile(tile);
            }
        }

        private bool isGameTerminated()
        {
            return this.over || (this.won && !this.keepPlaying);
        }

        private bool movesAvailable()
        {
            return this.grid.cellsAvailable() || this.tileMatchesAvailable();
        }

        private Coordinat getVector(int direction)
        {
            Coordinat[] map = new Coordinat[4];
            map[0] = new Coordinat(0, -1); // Up
            map[1] = new Coordinat(1, 0); // Right
            map[2] = new Coordinat(0, 1); // Down
            map[3] = new Coordinat(-1, 0); // Left
            return map[direction];
        }

        private bool tileMatchesAvailable()
        {
            Tile tile;
            for (int x = 0; x < this.size; x++)
            {
                for (int y = 0; y < this.size; y++)
                {
                    tile = grid.cellContent(new Coordinat(x, y));

                    if (tile.value > 0)
                    {
                        for (int direction = 0; direction < 4; direction++)
                        {
                            Coordinat vector = this.getVector(direction);
                            Coordinat cell = new Coordinat(x + vector.x, y + vector.y);

                            Tile other = grid.cellContent(cell);
                            if (other.value == tile.value)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool positionsEqual(Coordinat first, Coordinat second)
        {
            return first.x == second.x && first.y == second.y;
        }

        private void prepareTiles()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    if (grid.cells[i, j].value > 0)
                    {
                        grid.cells[i, j].savePosition();
                        grid.cells[i, j].mergeFrom = null;
                    }
                }
            }
        }

        private void moveTile(Tile tile, Coordinat cell)
        {
            this.grid.cells[tile.x, tile.y].value = 0;
            this.grid.cells[cell.x, cell.y].value = tile.value;
            //tile.updatePosition(cell);
        }

        private void move(int direction)
        {
            if (this.isGameTerminated()) return;

            Tile tile;
            Coordinat cell;

            Coordinat vector = this.getVector(direction);
            List<int>[] traversals = this.buildTraversals(vector);
            bool moved = false;

            this.prepareTiles();

            foreach (int y in traversals[1])
            {
                foreach (int x in traversals[0])
                {
                    cell = new Coordinat(x, y);
                    tile = this.grid.cellContent(cell);

                    if (tile.value > 0)
                    {
                        Coordinat[] positions = this.findFarthestPosition(cell, vector);
                        Tile next = this.grid.cellContent(positions[1]);

                        if (next.value > 0 && next.value == tile.value && next.mergeFrom == null)
                        {
                            Tile merged = new Tile(positions[1], tile.value << 1);
                            merged.mergeFrom = new Tile[] { tile, next };

                            this.grid.insertTile(merged);
                            this.grid.removeTile(tile);

                            //tile.updatePosition(positions[1]);
                            this.grid.cells[positions[1].x, positions[1].y].updatePosition(positions[1]);

                            this.score += merged.value;

                            if (merged.value == 2048)
                            {
                                this.won = true;
                            }

                            positions[0] = positions[1];
                        }
                        else
                        {
                            this.moveTile(tile, positions[0]);
                        }

                        if (!this.positionsEqual(cell, positions[0]))
                        {
                            moved = true;
                        }
                    }
                }
            }
            if (moved)
            {
                this.addRandomTile();

                if (!this.movesAvailable())
                {
                    this.over = true; // Game over!
                }
            }
            this.showGrid();
        }

        private List<int>[] buildTraversals(Coordinat vector)
        {
            List<int>[] traversals = new List<int>[2];
            traversals[0] = new List<int>();
            traversals[1] = new List<int>();
            for (int i = 0; i < this.size; i++)
            {
                traversals[0].Add(i);
                traversals[1].Add(i);
            }
            if (vector.x == 1) traversals[0].Reverse();
            if (vector.y == 1) traversals[1].Reverse();
            return traversals;
        }

        private Coordinat[] findFarthestPosition(Coordinat cell, Coordinat vector)
        {
            Coordinat[] result = new Coordinat[2];
            Coordinat prev;
            do
            {
                prev = cell;
                cell.x = prev.x + vector.x;
                cell.y = prev.y + vector.y;
            } while (this.grid.withinBounds(cell) && this.grid.cellAvailable(cell));
            result[0] = prev;
            result[1] = cell;
            return result;
        }
    }
}
