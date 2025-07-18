public class Properties : Dictionary<String, Object>
{
    public Decimal mag { get => Convert.ToDecimal(Convert.ToString(base["mag"])); set => base["mag"] = value; }
    public String place { get => Convert.ToString(base["place"]); set => base["place"] = value; }
    public long time { get => Convert.ToInt64(Convert.ToString(base["time"])); set => base["time"] = value; }
    public long updated { get => Convert.ToInt64(Convert.ToString(base["updated"])); set => base["updated"] = value; }
    public int tz { get => Convert.ToInt32(Convert.ToString(base["tz"])); set => base["tz"] = value; }
    public String url { get => Convert.ToString(base["url"]); set => base["url"] = value; }
    public String detail { get => Convert.ToString(base["detail"]); set => base["detail"] = value; }
    public int felt { get => Convert.ToInt32(Convert.ToString(base["felt"])); set => base["felt"] = value; }
    public Decimal cdi { get => Convert.ToDecimal(Convert.ToString(base["cdi"])); set => base["cdi"] = value; }
    public Decimal mmi { get => Convert.ToDecimal(Convert.ToString(base["mmi"])); set => base["mmi"] = value; }
    public String alert { get => Convert.ToString(base["alert"]); set => base["alert"] = value; }
    public String status { get => Convert.ToString(base["status"]); set => base["status"] = value; }
    public int tsunami { get => Convert.ToInt32(Convert.ToString(base["tsunami"])); set => base["tsunami"] = value; }
    public int sig { get => Convert.ToInt32(Convert.ToString(base["sig"])); set => base["sig"] = value; }
    public String net { get => Convert.ToString(base["net"]); set => base["net"] = value; }
    public String code { get => Convert.ToString(base["code"]); set => base["code"] = value; }
    public String ids { get => Convert.ToString(base["ids"]); set => base["ids"] = value; }
    public String sources { get => Convert.ToString(base["sources"]); set => base["sources"] = value; }
    public String types { get => Convert.ToString(base["types"]); set => base["types"] = value; }
    public int nst { get => Convert.ToInt32(Convert.ToString(base["nst"])); set => base["nst"] = value; }
    public Decimal dmin { get => Convert.ToDecimal(Convert.ToString(base["dmin"])); set => base["dmin"] = value; }
    public Decimal rms { get => Convert.ToDecimal(Convert.ToString(base["rms"])); set => base["rms"] = value; }
    public Decimal gap { get => Convert.ToDecimal(Convert.ToString(base["gap"])); set => base["gap"] = value; }
    public String magType { get => Convert.ToString(base["magType"]); set => base["magType"] = value; }
    public String type { get => Convert.ToString(base["type"]); set => base["type"] = value; }
}
