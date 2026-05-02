namespace Pokemon_Connection;

public class Pokemon
{
    public int id { get; set; }
    public required string name { get; set; }
    public int base_experience { get; set; }
    public int height { get; set; }
    public bool is_default { get; set; }
    public int order { get; set; }
    public int weight { get; set; }

}
