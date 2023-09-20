namespace ApiEmpresa.Models;
public class Cliente
{
    public Int32 Id { get; set; }
    public string? nombre { get; set; }
    public string? apellido{ get; set; }
    public string?direccion { get; set; }
    
    public string? telefono{ get; set; }
    
    public DateTime? fecha_nacimiento  { get; set; }
    
    
}