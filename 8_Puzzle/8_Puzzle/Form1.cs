namespace _8_Puzzle
{
    public partial class Form1 : Form
    {
        private int stepCount = 0;
        private TableLayoutPanelCellPosition emptyTilePosition;
        private System.Windows.Forms.Timer timer;
        private int elapsedTime = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            bt1.Click += new EventHandler(Button_Click);
            bt2.Click += new EventHandler(Button_Click);
            bt3.Click += new EventHandler(Button_Click);
            bt4.Click += new EventHandler(Button_Click);
            bt5.Click += new EventHandler(Button_Click);
            bt6.Click += new EventHandler(Button_Click);
            bt7.Click += new EventHandler(Button_Click);
            bt8.Click += new EventHandler(Button_Click);

            btMix.Click += new EventHandler(btMix_Click);
            btSolve.Click += new EventHandler(btSolve_ClickAsync);
            btExit.Click += (sender, e) => { this.Close(); };

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            emptyTilePosition = new TableLayoutPanelCellPosition(2, 2);
            StartNewGame();
        }

        private void StartNewGame()
        {
            stepCount = 0;
            elapsedTime = 0;
            textBoxStep.Text = stepCount.ToString();
            textBoxTime.Text = elapsedTime.ToString();
            timer.Start();
            ShuffleTiles();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBoxTime.Text = elapsedTime.ToString();
        }

        private void ShuffleTiles()
        {
            List<int> numbers = Enumerable.Range(0, 9).OrderBy(x => random.Next()).ToList();
            int index = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (numbers[index] == 0)
                    {
                        emptyTilePosition = new TableLayoutPanelCellPosition(j, i);
                    }
                    else
                    {
                        Button button = GetButtonByValue(numbers[index]);
                        tableLayoutPanel1.SetCellPosition(button, new TableLayoutPanelCellPosition(j, i));
                    }
                    index++;
                }
            }
        }

        private Button GetButtonByValue(int value)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button && button.Text == value.ToString())
                {
                    return button;
                }
            }
            return null;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TableLayoutPanelCellPosition buttonPosition = tableLayoutPanel1.GetPositionFromControl(button);

            if (IsValidMove(buttonPosition))
            {
                tableLayoutPanel1.SetCellPosition(button, emptyTilePosition);
                emptyTilePosition = buttonPosition;
                stepCount++;
                textBoxStep.Text = stepCount.ToString();

                if (IsSolved())
                {
                    timer.Stop();
                    MessageBox.Show("You have solved the puzzle!");
                }
            }
        }

        private bool IsValidMove(TableLayoutPanelCellPosition position)
        {
            int rowDiff = Math.Abs(position.Row - emptyTilePosition.Row);
            int colDiff = Math.Abs(position.Column - emptyTilePosition.Column);
            return (rowDiff == 1 && colDiff == 0) || (rowDiff == 0 && colDiff == 1);
        }

        private bool IsSolved()
        {
            int[,] solution = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    if (control is Button button && int.TryParse(button.Text, out int number))
                    {
                        if (number != solution[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private List<List<int>> GetCurrentState()
        {
            List<List<int>> state = new List<List<int>>();
            for (int row = 0; row < 3; row++)
            {
                List<int> currentRow = new List<int>();
                for (int col = 0; col < 3; col++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control is Button button && int.TryParse(button.Text, out int number))
                    {
                        currentRow.Add(number);
                    }
                    else
                    {
                        currentRow.Add(0);
                    }
                }
                state.Add(currentRow);
            }
            return state;
        }

        private void SetState(List<List<int>> state)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int number = state[row][col];
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);

                    if (number == 0)
                    {
                        emptyTilePosition = new TableLayoutPanelCellPosition(col, row);
                    }
                    else
                    {
                        Button button = GetButtonByValue(number);
                        tableLayoutPanel1.SetCellPosition(button, new TableLayoutPanelCellPosition(col, row));
                    }
                }
            }
        }

        private void btMix_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private async void btSolve_ClickAsync(object sender, EventArgs e)
        {
            timer.Stop();
            List<List<int>> initialState = GetCurrentState();
            List<List<int>> goalState = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 7, 8, 0 }
            };

            List<State> solutionPath = await Task.Run(() => AStarSearch(initialState, goalState));
            if (solutionPath != null)
            {
                foreach (State state in solutionPath)
                {
                    SetState(state.Board);
                    await Task.Delay(500); // Delay to visualize the steps
                }
                MessageBox.Show("Puzzle Solved!");
                StartNewGame(); // Bắt đầu trò chơi mới sau khi giải quyết thành công
            }
            else
            {
                MessageBox.Show("No solution found!");
            }
        }

        private List<State> AStarSearch(List<List<int>> initialState, List<List<int>> goalState)
        {
            PriorityQueue<State> openSet = new PriorityQueue<State>();
            HashSet<State> closedSet = new HashSet<State>();

            State startState = new State(initialState, null, 0, Heuristic(initialState, goalState));
            openSet.Enqueue(startState);

            while (openSet.Count > 0)
            {
                State currentState = openSet.Dequeue();
                if (currentState.Equals(goalState))
                {
                    return ReconstructPath(currentState);
                }

                closedSet.Add(currentState);

                foreach (State neighbor in currentState.GetNeighbors())
                {
                    if (closedSet.Contains(neighbor))
                    {
                        continue;
                    }

                    int tentativeGScore = currentState.G + 1;

                    if (!openSet.Contains(neighbor) || tentativeGScore < neighbor.G)
                    {
                        neighbor.Previous = currentState;
                        neighbor.G = tentativeGScore;
                        neighbor.F = tentativeGScore + Heuristic(neighbor.Board, goalState);

                        if (!openSet.Contains(neighbor))
                        {
                            openSet.Enqueue(neighbor);
                        }
                    }
                }
            }
            return null;
        }

        private int Heuristic(List<List<int>> state, List<List<int>> goal)
        {
            int h = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int value = state[row][col];
                    if (value != 0)
                    {
                        for (int goalRow = 0; goalRow < 3; goalRow++)
                        {
                            for (int goalCol = 0; goalCol < 3; goalCol++)
                            {
                                if (goal[goalRow][goalCol] == value)
                                {
                                    h += Math.Abs(row - goalRow) + Math.Abs(col - goalCol);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return h;
        }

        private List<State> ReconstructPath(State state)
        {
            List<State> path = new List<State>();
            while (state != null)
            {
                path.Insert(0, state);
                state = state.Previous;
            }
            return path;
        }

        public class State : IComparable<State>
        {
            public List<List<int>> Board { get; }
            public State Previous { get; set; }
            public int G { get; set; }
            public int F { get; set; }

            public State(List<List<int>> board, State previous, int g, int f)
            {
                Board = board;
                Previous = previous;
                G = g;
                F = f;
            }

            public List<State> GetNeighbors()
            {
                List<State> neighbors = new List<State>();
                (int row, int col) = FindEmptyTile();

                foreach ((int dRow, int dCol) in new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
                {
                    int newRow = row + dRow;
                    int newCol = col + dCol;

                    if (newRow >= 0 && newRow < 3 && newCol >= 0 && newCol < 3)
                    {
                        List<List<int>> newBoard = Board.Select(innerList => innerList.ToList()).ToList();
                        newBoard[row][col] = newBoard[newRow][newCol];
                        newBoard[newRow][newCol] = 0;
                        neighbors.Add(new State(newBoard, this, G + 1, 0));
                    }
                }
                return neighbors;
            }

            private (int, int) FindEmptyTile()
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (Board[row][col] == 0)
                        {
                            return (row, col);
                        }
                    }
                }
                return (-1, -1);
            }

            public bool Equals(List<List<int>> otherBoard)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (Board[row][col] != otherBoard[row][col])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            public int CompareTo(State other)
            {
                return F.CompareTo(other.F);
            }

            public override bool Equals(object obj)
            {
                return obj is State other && Equals(other.Board);
            }

            public override int GetHashCode()
            {
                int hash = 17;
                foreach (var row in Board)
                {
                    foreach (var value in row)
                    {
                        hash = hash * 31 + value;
                    }
                }
                return hash;
            }
        }

        public class PriorityQueue<T> where T : IComparable<T>
        {
            private List<T> data;

            public PriorityQueue()
            {
                this.data = new List<T>();
            }

            public void Enqueue(T item)
            {
                data.Add(item);
                int ci = data.Count - 1;
                while (ci > 0)
                {
                    int pi = (ci - 1) / 2;
                    if (data[ci].CompareTo(data[pi]) >= 0) break;
                    T tmp = data[ci];
                    data[ci] = data[pi];
                    data[pi] = tmp;
                    ci = pi;
                }
            }

            public T Dequeue()
            {
                int li = data.Count - 1;
                T frontItem = data[0];
                data[0] = data[li];
                data.RemoveAt(li);

                li--;
                int pi = 0;
                while (true)
                {
                    int ci = pi * 2 + 1;
                    if (ci > li) break;
                    int rc = ci + 1;
                    if (rc <= li && data[rc].CompareTo(data[ci]) < 0)
                        ci = rc;
                    if (data[pi].CompareTo(data[ci]) <= 0) break;
                    T tmp = data[pi];
                    data[pi] = data[ci];
                    data[ci] = tmp;
                    pi = ci;
                }
                return frontItem;
            }

            public int Count
            {
                get { return data.Count; }
            }

            public bool Contains(T item)
            {
                return data.Contains(item);
            }
        }
    }
}
