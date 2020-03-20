#language: pt-br

@QualityAssurance
Funcionalidade: Adicionar pessoa

Cenário: Adicionar com nome inválido
	Dado que eu esteja cadastrando um usuário
	Quando eu enviar o nome '' e email 'asdasdasds'
	Então vou receber o retorno false

Cenário: Adicionar com email inválido
	Dado que eu esteja cadastrando um usuário
	Quando eu enviar o nome 'asdas' e email ''
	Então vou receber o retorno false

Cenário: Adicionar OK
	Dado que eu esteja cadastrando um usuário
	Quando eu enviar o nome 'asdas' e email 'aaasdass@ssd'
	Então vou receber o retorno true