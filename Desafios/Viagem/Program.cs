using Microsoft.Extensions.DependencyInjection;
using Viagem.Domain.Entities;
using Viagem.Domain.Interfaces;
using Viagem.Application.Services;
using Viagem.Infrastructure.db;
using Viagem.Infrastructure.Repositories;


var services = new ServiceCollection();


services.AddDbContext<ViagemDbContext>();


services.AddScoped<IReembolsoRepository, ReembolsoRepository>();


services.AddScoped<ProcessarReembolsoService>();


var serviceProvider = services.BuildServiceProvider();


using (var scope = serviceProvider.CreateScope())
{
    
    var context = scope.ServiceProvider.GetRequiredService<ViagemDbContext>();
    
    context.Database.EnsureCreated();
}


try
{
    
    var service = serviceProvider.GetRequiredService<ProcessarReembolsoService>();
    Console.WriteLine("Thinking...");

    
    var solicitacao = new SolicitacaoReembolso("Adielson", 200, "Viagem a trabalho");

    
    await service.Executar(solicitacao.ValorTotal, solicitacao.ClienteNome!, solicitacao.Descricao!);

    Console.WriteLine("Processo Finalizado com sucesso!");

    
    var lista = await service.ListarTodos();
    Console.WriteLine("Relatorio de reembolso no banco");

    foreach (var item in lista)
    {
        Console.WriteLine($"ID: {item.Id} - Cliente: {item.ClienteNome} - Valor: {item.ValorTotal} - Descricao: {item.Descricao}");
    }
}
catch (Exception ex)
{
    
    Console.WriteLine($"Erro: {ex.Message}");
}