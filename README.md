<h3> ☕ &nbsp;EMPTY COFFEE CUPS <h3/>
  
- 📚 &nbsp; Desafio final do 1º **AeC Digital Academy** desenvolvido pela Gama Academy: <a href="https://github.com/educacao-gama/desafios-gama/tree/main/banco%20de%20curriculos/">repositório github</a>.
- 🛠 &nbsp; Desenvolvido por **Caio Cyrino, Ivanilson Ferreira, José Victor, Lucas Ramon, Lucineide Farias e Sebastião Leal.**
- 🐱 &nbsp; Gitub dos integrantes:
  
  [![GitHub Caio]( https://img.shields.io/github/followers/sbstleal?label=Caio&style=social)](https://github.com/feholy/)
  [![GitHub Ivanilson]( https://img.shields.io/github/followers/IvanFerroli?label=Ivanilson&style=social)](https://github.com/IvanFerroli/)
  [![GitHub José]( https://img.shields.io/github/followers/josevictormobile?label=José&style=social)](https://github.com/josevictormobile/)
  [![GitHub Lucas]( https://img.shields.io/github/followers/luksramon?label=Lucas&style=social)](https://github.com/luksramon/)
  [![GitHub Lucineide]( https://img.shields.io/github/followers/lucineidefarias?label=Lucineide&style=social)](https://github.com/lucineidefarias/)
  [![GitHub Sebastião]( https://img.shields.io/github/followers/sbstleal?label=Sebastião&style=social)](https://github.com/sbstleal/)
  
 ---
  
 *Ferramentas de Desenvolvimento Utilizadas*

  ![Visual Studio Code](https://img.shields.io/badge/-Visual%20Studio%20Code-333333?style=flat&logo=visual-studio-code&logoColor=007ACC)
  ![Visual Studio 2019](https://img.shields.io/badge/-Visual%20Studio%202019%20Community-333333?style=flat&logo=visual-studio&logoColor=9900CC)
  ![SQL Server](https://img.shields.io/badge/-SQL%20Server-333333?style=flat&logo=SQLserver&logoColor=007ACC)
  ![Trello](https://img.shields.io/badge/-Trello-333333?style=flat&logo=trello&logoColor=007ACC)

 *Utilitários*

  ![Postman](https://img.shields.io/badge/-Postman-333333?style=flat&logo=postman)
  
 *DevOps*

  ![Git](https://img.shields.io/badge/-Git-333333?style=flat&logo=git)
  ![GitHub](https://img.shields.io/badge/-GitHub-333333?style=flat&logo=github)
  
*Frameworks*
  
  ![Bulma](https://img.shields.io/badge/-Bulma-333333?style=flat&logo=Bulma)
  ![.NET](https://img.shields.io/badge/-DotNET%20Core-333333?style=flat&logo=DotNetCore)
  ![EF](https://img.shields.io/badge/-Entity%20Framework-333333?style=flat&logo=EF)
  
 *Documentação da WebAPI Rest*
  
 </br>http://localhost:5000/swagger/index.html</br>
 https://localhost:5001/swagger/index.html
  
 ---
  
*Comandos iniciais:*
``` bash
  mkdir nome-projeto
  cd nome-projeto
  dotnet new webapi
```

*Comandos GIT e GITHUB:*
``` bash
  git init
  git add .
  git commit -m "Iniciando projeto"
  code .gitignore # gerei o conteúdo para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: <a href="https://www.toptal.com/developers/gitignore">GITIGONRE.IO</a>.
  
  Após criado o repositório, suba para o GITHUB (utilizar o primeiro comando que o GITHUB fornece):
  
  git remote add origin git@github.com:youruser/repository.git
  git branch -M main
  git push -u origin main
```

*Pacotes utilizados:*
``` bash
  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
```

*Comandos utilizados para criar a migração:*
``` bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add ExampleAdd
dotnet ef database update
```

*Comando para instalar a ferramenta code generator:*
``` bash
dotnet tool install -g dotnet-aspnet-codegenerator
```

*Comandos para criar os scaffold's necessários:*
``` bash
dotnet aspnet-codegenerator controller -name CandidatoController -async -api -m Candidato -dc DbContexto -outDir Controllers

dotnet aspnet-codegenerator controller -name ProfissaoController -async -api -m Profissao -dc DbContexto -outDir Controllers

``` 
  
 ---
