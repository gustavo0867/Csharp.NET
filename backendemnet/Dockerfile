# Use a imagem oficial do SDK do .NET 8.0
# O SDK inclui o runtime e todas as ferramentas necessárias para desenvolvimento (dotnet new, dotnet build, etc.)
FROM mcr.microsoft.com/dotnet/sdk:6.0.201 AS build

# Define o diretório de trabalho dentro do contêiner.
# Todos os comandos subsequentes dentro do contêiner serão executados a partir deste diretório.
WORKDIR /app

# Expõe as portas que o ASP.NET Core geralmente usa.
# A porta 80 é para HTTP e a 443 para HTTPS.
# Isso informa ao Docker que essas portas serão usadas.
EXPOSE 80
EXPOSE 443

# Opcional: Define a variável de ambiente para que o ASP.NET Core saiba que está em ambiente de desenvolvimento.
# Isso pode afetar o tratamento de erros, logs, etc.
ENV ASPNETCORE_ENVIRONMENT=Development

# Define o comando padrão que será executado quando o contêiner for iniciado
# sem um comando específico. Neste caso, ele simplesmente abre um shell bash.
# Isso é ideal para o desenvolvimento, pois você pode entrar no contêiner e executar comandos dotnet.
CMD ["/bin/bash"]