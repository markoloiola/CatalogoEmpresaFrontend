namespace CatalogoEmpregoFrontend.Dtos.Empresa;

public class EmpresaCreateUpdateDto
{
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string Cnpj { get; set; }
    public string Estado { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Cidade { get; set; }
    public string Email { get; set; }
}
