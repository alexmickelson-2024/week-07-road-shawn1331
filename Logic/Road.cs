public class Road : IRoad
{
    public int RowCount {get;}
    public int ColCount {get;}
    private IVehicle[,] vehicles;

    public Road(int rows, int columns)
    {
        RowCount = rows;
        ColCount = columns;
        vehicles = new IVehicle[RowCount, ColCount];
    }

    public void SetVehicle(int row, int column, IVehicle vehicle)
    {
        vehicles[row,column] = vehicle;
    }

    public IVehicle GetVehicle(int row, int column)
    {
        return vehicles[row,column];
    }
}