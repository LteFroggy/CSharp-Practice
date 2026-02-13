using System.Runtime.CompilerServices;

static class MyUtil {
    public static void initalizeBoard(ref List<List<char>> board, int n, int m) {
        for (int i = 0; i < n; i++) {
            List<char> row = new List<char>();
            for (int j = 0; j < m; j++) {
                row.Add(' ');
            }

            board.Add(row);
        }
    }

    public static void eraseBoard(ref List<List<char>> board, int n, int m) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                board[i][j] = ' ';
            }
        }
    }
}

class Point {
    public int y;
    public int x;
    public Point(int y, int x) {
        this.y = y;
        this.x = x;
    }
}

class Program {
    static void Main() {

        // 트리 사이즈 10
        int treeSize = 18;
        int treeHeight = 5;
        int treeLoc = 30;

        // 보드 사이즈 30 x 100
        int n = 30, m = 100;
        List<List<Char>> board = new List<List<Char>>();

        MyUtil.initalizeBoard(ref board, n, m);

        // 나무 위치 저장용 List
        List<Point> treeLocs = new List<Point>();

        // 나무 위치 저장
        for (int i = 0; i < treeSize; i++) {
            int idxJ = treeLoc;
            // 트리 앞단
            for (int j = 0; j <= treeSize - i; j++) {
                idxJ++;
                // board[i + treeHeight][idxJ++] = ' ';
            }

            for (int j = 0; j < i; j++) {
                treeLocs.Add(new Point(i + treeHeight, idxJ++));
                // board[i + treeHeight][idxJ++] = '*';
            }

            // 트리 중간
            // board[i + treeHeight][idxJ++] = '*';
            treeLocs.Add(new Point(i + treeHeight, idxJ++));

            // 트리 뒤쪽
            for (int j = 0; j < i; j++) {
                treeLocs.Add(new Point(i + treeHeight, idxJ++));
                // board[i + treeHeight][idxJ++] = '*';
            }

            // 트리 기둥
            for (int j = n - treeHeight - treeSize; j < n; j++) {
                treeLocs.Add(new Point(j, treeLoc + treeSize - 1));
                treeLocs.Add(new Point(j, treeLoc + treeSize));
                treeLocs.Add(new Point(j, treeLoc + treeSize + 1));
                treeLocs.Add(new Point(j, treeLoc + treeSize + 2));
                treeLocs.Add(new Point(j, treeLoc + treeSize + 3));
            }
        }

        // 눈송이 저장용 List
        List<Point> snows = new List<Point>();
        
        // 랜덤
        Random rand = new Random();
        
        int count = 0;
        while (++count != 0) {
            // 매 초마다 랜덤하게 눈송이 3개 생성
            for (int i = 0; i < 3; i++) {
                int loc = rand.Next(0, m);
                snows.Add(new Point(0, loc));
            }

            // 보드 초기화
            MyUtil.eraseBoard(ref board, n, m);
            
            // 나무 적용
            foreach (Point p in treeLocs) {
                board[p.y][p.x] = '*';
            }

            // 눈 적용
            foreach (Point snow in snows) {
                board[snow.y][snow.x] = '*';
            }

            // 보드 그리기
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    Console.Write(board[i][j]);
                }
                Console.WriteLine();
            }

            // 눈 한칸씩 내려오게
            for (int i = snows.Count() - 1; i >= 0; i--) {
                snows[i].y++;
                if (snows[i].y == n) { snows.RemoveAt(i); }
            }

            Thread.Sleep(500);
            Console.Clear();
        }
    }
}