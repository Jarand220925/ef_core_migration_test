using NetTopologySuite.Geometries;

namespace ef_core_migration_test.models.classes;

public class Coordinate
{
    public int CoordinateId { get; set; }
    public int EPSG { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Point GeographyPoint { get; set; }

    public Coordinate()
    {
        GeographyPoint = new Point(Latitude, Longitude);
    }
}