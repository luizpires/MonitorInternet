using Serilog;
using Serilog.Sinks.File; // Adicione esta linha para usar o sink de arquivo
using System;
using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace MonitorInternet;

class Program
{
    static void Main(string[] args)
    {
        // Configuração do Serilog
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File(
                path: $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\MonitorInternet.log",
                rollingInterval: RollingInterval.Day, // Cria um novo arquivo a cada dia
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
            )
            .CreateLogger();

        Log.Information("Iniciando monitoramento da conexão com a internet...");

        while (true)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com");

                if (reply.Status != IPStatus.Success)
                {
                    Log.Error("Falha na conexão com a internet detectada.");
                }
            }
            catch (PingException ex)
            {
                Log.Error($"Erro ao verificar a conexão: {ex.Message}");
            }

            Thread.Sleep(60000); // Aguarda 1 minuto
        }
    }
}

