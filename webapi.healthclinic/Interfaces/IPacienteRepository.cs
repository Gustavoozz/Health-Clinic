using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente pacienteCadastrado);

        void Deletar(Guid id);

        List<Paciente> Listar();

        Paciente BuscarPorId(Guid id);

        void Atualizar(Guid id, Paciente pacienteAtualizado);
    }
}
