public class Metadata : Dictionary<String, Object>
{
    public long generated { get => (long)base["generated"]; set => base["generated"] = value; }
    public String url { get => (String)base["url"]; set => base["url"] = value; }
    public String title { get => (String)base["title"]; set => base["title"] = value; }
    public String api { get => (String)base["api"]; set => base["api"] = value; }
    public int count { get => (int)base["count"]; set => base["count"] = value; }
    public int status { get => (int)base["status"]; set => base["status"] = value; }
}
