public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int row = 0;
        int col = 0;
        int direction = 0;
        int[] rowDirection = { 0, 1, 0, -1 };
        int[] colDirection = { 1, 0, -1, 0 };

        for (int i = 1; i <= size * size; i++)
        {
            matrix[row, col] = i;
            int nextRow = row + rowDirection[direction];
            int nextCol = col + colDirection[direction];

            if (nextRow < 0 || nextRow >= size || nextCol < 0 || nextCol >= size || matrix[nextRow, nextCol] != 0)
            {
                direction = (direction + 1) % 4;
            }

            row += rowDirection[direction];
            col += colDirection[direction];
        }

        return matrix;
    }
}
