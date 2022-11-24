namespace Pintureria.Repositorios;

using System.Collections.Generic;

using System.Linq;

using Pintureria.Aplicacion;

public class ClientSearcher : ISearcheable<Cliente> {
    EntidadesContext context;

    public ClientSearcher() {
        context = new EntidadesContext();
    }

    public List<Cliente> obtenerClientes(string Discriminator) {
        return new SqliteHelper<Cliente>(context, context.Clientes).listarTabla().Where(c => c.Discriminator == Discriminator).ToList();
    }
}
