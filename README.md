# Projeto-ASP.NET
Meu último projeto da faculdade foi um sistema WEB que permite aos funcionários da empresa acessarem todas as suas folhas de pagamento.

Desenvolvimento do Projeto:
  No processo de desenvolvimento da aplicação web, utilizamos o ambiente .AspNet MVC em conjunto com o Visual Studio como nossa IDE principal. O Visual Studio desempenhou um papel fundamental ao oferecer recursos para edição, depuração e gerenciamento do projeto, entre outros. Para criar a interface com o usuário, empregamos HTML e CSS, enquanto a lógica subjacente do aplicativo é alimentada pela linguagem C#.
  Para acessar a plataforma WEB do sistema Payroll, destina-se exclusivamente à consulta dos holerites previamente gerados para todos os colaboradores da empresa. A experiência começa na tela de login, onde o colaborador efetua o acesso por meio de seu e-mail e senha previamente cadastrados. Após o usuário acionar a função de consulta, entra em ação a parte de controle do sistema .AspNet MVC, utilizando o EntityFramework para recuperar os dados de login do funcionário no Banco de Dados SQL Server 2022, a fim de verificar se o usuário foi previamente cadastrado pelo departamento de Recursos Humanos da empresa. Se o colaborador estiver registrado no sistema, inicia-se uma sessão de conexão do usuário, ainda utilizando a ferramenta .AspNet MVC para gerenciar esse processo.
  Ao buscar o ID do funcionário que fez o login, é iniciada uma sessão que estabelece uma interação entre o usuário que fez o login e o sistema. Usando o ID do funcionário que iniciou a sessão, o sistema recupera o nome da pessoa que efetuou o login e aplica um filtro no banco de dados para exibir somente os holerites relacionados a esse usuário. Isso permite que o colaborador visualize todos os seus holerites gerados na aplicação WEB. No canto superior direito da tela, há um botão de saída que permite ao usuário encerrar a sessão no site, levando-o de volta à tela de login, caso deseje.
