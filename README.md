
# Monitor de Conex�o com a Internet
Este � um programa simples em C# que monitora a conex�o com a internet e registra falhas e sucessos em um arquivo de log. Ele foi projetado para ser executado continuamente em segundo plano, verificando a conectividade a cada minuto.

## Como Funciona
### 1. Verifica��o 
O programa envia um ping para o Google (google.com) a cada minuto para verificar se a conex�o com a internet est� ativa.
### 2. Registro: 
Se a conex�o falhar, um erro � registrado no arquivo de log. Se a conex�o for bem-sucedida, um registro de sucesso � adicionado ao log.
### 3. Arquivo de Log 
O arquivo de log (MonitorInternet.log) � salvo na pasta "Documentos" do usu�rio que executa o programa. Um novo arquivo de log � criado a cada dia.

## Como Usar
### 1. Pr�-requisitos

#### 1.1 .NET Runtime 
Certifique-se de ter o .NET Runtime instalado em seu computador. Voc� pode baix�-lo em https://dotnet.microsoft.com/download.
#### 1.2 Serilog 
O programa utiliza a biblioteca Serilog para o registro de logs. Certifique-se de ter os pacotes NuGet Serilog e Serilog.Sinks.File instalados em seu projeto.

### 2. Compila��o
2.1 Abra o projeto no Visual Studio (ou em seu editor de c�digo C# preferido).
2.2 Compile o projeto para gerar arquivo execut�vel (MonitorInternt.exe).

### 3. Execu��o
3.1 Abra um prompt de comando ou terminal.
3.2 Navegue at� a pasta onde o arquivo execut�vel foi gerado.
3.3 Execute o programa digitando MonitorInternet.exe e pressionando Enter.
3.4 O programa come�ar� a monitorar a conex�o com a internet em segundo plano.
3.5 Para parar o programa, feche a janela do prompt de comando ou terminal.

### 4. Arquivo de Log
4.1 O arquivo de log MonitorInternet.log ser� criado na pasta "Documentos" do usu�rio.
4.2 Voc� pode abrir o arquivo de log com qualquer editor de texto para visualizar os registros de falhas e sucessos de conex�o.

## Observa��es
Este � um programa simples e n�o possui interface gr�fica. A intera��o com o usu�rio � feita atrav�s do prompt de comando ou terminal.
O programa verifica a conex�o com a internet a cada minuto. Voc� pode ajustar a frequ�ncia de verifica��o modificando o valor no Thread.Sleep(60000).
O programa utiliza o Google como servidor de teste. Se o Google estiver inacess�vel por algum motivo, o programa poder� registrar uma falha de conex�o mesmo que a internet esteja funcionando.

## C�digo-Fonte
O c�digo-fonte completo do programa est� dispon�vel neste reposit�rio. Sinta-se � vontade para modific�-lo ou adapt�-lo �s suas necessidades.

## Licen�a
Este programa � distribu�do sob a licen�a MIT. Consulte o arquivo LICENSE para obter mais informa��es.

## Contato
Se voc� tiver alguma d�vida ou sugest�o, sinta-se � vontade para entrar em contato pelo e-mail: lzpires@gmail.com

## Cr�ditos
Copyright (C) 2024 by lires