namespace PokeConceptBL;

public class Pokemon
{
    public Guid guid {get; set;}
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Base_Experience { get; set; }
    public int Height { get; set; }
    public int is_default { get; set; }
    public int Order { get; set; }
}
