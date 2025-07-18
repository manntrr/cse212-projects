public class Coordinates : List<Double>
{
    public Double longitude { get => base[0]; set => base[0] = value; }
    public Double latitude { get => base[1]; set => base[1] = value; }
    public Double depth { get => base[2]; set => base[2] = value; }
}