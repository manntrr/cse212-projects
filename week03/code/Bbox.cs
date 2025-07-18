public class Bbox : List<Double>
{
    public Double minimumLongitude { get => base[0]; set => base[0] = value; }
    public Double minimumLatitude { get => base[1]; set => base[1] = value; }
    public Double minimumDepth { get => base[2]; set => base[2] = value; }
    public Double maximumLongitude { get => base[3]; set => base[3] = value; }
    public Double maximumLatitude { get => base[4]; set => base[4] = value; }
    public Double maximumDepth { get => base[5]; set => base[5] = value; }
}
